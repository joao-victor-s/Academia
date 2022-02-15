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
    public partial class F_SelecionarTurma_Novo : Form
    {
        F_NovoAluno f_novoAluno; 
        public F_SelecionarTurma_Novo(F_NovoAluno f_Novo)
        {
            InitializeComponent();
            f_novoAluno = f_Novo;
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string vquerySelectTurma = string.Format(@"
            SELECT 
                tbt.N_ID_TURMA as 'ID',
                tbt.T_DSC_TURMA as 'Turma',
                tbp.T_NOME_PROF as 'Professor',
                tbh.T_DSC_HORARIO as 'Horários',
                tbt.N_MAX_ALUNOS as 'Max. de Alunos',
                ( SELECT 
                        count(N_ID_ALUNO)
                  FROM
                        tb_alunos as tba
                  WHERE
                        tba.N_ID_TURMA = tbt.N_ID_TURMA and T_STATUS = 'Ativo'
                ) as 'Qnt. de Alunos'
            FROM
                tb_turmas as tbt
            INNER JOIN
                tb_professores as tbp on tbp.N_ID_PROF = tbt.N_ID_PROF,
                tb_horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO
            ORDER BY
                T_DSC_HORARIO
            ");
            dgv_turmas.DataSource = Banco_de_Dados_Acad.dql(vquerySelectTurma);
            dgv_turmas.Columns[0].Width = 30;
            dgv_turmas.Columns[2].Width = 132;
            dgv_turmas.Columns[3].Width = 60;
            dgv_turmas.Columns[4].Width = 60;
            dgv_turmas.Columns[5].Width = 60;

        }

        private void dgv_turmas_DoubleClick(object sender, EventArgs e)
        { 
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qntAlunos = 0;
            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qntAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());

            if(qntAlunos >= maxAlunos)
            {
                MessageBox.Show("Não há vagas nessa turma.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                
                f_novoAluno.tb_turma_aluno.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
               
                f_novoAluno.tb_turma_aluno.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                
                Close();
            }
            
        }
    }
}
