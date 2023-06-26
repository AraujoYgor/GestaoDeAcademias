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
    public partial class FrmGestaoDeUsuarios : Form
    {
        public FrmGestaoDeUsuarios()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

           FrmUsuarios frmUsuarios = new FrmUsuarios();
           frmUsuarios.ShowDialog();
           dgvUsuarios.DataSource = Banco.ObterUsuarioDGW();

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            int linha = dgvUsuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.Id = Convert.ToInt32(tbId.Text);
            u.Nome = tbNome.Text;
            u.Login = tbLogin.Text;
            u.Senha = tbSenha.Text;
            u.Status = cbStatus.Text;
            u.Nivel =Convert.ToInt32(Math.Round(nudNivel.Value,0));
            Banco.AtualizarUsuario(u);
            dgvUsuarios.DataSource = Banco.ObterUsuarioDGW();
            dgvUsuarios.CurrentCell = dgvUsuarios[0, linha];
            MessageBox.Show("Dados alterados com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Você tem certeza que vai excluir este usuário?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                Banco.ExcluirUsuario(tbId.Text);
                dgvUsuarios.DataSource = Banco.ObterUsuarioDGW();

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FrmGestaoDeUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Banco.ObterUsuarioDGW();
            dgvUsuarios.Columns[0].Width = 60;
            dgvUsuarios.Columns[1].Width = 100;

        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuarioDGW(vid);
                tbId.Text = dt.Rows[0].Field<Int64>("N_IdUsuario").ToString();
                tbNome.Text = dt.Rows[0].Field<string>("T_NomeUsuario").ToString();
                tbLogin.Text = dt.Rows[0].Field<string>("T_Username").ToString();
                tbSenha.Text = dt.Rows[0].Field<string>("T_SenhaUsuario").ToString();
                cbStatus.Text = dt.Rows[0].Field<string>("T_StatusUsuario").ToString();
                nudNivel.Value = dt.Rows[0].Field<Int64>("N_NivelUsuario");
            }
        }
    }
}
