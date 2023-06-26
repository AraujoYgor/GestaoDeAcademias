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
    public partial class FrmUsuarios : Form
    {
        DataTable dt = new DataTable();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((tbNome.Text == "") || (tbLogin.Text == "") || (tbSenha.Text == ""))
            {
                MessageBox.Show("É necessario o Nome, Login e Senha para cadastrar um novo usuário");
                tbNome.Focus();

            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Nome = tbNome.Text;
                usuario.Login = tbLogin.Text;
                usuario.Senha = tbSenha.Text;
                usuario.Status = cbStatus.Text;
                usuario.Nivel = Convert.ToInt32(Math.Round(nudNivel.Value, 0));

                Banco.NovoUsuario(usuario);
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbLogin.Clear();
            tbSenha.Clear();
            cbStatus.Text = "SELECIONE";
            nudNivel.Value = 1;
            tbNome.Focus();
        }
    }
}
