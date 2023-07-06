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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Frm_Login frm_Login = new Frm_Login(this);
            frm_Login.ShowDialog();
        }

        private void abriFrom(int nivel, Form f)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuário logado");
            }

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login(this);
            frm_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_Acesso.Text = "0";
            lbl_Usuario.Text = "---";
            pbLedLogado.Image = Properties.Resources.ledVermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestaoDeUsuarios frmGestaoDeUsuarios = new FrmGestaoDeUsuarios();
            abriFrom(2, frmGestaoDeUsuarios);
        }

        private void haráriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHorarios frmHorarios = new FrmHorarios();
            abriFrom(2, frmHorarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessores frmProfessores = new FrmProfessores();
            abriFrom(2, frmProfessores);
        }

        private void tURMASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTurmas frmTurmas = new FrmTurmas();
            abriFrom(2, frmTurmas);
        }
    }
}
