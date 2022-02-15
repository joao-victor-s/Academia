using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_Login : Form
    {
        F_Principal form1;
        DataTable dt = new DataTable();

        public F_Login(F_Principal formulario)
        {
            InitializeComponent();
            form1 = formulario; 
            
        }


        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string T_Username = tb_username.Text;
            string T_Senha = tb_senha.Text;

            if (T_Username == "" || T_Senha == "")
            {
                MessageBox.Show("Autenticação falhou. Verifique seu usuário e senha.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tb_username.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME = '"+T_Username+"' AND T_SENHAUSUARIO = '"+T_Senha+"'";
           
            dt = Banco_de_Dados_Acad.dql(sql); 
            
            if (dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString(); 
                form1.lb_usuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
              
                form1.pb_ledLogado.Image = Properties.Resources.led_verde;

                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado", "Problema de Acesso:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }
    }
}
