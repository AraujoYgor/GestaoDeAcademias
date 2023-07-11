using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestaoDeAcademias
{
    public partial class FrmGestaoDeAlunos : Form
    {
        string vqueryDGV = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFoto;
        string destinoCompleto = "";

        public FrmGestaoDeAlunos()
        {
            InitializeComponent();
        }

        private void FrmGestaoDeAlunos_Load(object sender, EventArgs e)
        {
            //carregar dgvAlunos
            CarregarDGV();

            CarregarTurmas();

            //preencher o comboox status
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativo");
            st.Add("B", "Bloqueado");
            st.Add("D", "Desativado");
            cbStatus.DataSource = new BindingSource(st, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";

            turma = cbTurma.Text;
            turmaAtual = cbTurma.Text;
            idSelecionado = dgvAlunos.Rows[0].Cells[0].Value.ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vqueryDGV = @"
               SELECT
                 N_ID_ALUNO as 'CÓDIGO',
                 T_NOME_ALUNO as 'ALUNO',
                 T_TEL_ALUNO as 'TELEFONE'
               FROM
                 tb_Alunos
               WHERE
                 T_NOME_ALUNO LIKE'" + tbPesquisa.Text + "%'";

            dgvAlunos.DataSource = Banco.dql(vqueryDGV);
            dgvAlunos.Columns[0].Width = 70;
            dgvAlunos.Columns[1].Width = 150;
            dgvAlunos.Columns[2].Width = 100;
            tbPesquisa.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmAlunos frmAlunos = new FrmAlunos();
            frmAlunos.ShowDialog();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            turma = cbTurma.Text;
            if (turmaAtual != turma)
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);
                if (vagas < 1)
                {
                    MessageBox.Show("Não há vagas na turma selecionada, escolha outra turna.");
                    cbTurma.Focus();
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pbFoto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar foto, deseja continuar?", "Erro", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            //linha = dgvAlunos.SelectedRows[0].Index;
            string vqueryAtualiarAluno = String.Format(@"
                        UPDATE
                            tb_Alunos
                        SET
                            T_NOME_ALUNO='{1}',
                            T_TEL_ALUNO='{2}',
                            T_STATUS_ALUNO= '{3}',
                            N_ID_TURMA= {4},
                            T_FOTO_ALUNO= '{5}'
                        WHERE N_ID_ALUNO = {0} ", tbId.Text,  tbNome.Text, tbTelefone.Text, cbStatus.SelectedValue, cbTurma.SelectedValue, destinoCompleto);
                Banco.dml(vqueryAtualiarAluno);
                //dgvAlunos[1, linha].Value = tbNome.Text;
            
            //MessageBox.Show("tumas iguais a query não será executada");
            tbId.Clear();
            tbNome.Clear();
            tbTelefone.Clear();
            cbStatus.SelectedIndex = 0;
            cbTurma.SelectedIndex = 0;
            pbFoto.ImageLocation = "";
            CarregarDGV();
            CarregarTurmas();
        }
        private void btnFinanceiro_Click(object sender, EventArgs e)
        {

        }

        private void dgvAlunos_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //MessageBox.Show(tbId.Text);
            if(dgv.SelectedRows.Count > 0)
            {
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"
                         SELECT
                            N_ID_ALUNO,
                            T_NOME_ALUNO,
                            T_TEL_ALUNO,
                            T_STATUS_ALUNO,
                            N_ID_TURMA,
                            T_FOTO_ALUNO
                        FROM
                            tb_Alunos
                        WHERE 
                            N_ID_ALUNO ='"+idSelecionado+"'";
                DataTable dt = Banco.dql(vqueryCampos);
                tbId.Text = dt.Rows[0].Field<Int64>("N_ID_ALUNO").ToString();
                tbNome.Text = dt.Rows[0].Field<string>("T_NOME_ALUNO");
                tbTelefone.Text = dt.Rows[0].Field<string>("T_TEL_ALUNO");
                cbStatus.SelectedValue = dt.Rows[0].Field<string>("T_STATUS_ALUNO");
                cbTurma.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_TURMA");
                pbFoto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO_ALUNO");
                turmaAtual = cbTurma.Text;
            }
        }
        private void CarregarDGV()
        {
            //Preenche o dgvAlunos 
            string vqueryDGV = @"
               SELECT
                 N_ID_ALUNO as 'CÓDIGO',
                 T_NOME_ALUNO as 'ALUNO',
                 T_TEL_ALUNO as 'TELEFONE'
               FROM
                 tb_Alunos
               WHERE
                 T_NOME_ALUNO LIKE'" + tbPesquisa.Text + "%'";

            dgvAlunos.DataSource = Banco.dql(vqueryDGV);
            dgvAlunos.Columns[0].Width = 70;
            dgvAlunos.Columns[1].Width = 150;
            dgvAlunos.Columns[2].Width = 100;
            tbPesquisa.Clear();
        }

        private void CarregarTurmas()
        {
            //preenche o Combobox turmas
            string vqueryTurmas = @"
                SELECT
                    tbt.N_ID_TURMA,
                        ('Vagas: '||( (N_MAX_ALUNOS)-(SELECT
                                                            count(tba.N_ID_ALUNO)
                                                        FROM
                                                            tb_Alunos as tba
                                                        WHERE
                                                            tba.T_STATUS_ALUNO ='A' and tba.N_ID_TURMA = tbt.N_ID_TURMA
                                                        )
                                    )|| ' | Turma: '||T_DESC_TURMA
                        ) as 'TURMA'
                    FROM
                        tb_Turmas as tbt
                    ORDER BY
                        N_ID_TURMA
            ";
            cbTurma.DataSource = Banco.dql(vqueryTurmas);
            cbTurma.DisplayMember = "TURMA";
            cbTurma.ValueMember = "N_ID_TURMA";
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("O arquivo já existe deseja substituir?", "Subistituir?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                pbFoto.ImageLocation = destinoCompleto;
            }
            else
            {
                MessageBox.Show("Arquivo não inserido!");
            }
        }

        private void Carteirinha_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;
        private void btnCarteira_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
