using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeAcademias
{
    public partial class FrmProfessores : Form
    {
        public FrmProfessores()
        {
            InitializeComponent();
        }

        private void FrmProfessores_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnSalva.Enabled = false;
            btnExcluir.Enabled = false;
            tbProfessor.Enabled = false;
            mtdTelefone.Enabled = false;
            string vquery = @"  
                SELECT
                    N_ID_PROFESSORES AS 'Código',
                    T_NOME_PROFESSOR AS 'Professor',
                    T_TEL_PROFESSOR AS 'Telefone'
                FROM
                    tb_Professores
            ";
            dgvProfessores.DataSource = Banco.dql(vquery);
            dgvProfessores.Columns[0].Width = 65;
            dgvProfessores.Columns[1].Width = 205;
            dgvProfessores.Columns[2].Width = 100;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbId.Clear();
            tbProfessor.Clear();
            mtdTelefone.Clear();
            tbProfessor.Enabled = true;
            mtdTelefone.Enabled = true;
            btnEditar.Enabled = false;
            btnSalva.Enabled = true;
            tbProfessor.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tbProfessor.Enabled = true;
            mtdTelefone.Enabled = true;
            string vquery = @"UPDATE tb_Professores SET T_NOME_PROFESSOR='"+tbProfessor.Text+"', T_TEL_PROFESSOR='"+mtdTelefone.Text+"' WHERE N_ID_PROFESSORES='"+tbId.Text+"'";
            Banco.dml(vquery);
            MessageBox.Show("Dados atualizados com sucesso!");
            vquery = @"  
                SELECT
                    N_ID_PROFESSORES AS 'Código',
                    T_NOME_PROFESSOR AS 'Professor',
                    T_TEL_PROFESSOR AS 'Telefone'
                FROM
                    tb_Professores
            ";
            dgvProfessores.DataSource = Banco.dql(vquery);
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {

            string vquery = "INSERT INTO tb_Professores (T_NOME_PROFESSOR, T_TEL_PROFESSOR) VALUES ('"+tbProfessor.Text+"','"+mtdTelefone.Text+"')";
            Banco.dml(vquery);
            MessageBox.Show("Dados cadastrados com sucesso!");
            vquery = @"  
                SELECT
                    N_ID_PROFESSORES AS 'Código',
                    T_NOME_PROFESSOR AS 'Professor',
                    T_TEL_PROFESSOR AS 'Telefone'
                FROM
                    tb_Professores
            ";
            dgvProfessores.DataSource = Banco.dql(vquery);
            tbProfessor.Enabled = false;
            mtdTelefone.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_Professores WHERE N_ID_PROFESSORES="+tbId.Text;
                Banco.dml(vquery);
                vquery = @"  
                SELECT
                    N_ID_PROFESSORES AS 'Código',
                    T_NOME_PROFESSOR AS 'Professor',
                    T_TEL_PROFESSOR AS 'Telefone'
                FROM
                    tb_Professores
            ";
                dgvProfessores.DataSource = Banco.dql(vquery);
                tbId.Clear();
                tbProfessor.Clear();
                mtdTelefone.Clear();
                tbProfessor.Enabled = false;
                mtdTelefone.Enabled = false;
            }
        }

        private void dgvProfessores_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT
                        *
                    FROM
                        tb_Professores
                    WHERE
                        N_ID_PROFESSOREs=" + vid
                        ;
                dt = Banco.dql(vquery);
                tbId.Text = dt.Rows[0].Field<Int64>("N_ID_PROFESSORES").ToString();
                tbProfessor.Text = dt.Rows[0].Field<string>("T_NOME_PROFESSOR");
                mtdTelefone.Text = dt.Rows[0].Field<string>("T_TEL_PROFESSOR");
                tbProfessor.Enabled = true;
                mtdTelefone.Enabled = true;
                btnSalva.Enabled = false;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
