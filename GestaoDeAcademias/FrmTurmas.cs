using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GestaoDeAcademias
{
    public partial class FrmTurmas : Form
    {
        public FrmTurmas()
        {
            InitializeComponent();
        }

        private void FrmTurmas_Load(object sender, EventArgs e)
        {
            string vqueryDGV = @"
                    SELECT
                        tbt.N_ID_TURMA as 'CÓDIGO',
                        tbt.T_DESC_TURMA as 'TURMA',
                        tbp.T_NOME_PROFESSOR as 'PROFESSOR',
                        tbh.T_DESC_HORARIO as 'HORARIO',
                        tbt.N_MAX_ALUNOS as 'ALUNOS'
                    FROM
                        tb_Turmas as tbt
                    INNER JOIN
                        tb_Horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO,
                        tb_Professores as tbp on tbp.N_ID_PROFESSORES = tbt.N_ID_PROFESSOR
            ";
            dgvTurmas.DataSource = Banco.dql(vqueryDGV);
            dgvTurmas.Columns[0].Width = 50;
            dgvTurmas.Columns[1].Width = 80;
            dgvTurmas.Columns[2].Width = 100;
            dgvTurmas.Columns[3].Width = 100;
            dgvTurmas.Columns[4].Width = 60;

            //Preencher Combobox Professores
            string vqueryProfessores = @"
                SELECT
                    N_ID_PROFESSORES,
                    T_NOME_PROFESSOR
                FROM
                    tb_Professores
                ORDER BY
                    T_NOME_PROFESSOR
            ";
            cbProfeessor.Items.Clear();
            cbProfeessor.DataSource = Banco.dql(vqueryProfessores);
            cbProfeessor.DisplayMember = "T_NOME_PROFESSOR";
            cbProfeessor.ValueMember = "N_ID_PROFESSORES";

            //Preencher combobox Horarios
            string vqueryHorarios = @"
                    SELECT
                        *
                    FROM
                        tb_Horarios
                    ORDER BY
                        T_DESC_HORARIO
            ";
            cbHorario.Items.Clear();
            cbHorario.DataSource = Banco.dql(vqueryHorarios);
            cbHorario.DisplayMember = "T_DESC_HORARIO";
            cbHorario.ValueMember = "N_ID_HORARIO";

            //Preencher combobox status (Ativa = A, Paralisada = P, Cancelada = C )
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cbStatus.Items.Clear();
            cbStatus.DataSource = new BindingSource(st, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
        }

        private void dgvTurmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vqueryTurmas = @"
                    SELECT
                        *          
                    FROM
                        tb_Turmas
                    WHERE
                        N_ID_TURMA =" + vid;
                dt = Banco.dql(vqueryTurmas);
                tbId.Text = dt.Rows[0].Field<Int64>("N_ID_TURMA").ToString();
                tbTurma.Text = dt.Rows[0].Field<string>("T_DESC_TURMA");
                cbProfeessor.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_PROFESSOR").ToString();
                cbHorario.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_HORARIO").ToString();
                nudAlunos.Value = dt.Rows[0].Field<Int64>("N_MAX_ALUNOS");
                cbStatus.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                CalcularVagas();
            }
        }

        private void LimparCampos()
        {
            tbId.Clear();
            tbTurma.Clear();
            cbProfeessor.SelectedIndex = -1;
            cbHorario.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            nudAlunos.Value = 0;
            tbTurma.Focus();
            tb_Vagas.Clear();
        }
        private void AtualizarDGV()
        {
            string vquery = @"
                    SELECT
                        tbt.N_ID_TURMA as 'CÓDIGO',
                        tbt.T_DESC_TURMA as 'TURMA',
                        tbp.T_NOME_PROFESSOR as 'PROFESSOR',
                        tbh.T_DESC_HORARIO as 'HORARIO',
                        tbt.N_MAX_ALUNOS as 'ALUNOS'
                    FROM
                        tb_Turmas as tbt
                    INNER JOIN
                        tb_Horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO,
                        tb_Professores as tbp on tbp.N_ID_PROFESSORES = tbt.N_ID_PROFESSOR
                    ";
            dgvTurmas.DataSource = Banco.dql(vquery);
        }

        private void CalcularVagas()
        {
            DataTable dt = new DataTable();
            //Calculo de vagas
            string queryVagas = @"
                        SELECT
                            COUNT(N_ID_ALUNO) as 'conteVagas'
                        FROM
                            tb_Alunos
                        WHERE
                            T_STATUS_ALUNO = 'A' AND N_ID_TURMA='" + tbId.Text + "'";
            dt = Banco.dql(queryVagas);
            int vagasT = Int32.Parse(Math.Round(nudAlunos.Value, 0).ToString());
            int alunoM = Int32.Parse(dt.Rows[0].Field<Int64>("conteVagas").ToString());
            var result = vagasT - alunoM;
            if (result > 0)
            {
                tb_Vagas.Text = "Há " + result + ", vagas abertas nesta turma";

            }
            else if (result == 0)
            {
                tb_Vagas.Text = ("Não há mais vagas nesta turma!");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string vquery = "INSERT INTO tb_Turmas (T_DESC_TURMA, N_ID_PROFESSOR, N_ID_HORARIO, N_MAX_ALUNOS, T_STATUS) VALUES ('" + tbTurma.Text + "','" + cbProfeessor.SelectedValue +"', '"+cbHorario.SelectedValue + "', '"+nudAlunos.Value +"', '"+cbStatus.SelectedValue + "')";
            Banco.dml(vquery);
            MessageBox.Show("Dados cadastrados com sucesso!");
            AtualizarDGV();
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tbId.Text != "")
            {
                string vquery = @"UPDATE tb_Turmas SET T_DESC_TURMA='" + tbTurma.Text + "', N_ID_PROFESSOR='" + cbProfeessor.SelectedValue + "' , N_ID_HORARIO='" + cbHorario.SelectedValue + "', N_MAX_ALUNOS='" + nudAlunos.Value + "', T_STATUS='" + cbStatus.SelectedValue + "' WHERE N_ID_TURMA='" + tbId.Text + "'";
                Banco.dml(vquery);
                MessageBox.Show("Dados atualizados com sucesso!");
                AtualizarDGV();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione uma turma para poder alterar os dados");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbId.Text != "")
            {
                DialogResult res = MessageBox.Show("Confirmar exclusão?", "Excluir?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    string vquery = "DELETE FROM tb_Turmas WHERE N_ID_TURMA=" + tbId.Text;
                    Banco.dml(vquery);
                    AtualizarDGV();
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma turma foi selecionada para ser exluida");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.png");
            logo.ScaleToFit(140f, 120f);
            //logo.Alignment = Element.ALIGN_LEFT;
            logo.SetAbsolutePosition(20f, 720f); //x, -y

            string dados = "";

            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("CFB Cursos - Curso de C#\n");
            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Add("Relatorio de Turmas\n");
            //paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Add("\n\n\n ");

            PdfPTable tabela = new PdfPTable(4);
            tabela.DefaultCell.FixedHeight = 20;

            //PdfPCell celula = new PdfPCell(new Phrase("TABELA DE TURMAS"));
            //celula.Colspan = 4; //LINHA 1 MESCLADA
            //celula.Rotation = 90;
            //tabela.AddCell(celula);

            tabela.AddCell("CÓDIGO");
            tabela.AddCell("TURMA");
            tabela.AddCell("PROFESSOR");
            tabela.AddCell("HORÁRIO");

            string vqueryDGV = @"
                    SELECT
                        tbt.N_ID_TURMA as 'CÓDIGO',
                        tbt.T_DESC_TURMA as 'TURMA',
                        tbp.T_NOME_PROFESSOR as 'PROFESSOR',
                        tbh.T_DESC_HORARIO as 'HORARIO',
                        tbt.N_MAX_ALUNOS as 'ALUNOS'
                    FROM
                        tb_Turmas as tbt
                    INNER JOIN
                        tb_Horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO,
                        tb_Professores as tbp on tbp.N_ID_PROFESSORES = tbt.N_ID_PROFESSOR
                    ";
            dgvTurmas.DataSource = Banco.dql(vqueryDGV);
            DataTable dtTurmas = Banco.dql(vqueryDGV);
            for(int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("CÓDIGO").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("TURMA"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("PROFESSOR"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("HORARIO"));
            }

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o Relatorio?", "Relatorio", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }
        }

        private void nudAlunos_ValueChanged(object sender, EventArgs e)
        {
            CalcularVagas();
        }
    }
}
