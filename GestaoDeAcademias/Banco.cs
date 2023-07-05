using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GestaoDeAcademias
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection(@"Data Source="+Globais.caminhoBanco+Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        //Funções Genericas

        public static DataTable dql(string dql) // Data Query Language (Select)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {

                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = dql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string dml,string  msgOK=null, string msgErro=null) // Data Manipulation Language (Insert, Delete, Update)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = dml;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if(msgErro != null)
                {
                    MessageBox.Show(msgErro+"\n"+ ex.Message);
                }
                throw ex;
            }
        }

        //Fim das Funçoes Genericas


        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_Usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static DataTable inserir (string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void NovoUsuario(Usuario u)
        {
            if (exiteUsername(u))
            {
                MessageBox.Show("Login já existe, por favor escolhe outro para poder cadastrar");
                return;
            }
            try
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();

                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_Usuarios(T_NomeUsuario, T_Username, T_SenhaUsuario, T_StatusUsuario, N_NivelUsuario) VALUES(@Nome, @Login, @Senha, @Status, @Nivel)";
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Login", u.Login);
                cmd.Parameters.AddWithValue("@Senha", u.Senha);
                cmd.Parameters.AddWithValue("@Status", u.Status);
                cmd.Parameters.AddWithValue("@Nivel", u.Nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario cadastrado com sucesso!");
                vcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar novo Usuário "+ ex);
            }
        }

        public static bool exiteUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText="SELECT T_USERNAME FROM tb_Usuarios WHERE T_USERNAME='" + u.Login + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }

        public static DataTable ObterUsuarioDGW()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IdUsuario as 'CÓDIGO', T_NomeUsuario as 'NOME' FROM tb_Usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosUsuarioDGW(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_Usuarios WHERE N_IdUsuario="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_Usuarios SET T_NomeUsuario='"+u.Nome+"', T_Username='"+u.Login+"', T_SenhaUsuario='"+u.Senha+"', T_StatusUsuario='"+u.Status+"', N_NivelUsuario="+u.Nivel+" WHERE N_IdUsuario= "+u.Id+"";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExcluirUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_Usuarios WHERE N_IdUsuario="+ id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
