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
    public partial class FrmSelecionarTurma : Form
    {
        FrmAlunos frmAlunos;
        public FrmSelecionarTurma(FrmAlunos f)
        {
            InitializeComponent();
            frmAlunos = f;
        }

        private void FrmSelecionarTurma_Load(object sender, EventArgs e)
        {
            string vqueryDGV = @"
                    SELECT
                        tbt.N_ID_TURMA as 'CÓDIGO',
                        tbt.T_DESC_TURMA as 'TURMA',
                        tbp.T_NOME_PROFESSOR as 'PROFESSOR',
                        tbh.T_DESC_HORARIO as 'HORARIO',
                        tbt.N_MAX_ALUNOS as 'ALUNOS',
                        (   SELECT
                               count(N_ID_ALUNO)
                            FROM
                               tb_Alunos as tba
                            WHERE
                               tba.N_ID_TURMA = tbt.N_ID_TURMA and T_STATUS_ALUNO ='A'
                        )as 'MATRICULADOS'
                    FROM
                        tb_Turmas as tbt
                    INNER JOIN
                        tb_Horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO,
                        tb_Professores as tbp on tbp.N_ID_PROFESSORES = tbt.N_ID_PROFESSOR
            ";
            dgvSelTurmas.DataSource = Banco.dql(vqueryDGV);
            dgvSelTurmas.Columns[0].Width = 50;
            dgvSelTurmas.Columns[1].Width = 100;
            dgvSelTurmas.Columns[2].Width = 100;
            dgvSelTurmas.Columns[3].Width = 100;
            dgvSelTurmas.Columns[4].Width = 80;
            dgvSelTurmas.Columns[5].Width = 95;
        }

        private void dgvSelTurmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qtdAlunos = 0;
            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
            if(qtdAlunos>= maxAlunos)
            {
                MessageBox.Show("Não há vagas nesta turma");
            }
            else
            {
                frmAlunos.tb_Turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                frmAlunos.tb_Turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value;
                Close();
            }
        }
    }
}
