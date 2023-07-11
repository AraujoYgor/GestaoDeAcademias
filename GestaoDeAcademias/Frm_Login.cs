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
    public partial class Frm_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public Frm_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            string username = cbUser.Text;
            string senha = tb_Senha.Text;

            if(username == "" || senha == "")
            {
                MessageBox.Show("Usuario e/ou senha invalidos");
                cbUser.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_Usuarios WHERE T_Username='" + username+ "' AND T_SenhaUsuario ='"+senha+"'";
            dt = Banco.dql(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lbl_Acesso.Text = dt.Rows[0].ItemArray[4].ToString();
                form1.lbl_Usuario.Text = dt.Rows[0].ItemArray[1].ToString();
                form1.pbLedLogado.Image = Properties.Resources.ledVerde;
                Globais.nivel = int.Parse(dt.Rows[0].ItemArray[5].ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrados");
            }

        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            //Preencher combobox Usuarios
            string vqueryUsuarios = @"
                    SELECT
                        T_Username
                    FROM
                        tb_Usuarios
                    ORDER BY
                        T_Username
            ";
            cbUser.Items.Clear();
            cbUser.DataSource = Banco.dql(vqueryUsuarios);
            cbUser.DisplayMember = "T_Username";
        }

        private void pbConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
