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
    public partial class F_GestaoAdms : Form
    {
        string idSelecionado = "";
        string vqueryDGV = "";
        public F_GestaoAdms()
        {
            InitializeComponent();
        }

        private void F_GestaoAdms_Load(object sender, EventArgs e)
        {
            vqueryDGV = string.Format(@"
            SELECT 
                N_IDUSUARIO as 'ID',
                T_NOMEUSUARIO as 'Nome',
                T_USERNAME as 'Username'
            FROM 
                tb_usuarios
            ORDER BY
                T_NOMEUSUARIO
            ");
            dataGridView1.DataSource = Banco_de_Dados_Acad.dql(vqueryDGV);
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 100;

            //Popular ComboBox Status
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Ativo", "Ativo");
            dic.Add("Cancelado", "Cancelado");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(dic, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender; 
            

            int contlinhas = dgv.SelectedRows.Count;

            if(contlinhas > 0)
            {
                DataTable dt = new DataTable();

                idSelecionado = dataGridView1.Rows[0].Cells[0].Value.ToString();
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();

                string vqueryCampos = string.Format(@"
                SELECT 
                    *
                FROM
                    tb_usuarios
                WHERE 
                    N_IDUSUARIO = {0} ", idSelecionado);

                dt = Banco_de_Dados_Acad.dql(vqueryCampos);

                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO").ToString();
                numericUpDown1.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO"); 

            }
        }
        private void btn_adc_Click(object sender, EventArgs e)
        {
            F_NovoAdm f_novoAdm = new F_NovoAdm();
            f_novoAdm.ShowDialog();
            dataGridView1.DataSource = Banco_de_Dados_Acad.dql(vqueryDGV); 
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show("Confirmar alterações?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                string vqueryAtualizarAdm= string.Format(@"
                    UPDATE 
                        tb_usuarios
                    SET
                        T_NOMEUSUARIO = '{0}',
                        T_USERNAME = '{1}',
                        T_SENHAUSUARIO = '{2}',
                        T_STATUSUSUARIO = '{3}',
                        N_NIVELUSUARIO = {4}
                    WHERE
                        N_IDUSUARIO = {5}", tb_nome.Text, tb_username.Text, tb_senha.Text, cb_status.SelectedValue, numericUpDown1.Value, idSelecionado);
                Banco_de_Dados_Acad.dml(vqueryAtualizarAdm);

                dataGridView1.DataSource = Banco_de_Dados_Acad.dql(vqueryDGV);
            }
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show("Confirmar Exclusão?", "Atenção:",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (pergunta == DialogResult.Yes)
            {
                

                string idSelecionado = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();

                string vqueryExcluirAdm= @"
                DELETE FROM
                    tb_usuarios
                WHERE 
                    N_IDUSUARIO =
                " + idSelecionado;
                Banco_de_Dados_Acad.dml(vqueryExcluirAdm);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }
    }
}
