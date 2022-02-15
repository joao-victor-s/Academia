using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Academia
{
    public partial class F_Turmas : Form
    {
        string idSelecionado; 
        int modo = 0; //modo  = 1 - edição, modo = 2 - inserção
        string vqueryDGV;
        public F_Turmas()
        {
            InitializeComponent();
        }

        private void F_Turmas_Load(object sender, EventArgs e)
        {
            
            vqueryDGV = @"
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
           
            dgv_turmas.DataSource = Banco_de_Dados_Acad.dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 30; 
            dgv_turmas.Columns[1].Width = 110; 
            dgv_turmas.Columns[2].Width = 100;
            dgv_turmas.Columns[3].Width = 65;

            //Popular ComboBox status
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Ativa", "Ativa");
            dic.Add("Paralisada", "Paralisada");
            dic.Add("Cancelada", "Cancelada");
            cb_status_turma.Items.Clear();
            cb_status_turma.DataSource = new BindingSource(dic, null);
            cb_status_turma.DisplayMember = "Value";
            cb_status_turma.ValueMember = "Key";


            //Popular ComboBox professores
            string vqueryProf = @"
            SELECT
                N_ID_PROF,
                T_NOME_PROF 
            FROM
                tb_professores
            ORDER BY
                T_NOME_PROF
            ";
            cb_nome_prof.Items.Clear();
            cb_nome_prof.DataSource = Banco_de_Dados_Acad.dql(vqueryProf); 
            cb_nome_prof.DisplayMember = "T_NOME_PROF"; 
            cb_nome_prof.ValueMember = "N_ID_PROF";

            //Popular ComboBox Horarios
            string vqueryHorarios = @"
            SELECT 
                *
            FROM
                tb_horarios
            ORDER BY
                N_ID_HORARIO
            ";
            cb_hor_turma.DataSource = Banco_de_Dados_Acad.dql(vqueryHorarios);
            cb_hor_turma.DisplayMember = "T_DSC_HORARIO";
            cb_hor_turma.ValueMember = "N_ID_HORARIO";
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                modo = 0;
               
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCamposSelected = @"
                SELECT
                    T_DSC_TURMA,
                    N_ID_HORARIO,
                    N_MAX_ALUNOS,
                    T_STATUS,
                    N_ID_PROF
                FROM
                    tb_turmas
                WHERE
                    N_ID_TURMA =" + idSelecionado;
                DataTable dt = Banco_de_Dados_Acad.dql(vqueryCamposSelected);
                cb_nome_prof.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_PROF").ToString(); 
                n_max_alunos.Value = dt.Rows[0].Field<Int64>("N_MAX_ALUNOS");
                tb_nome_turma.Text = dt.Rows[0].Field<string>("T_DSC_TURMA");
                cb_hor_turma.SelectedValue = dt.Rows[0].Field<Int64>("N_ID_HORARIO");
                cb_status_turma.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");

                tb_vagas.Text = CalcVagas();
            
            }
        }

        private string CalcVagas()
        {
           
            string vqueryVagas = string.Format(@"
                SELECT
                    count(N_ID_ALUNO) as 'ContagemVagas'
                FROM
                    tb_alunos
                WHERE
                    T_STATUS= 'Ativo' and N_ID_TURMA={0}", idSelecionado);

            DataTable dt = Banco_de_Dados_Acad.dql(vqueryVagas);
            int qntVagas = Int32.Parse(Math.Round(n_max_alunos.Value, 0).ToString());
            qntVagas -= Int32.Parse(dt.Rows[0].Field<Int64>("ContagemVagas").ToString());
            tb_vagas.Text = qntVagas.ToString();
            return qntVagas.ToString();

        }
        private void btn_novo_turma_Click(object sender, EventArgs e)
        {
            tb_nome_turma.Clear();
            cb_nome_prof.SelectedIndex = -1; 
            n_max_alunos.Value = 0;
            cb_status_turma.SelectedIndex = -1;
            cb_hor_turma.SelectedIndex = -1;
            tb_vagas.Clear();
            tb_nome_turma.Focus();
            modo = 2;
        }

        private void btn_salvar_turma_Click(object sender, EventArgs e)
        {
            if(modo != 0)
            {
                string msg = "";
                string vqueryTurma="";
                if (modo == 1)
                {
                    vqueryTurma = String.Format(@"
                    UPDATE
                        tb_turmas
                    SET
                        T_DSC_TURMA='{0}',
                        N_ID_PROF={1},
                        N_ID_HORARIO={2},
                        N_MAX_ALUNOS={3},
                        T_STATUS='{4}'
                    WHERE
                        N_ID_TURMA={5}", tb_nome_turma.Text, cb_nome_prof.SelectedValue, cb_hor_turma.SelectedValue, Int32.Parse(Math.Round(n_max_alunos.Value, 0).ToString()), cb_status_turma.SelectedValue, idSelecionado);
                    msg = "Turma Alterada.";
                } 
                else
                {
                    vqueryTurma = String.Format(@"
                    INSERT INTO
                        tb_turmas
                    (T_DSC_TURMA, N_ID_PROF, N_ID_HORARIO, N_MAX_ALUNOS, T_STATUS)
                    VALUES ('{0}', {1}, {2}, {3}, '{4}')", tb_nome_turma.Text, cb_nome_prof.SelectedValue, cb_hor_turma.SelectedValue, Int32.Parse(Math.Round(n_max_alunos.Value, 0).ToString()), cb_status_turma.SelectedValue);
                    msg = "Nova turma criada.";
                }
                
                int linhaSelecionada = dgv_turmas.SelectedRows[0].Index; 

                Banco_de_Dados_Acad.dml(vqueryTurma);


                dgv_turmas[1, linhaSelecionada].Value = cb_nome_prof.Text;
                dgv_turmas[2, linhaSelecionada].Value = tb_nome_turma.Text;
                dgv_turmas[3, linhaSelecionada].Value = cb_hor_turma.Text;
                tb_vagas.Text = CalcVagas();
               
               

            }
        }

        private void btn_excluir_turma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string vqueryExcluir = "DELETE FROM tb_turmas WHERE N_ID_TURMA=" + idSelecionado;
                Banco_de_Dados_Acad.dml(vqueryExcluir);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void tb_nome_turma_TextChanged(object sender, EventArgs e)
        {
            if(modo == 0)
            {
                modo = 1;

            }
        }

        private void n_max_alunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;

            }
        }

       
        private void cb_hor_turma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;

            }
        }

        private void cb_status_turma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;

            }
        }

        private void cb_nome_prof_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;

            }
        }

        private void btn_imprimir_turma_Click(object sender, EventArgs e)
        { 
          
            string caminhoArqv = Globais.caminhoDir + @"\Relatórios\turmas.pdf"; 
            FileStream arquivoPDF = new FileStream(caminhoArqv, FileMode.Create); 
            Document doc = new Document(PageSize.A4); 
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            doc.Open();
            string dados = "";


            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminhoDir + @"\Icones\logo_strong_arm.png");
            logo.ScaleToFit(120f, 60f);
            logo.Alignment = Element.ALIGN_CENTER;
          


            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Academia\n");


            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("Relatório de Turmas\n\n");


            //Tabela em um PDF
            PdfPTable tabela = new PdfPTable(4); 
            tabela.DefaultCell.FixedHeight = 20;

            tabela.AddCell("ID Turma");
            tabela.AddCell("Professor");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");
           

            DataTable dtTurmas = Banco_de_Dados_Acad.dql(vqueryDGV);
            for (int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Professor"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horário"));
            }


            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(paragrafo2);
            doc.Add(tabela);
            doc.Close();

            DialogResult resp = MessageBox.Show("Deseja abrir o relatório criado?", "Relatório:", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminhoDir + @"\Relatórios\turmas.pdf");
            }
        }
    }
}
