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
    public partial class F_NovoAluno : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        public F_NovoAluno()
        {
            InitializeComponent();
        }

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            //Popular ComboBox status
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Ativo", "Ativo");
            dic.Add("Paralisado", "Paralisado");
            dic.Add("Cancelado", "Cancelado");
            cb_status_aluno.Items.Clear();
            cb_status_aluno.DataSource = new BindingSource(dic, null);
            cb_status_aluno.DisplayMember = "Value";
            cb_status_aluno.ValueMember = "Key";
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_aluno_Click(object sender, EventArgs e)
        {
            if (tb_nome_aluno.Text != "" && tb_turma_aluno.Text != "" && mtb_tel_aluno.Text != "")
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
                    System.IO.File.Copy(origemCompleto, destinoCompleto, true); //quero substituir a imagem se já existir
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
                
                string vqueryInsertAluno = string.Format(@"
                INSERT INTO tb_alunos
                    (T_NOME_ALUNO, T_TEL_ALUNO, T_STATUS, N_ID_TURMA, T_FOTO)
                 VALUES
                    ('{0}', '{1}', '{2}', {3}, '{4}')", tb_nome_aluno.Text, mtb_tel_aluno.Text, cb_status_aluno.SelectedValue, tb_turma_aluno.Tag.ToString(), destinoCompleto);
                Banco_de_Dados_Acad.dml(vqueryInsertAluno);


                tb_turma_aluno.Clear();
                tb_nome_aluno.Clear();
                mtb_tel_aluno.Clear();
                pictureBox1.ImageLocation = "";
                tb_nome_aluno.Focus();
            }
            

        }

        private void btn_sel_turma_Click(object sender, EventArgs e)
        {
            F_SelecionarTurma_Novo f_SelecionarTurma = new F_SelecionarTurma_Novo(this);
            f_SelecionarTurma.ShowDialog();
        }
        
        private void btn_adc_foto4_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminhoFotos;
            destinoCompleto = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName; //caminho completo do arquivo + nome arq
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
            
            
            System.IO.File.Copy(origemCompleto, destinoCompleto, true); //quero substituir a imagem se já existir
            if (File.Exists(destinoCompleto))
            {
                pictureBox1.ImageLocation = destinoCompleto;
            }
            else
            {
                MessageBox.Show("Arquivo não copiado", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
