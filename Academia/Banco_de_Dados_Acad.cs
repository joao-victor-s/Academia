using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Academia
{
    class Banco_de_Dados_Acad
    {
        private static SQLiteConnection conexao; 
        
        //////////////Métodos Genéricos
        private static SQLiteConnection ConexaoBancodeDados()
        {
            conexao = new SQLiteConnection("Data Source="+Globais.caminhoBD + Globais.nomeBD); 
            

            conexao.Open(); 
            return conexao; 
        }

        
        public static DataTable dql(string sql) 
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBancodeDados();
                var cmd = vcon.CreateCommand(); 

                cmd.CommandText = sql; 
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon); 
                dataAdapter.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public static void dml(string query, string msgOK = null, string msgError = null) 
        {
            SQLiteDataAdapter dataAdapter = null;
            try
            {
                var vcon = ConexaoBancodeDados();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = query;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery(); 
                vcon.Close();

                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if(msgError != null)
                {
                    MessageBox.Show(msgError+"\n"+ex.Message);
                }
                
            }
        }

        //////////////////Métodos do Form F_NovoAdm
        /////////////////Diferentes formas de realizar a mesma ação 
        public static DataTable ObterTodosUsuarios()
        {

            SQLiteDataAdapter dataAdapter = null; 
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBancodeDados();
                var cmd = vcon.CreateCommand(); 
                
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon); 
                dataAdapter.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public static void NovoAdm(Administradores adms)
        {

            if (ExisteAdm(adms))
            {
                MessageBox.Show("Username já registrado.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            try
            {
                var vcon = ConexaoBancodeDados();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)"; //parametros para entrada de dados no banco
                cmd.Parameters.AddWithValue("@nome", adms.T_Nome);
                cmd.Parameters.AddWithValue("@username", adms.T_Username);
                cmd.Parameters.AddWithValue("@senha", adms.T_Senha);
                cmd.Parameters.AddWithValue("@status", adms.T_Status);
                cmd.Parameters.AddWithValue("@nivel", adms.N_Nivel);
                cmd.ExecuteNonQuery(); 
                MessageBox.Show("Administrator inserido");
                vcon.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao registrar Administrador.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }

        }

        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter dataAdapter = null; 
            
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBancodeDados();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO="+id; 
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon); 
                dataAdapter.Fill(dt); 
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex; 
                throw ex; 
            }
        }
        public static void AtualizarDados(Administradores adm)
        {

            SQLiteDataAdapter dataAdapter = null; 
            try
            {
                var vcon = ConexaoBancodeDados();
                var cmd = vcon.CreateCommand(); 
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO='"+adm.T_Nome+"', T_USERNAME='"+adm.T_Username+"', T_SENHAUSUARIO='" +adm.T_Senha+"', T_STATUSUSUARIO='"+adm.T_Status+"', N_NIVELUSUARIO="+adm.N_Nivel+" WHERE N_IDUSUARIO="+adm.N_ID;
              
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon); 
                cmd.ExecuteNonQuery(); 
                vcon.Close();
                

            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public static void ExcluirAdm(string id)
        {//vamos obter os usuarios retornando um objeto do tipo datatable

            SQLiteDataAdapter dataAdapter = null;
            try
            {
                var vcon = ConexaoBancodeDados();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_ID=" + id;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery(); //não precisa retornar nada, só lancar a query
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex; //returna o erro
            }
        }


        public static bool ExisteAdm(Administradores adms)
        {
            bool res;
            SQLiteDataAdapter dataAdapter = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBancodeDados();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='"+adms.T_Username+"'";
            dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
                res = true;
            else
                res = false;

            return res;
        }
    }
}
