using System;
using System.Data;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
          
            string vquery = @" 
            SELECT
                N_ID_HORARIO as 'ID Turmas',
                T_DSC_HORARIO as 'Horário'
            FROM 
                tb_horarios
            ORDER BY
                T_DSC_HORARIO
            ";
            dgv_horarios.DataSource = Banco_de_Dados_Acad.dql(vquery);
            dgv_horarios.Columns[0].Width = 95;
            dgv_horarios.Columns[1].Width = 170;
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int contLinha = dataGridView.SelectedRows.Count;
            if (contLinha > 0)
            {
                DataTable dt = new DataTable();
                string vid = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                SELECT
                        *
                FROM
                    tb_horarios
                WHERE
                    N_ID_HORARIO=" + vid;
                dt = Banco_de_Dados_Acad.dql(vquery);
                tb_id_horario.Text = dt.Rows[0].Field<Int64>("N_ID_HORARIO").ToString();
                mtb_horario.Text = dt.Rows[0].Field<string>("T_DSC_HORARIO");
            }
        }

        private void btn_novo_horario_Click(object sender, EventArgs e)
        {
            tb_id_horario.Clear(); 
            mtb_horario.Clear();
            mtb_horario.Focus();
        }

        private void btn_salvar_horario_Click(object sender, EventArgs e)
        {
            string vquery;
           
            if(tb_id_horario.Text == "")
            {
                vquery = "INSERT INTO tb_horarios (T_DSC_HORARIO) VALUES ('" + mtb_horario.Text + "')";
            }
            else
            {
                vquery = "UPDATE tb_horarios SET T_DSC_HORARIO='"+mtb_horario.Text+"' WHERE N_ID_HORARIO="+tb_id_horario.Text;
            }
            Banco_de_Dados_Acad.dml(vquery); 
            vquery = @" 
            SELECT
                N_ID_HORARIO as 'ID Turmas',
                T_DSC_HORARIO as 'Horário'
            FROM 
                tb_horarios
            ORDER BY
                T_DSC_HORARIO
            ";
            dgv_horarios.DataSource = Banco_de_Dados_Acad.dql(vquery);
        }

        private void btn_excluir_horario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horario WHERE N_ID_HORARIO=" + tb_id_horario.Text;
                Banco_de_Dados_Acad.dml(vquery);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
            }
        }
    }
}
