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
    public partial class F_NovoAdm : Form
    {
        public F_NovoAdm()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
                Administradores adms = new Administradores(); //chama a classe
                adms.T_Nome = tb_nome.Text;
                adms.T_Username = tb_username.Text;
                adms.T_Senha = tb_senha.Text;
                adms.T_Status = cb_status.Text;
                adms.N_Nivel = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                
                Banco_de_Dados_Acad.NovoAdm(adms);
            

               

                Close();
               
            
            
        }
    }
}
