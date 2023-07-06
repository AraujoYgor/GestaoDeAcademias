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

            }
        }
    }
}
