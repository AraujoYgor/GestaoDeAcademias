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
    public partial class FrmHorarios : Form
    {
        public FrmHorarios()
        {
            InitializeComponent();
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            btnEditar.Visible = true;
            btnSalva.Visible = false;
            string vquery = @"  
                SELECT
                    N_ID_HORARIO AS 'Código',
                    T_DESC_HORARIO AS 'Horário'
                FROM
                    tb_Horarios
            ";
            dgvHorarios.DataSource = Banco.dql(vquery);
            dgvHorarios.Columns[0].Width = 65;
            dgvHorarios.Columns[1].Width = 105;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            btnSalva.Visible = true;
            tbId.Clear();
            mtdHorario.Clear();
            mtdHorario.Focus();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string vquery = "INSERT INTO tb_Horarios (T_DESC_HORARIO) VALUES ('"+mtdHorario.Text+"')";
            Banco.dml(vquery);
            vquery = @"  
                SELECT
                    N_ID_HORARIO AS 'Código',
                    T_DESC_HORARIO AS 'Horário'
                FROM
                    tb_Horarios
            ";
            dgvHorarios.DataSource = Banco.dql(vquery);
            btnEditar.Visible = true;
            btnSalva.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string vquery = @"UPDATE tb_Horarios SET T_DESC_HORARIO ='"+mtdHorario.Text+ "' WHERE N_ID_HORARIO = '"+tbId.Text+"'";
            Banco.dml(vquery);
            MessageBox.Show("Dados atualizados com sucesso!");
            vquery = @"  
                SELECT
                    N_ID_HORARIO AS 'Código',
                    T_DESC_HORARIO AS 'Horário'
                FROM
                    tb_Horarios
            ";
            dgvHorarios.DataSource = Banco.dql(vquery);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_Horarios WHERE N_ID_HORARIO=" + tbId.Text;
                Banco.dml(vquery);
                vquery = @"  
                SELECT
                    N_ID_HORARIO AS 'Código',
                    T_DESC_HORARIO AS 'Horário'
                FROM
                    tb_Horarios
            ";
                dgvHorarios.DataSource = Banco.dql(vquery);
            }
        }
        private void dgvHorarios_DoubleClick(object sender, EventArgs e)
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
                        tb_Horarios
                    WHERE
                        N_ID_HORARIO=" + vid
                        ;
                dt = Banco.dql(vquery);
                tbId.Text = dt.Rows[0].Field<Int64>("N_ID_HORARIO").ToString();
                mtdHorario.Text = dt.Rows[0].Field<string>("T_DESC_HORARIO");
                btnEditar.Visible = true;
                btnSalva.Visible = false;
            }
        }
    }
}
