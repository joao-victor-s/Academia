using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academia
{
    public partial class F_NovoProf : Form
    {
        public F_NovoProf()
        {
            InitializeComponent();
        }

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

        private void F_NovoProf_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Ativo", "Ativo");
            dic.Add("Paralisado", "Paralisado");
            dic.Add("Cancelado", "Cancelado");
            cb_status_prof.Items.Clear();
            cb_status_prof.DataSource = new BindingSource(dic, null);
            cb_status_prof.DisplayMember = "Value";
            cb_status_prof.ValueMember = "Key";

        }

        private void btn_salvar_aluno_Click_1(object sender, EventArgs e)
        {
            if (tb_nome_prof.Text != "" && mtb_tel_prof.Text != "" && cb_status_prof.Text != "")
            {
                if (destinoCompleto == "")
                {
                    if (MessageBox.Show("Nenhuma foto anexada. Deseja continuar?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    { 
                        return;
                    }
                }
                else
                {
                    System.IO.File.Copy(origemCompleto, destinoCompleto, true); 
                    if (File.Exists(destinoCompleto))
                    {
                        pictureBox1.ImageLocation = destinoCompleto;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao localizar foto.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
               
                string vqueryInsertProf = string.Format(@"
                INSERT INTO tb_professores
                    (T_NOME_PROF, T_TEL_PROF, T_STATUS_PROF, T_FOTO_PROF)
                 VALUES
                    ('{0}', '{1}', '{2}', '{3}')", tb_nome_prof.Text, mtb_tel_prof.Text, cb_status_prof.SelectedValue, destinoCompleto);
                Banco_de_Dados_Acad.dml(vqueryInsertProf);


                tb_nome_prof.Clear();
               
                mtb_tel_prof.Clear();
                pictureBox1.ImageLocation = "";
                tb_nome_prof.Focus();
            }
            
        }

        private void btn_adc_foto_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminhoFotos;
            destinoCompleto = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName; 
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe. Deseja substituir?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            pictureBox1.ImageLocation = origemCompleto;


            System.IO.File.Copy(origemCompleto, destinoCompleto, true);
            if (File.Exists(destinoCompleto))
            {
                pictureBox1.ImageLocation = destinoCompleto;
            }
            else
            {
                MessageBox.Show("Arquivo não copiado", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        
    } 
}

