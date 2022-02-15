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
    public partial class F_GestaoProf : Form
    {
        string vqueryLoadProf = "";
        string idSelecionado = "";
        string destinoCompleto = "";
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        public F_GestaoProf()
        {
            InitializeComponent();
        }

        private void F_GestaoProf_Load(object sender, EventArgs e)
        {
            vqueryLoadProf = @"
            SELECT
                    N_ID_PROF as 'ID',
                    T_NOME_PROF as 'Nome',
                    T_TEL_PROF as 'Telefone'
            FROM 
                    tb_professores
            ORDER BY 
                    T_NOME_PROF   
            ";
            dgv_prof.DataSource = Banco_de_Dados_Acad.dql(vqueryLoadProf);
            dgv_prof.Columns[0].Width = 40;
            dgv_prof.Columns[1].Width = 155;
            dgv_prof.Columns[2].Width = 113;

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Ativo", "Ativo");
            dic.Add("Paralisado", "Paralisado");
            dic.Add("Cancelado", "Cancelado");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(dic, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
        }

        private void dgv_prof_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                idSelecionado = dataGridView.SelectedRows[0].Cells[0].Value.ToString(); 

                string vquery = @"
                    SELECT
                        *
                    FROM
                        tb_professores
                    WHERE N_ID_PROF=" + idSelecionado;
                dt = Banco_de_Dados_Acad.dql(vquery);

                tb_nome_prof.Text = dt.Rows[0].Field<string>("T_NOME_PROF");
                mtb_prof.Text = dt.Rows[0].Field<string>("T_TEL_PROF");
                pictureBox1.ImageLocation = dt.Rows[0].Field<string>("T_FOTO_PROF");
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUS_PROF");

            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
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

            if (origemCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true); //quero substituir a imagem se já existir
            }

            if (File.Exists(destinoCompleto))
            {
                pictureBox1.ImageLocation = destinoCompleto;
            }
            else
            {
                MessageBox.Show("Arquivo não copiado", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_salvar_prof_Click(object sender, EventArgs e)
        {
            if (tb_nome_prof.Text != "" && cb_status.Text != "" && mtb_prof.Text != "")
            {
                DialogResult pergunta = MessageBox.Show("Confirmar alterações?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pergunta == DialogResult.Yes)
                {
                    if (origemCompleto != "")
                    {

                        string vqueryAtualizarProf = string.Format(@"
                            UPDATE 
                                tb_professores
                            SET
                                T_NOME_PROF = '{0}',
                                T_TEL_PROF = '{1}',
                                T_STATUS_PROF = '{2}',
                                T_FOTO_PROF = '{3}'
                            WHERE
                                N_ID_PROF = {4}", tb_nome_prof.Text, mtb_prof.Text, cb_status.SelectedValue, destinoCompleto, idSelecionado);
                        Banco_de_Dados_Acad.dml(vqueryAtualizarProf);

                        dgv_prof.DataSource = Banco_de_Dados_Acad.dql(vqueryLoadProf);
                    }
                    else
                    {
                        string vqueryAtualizarProf = string.Format(@"
                            UPDATE 
                                tb_professores
                            SET
                                T_NOME_PROF = '{0}',
                                T_TEL_PROF = '{1}',
                                T_STATUS_PROF = '{2}'
                                
                            WHERE
                                N_ID_PROF = {3}", tb_nome_prof.Text, mtb_prof.Text, cb_status.SelectedValue, idSelecionado);
                        Banco_de_Dados_Acad.dml(vqueryAtualizarProf);

                        dgv_prof.DataSource = Banco_de_Dados_Acad.dql(vqueryLoadProf);
                    }
                }

            }
        }
        private void btn_excluir_prof_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string vqueryExcluirProf = "DELETE FROM tb_professores WHERE N_ID_PROF=" + idSelecionado;
                Banco_de_Dados_Acad.dml(vqueryExcluirProf);
                dgv_prof.Rows.Remove(dgv_prof.CurrentRow);
            }
            tb_nome_prof.Clear();
            
            mtb_prof.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        
    }
}
