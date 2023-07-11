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
    public partial class FrmAlunos : Form
    {
        public FrmAlunos()
        {
            InitializeComponent();
        }

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFoto;
        string destinoCompleto = "";

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            Desabilitar();
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativo");
            st.Add("B", "Bloqueado");
            st.Add("D", "Desativado");
            cbStatus.Items.Clear();
            cbStatus.DataSource = new BindingSource(st, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            Habilitar();
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (tbNome.Text == "")
            {
                MessageBox.Show("Para cadastrar um Aluno informe o Nome");
            }
            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
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
                string vquery = "INSERT INTO tb_Alunos (T_NOME_ALUNO, T_TEL_ALUNO, T_STATUS_ALUNO, N_ID_TURMA, T_FOTO_ALUNO) VALUES ('" + tbNome.Text + "','" + tbTelefone.Text + "', '" + cbStatus.SelectedValue + "', '" + tb_Turma.Tag + "', '"+destinoCompleto+"')";
                Banco.dml(vquery);
                MessageBox.Show("Dados cadastrados com sucesso!");
                Limpar();
                Desabilitar();
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            Desabilitar();
        }

        private void Limpar()
        {
            tbNome.Clear();
            tbTelefone.Clear();
            tbPlano.Clear();
            tb_Turma.Clear();
            cbStatus.SelectedIndex = 0;
            pbFoto.ImageLocation = null;
            Desabilitar();
        }

        private void Habilitar()
        {
            tbNome.Enabled = true;
            tbTelefone.Enabled = true;
            cbStatus.Enabled = true;
            btnPlanos.Enabled = true;
            btnTurmas.Enabled = true;
            btnNovo.Enabled = false;
            btnSalva.Enabled = true;
            btnLimpar.Enabled = true;
        }
        private void Desabilitar()
        {
            tbNome.Enabled = false;
            tbTelefone.Enabled = false;
            cbStatus.Enabled = false;
            btnPlanos.Enabled = false;
            btnTurmas.Enabled = false;
            btnNovo.Enabled = true;
            btnSalva.Enabled = false;
            btnLimpar.Enabled = false;
            btnPlanos.Enabled = false;
            btnTurmas.Enabled = false;
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            FrmSelecionarTurma frmSelecionarTurma = new FrmSelecionarTurma(this);
            frmSelecionarTurma.ShowDialog();
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
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
    }
}
