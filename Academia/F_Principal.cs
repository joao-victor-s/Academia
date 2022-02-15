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
    public partial class F_Principal : Form
    {
       
        public F_Principal()
        {
            InitializeComponent();

            F_Login f_login = new F_Login(this);
            f_login.ShowDialog(); 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_usuario.Text = "...";
            pb_ledLogado.Image = Properties.Resources.led_vermelho; 

            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void adicionarOutraContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void AbrirFormulario(int nivel, Form formulario)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    formulario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nível de acesso não permitido.", "Problema de Acesso:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            { 
                MessageBox.Show("É necessário ter um usuário logado.", "Problema de Acesso:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAdm f_NovoAdm= new F_NovoAdm();
            AbrirFormulario(2, f_NovoAdm);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoAdms f_gestao = new F_GestaoAdms();
            AbrirFormulario(2, f_gestao);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno= new F_NovoAluno();
            AbrirFormulario(1, f_NovoAluno);
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            AbrirFormulario(1, f_Horarios);
        }

        private void gestãoDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProf f_GestaoProf = new F_GestaoProf();
            AbrirFormulario(1, f_GestaoProf);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Turmas f_Turmas = new F_Turmas();
            AbrirFormulario(1, f_Turmas);
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoAlunos f_GestaoAlunos = new F_GestaoAlunos();
            AbrirFormulario(1, f_GestaoAlunos);
        }

        private void novoProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoProf f_NovoProf = new F_NovoProf();
            AbrirFormulario(1, f_NovoProf);
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {
            string vqueryDGV = @"
            SELECT 
                N_ID_TURMA as 'ID',
                T_NOME_PROF as 'Professor',
                T_DSC_TURMA as 'Turma',
                T_DSC_HORARIO as 'Horário'
            FROM
                tb_turmas as tbt
            INNER JOIN
                tb_horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO,
                tb_professores as tbp on tbp.N_ID_PROF = tbt.N_ID_PROF
            ORDER BY
                T_DSC_HORARIO
            ";
          
            dgv_infos.DataSource = Banco_de_Dados_Acad.dql(vqueryDGV);
            dgv_infos.Columns[0].Width = 30;
            dgv_infos.Columns[1].Width = 180;
            dgv_infos.Columns[2].Width = 170;
            dgv_infos.Columns[3].Width = 65;
        }

        private void dgv_infos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
