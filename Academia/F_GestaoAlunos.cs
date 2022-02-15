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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Academia
{

    public partial class F_GestaoAlunos : Form
    {
        string idSelecionado = "";
        string turmaAtual = "";
        string vqueryDGV = "";
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        string foto_arq = "";

        public F_GestaoAlunos()
        {
            InitializeComponent();
            
        }

        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
            SELECT 
                tba.N_ID_ALUNO as 'ID',
                tba.T_NOME_ALUNO as 'Nome',
                tbt.T_DSC_TURMA as 'Turma',
                tbh.T_DSC_HORARIO as 'Horário'
            FROM 
                tb_alunos as tba
            INNER JOIN
                tb_turmas as tbt on tbt.N_ID_TURMA = tba.N_ID_TURMA,
                tb_horarios as tbh on tbh.N_ID_HORARIO = tbt.N_ID_HORARIO
            ORDER BY
                T_NOME_ALUNO
            ";
            dgv_alunos.DataSource = Banco_de_Dados_Acad.dql(vqueryDGV);
            dgv_alunos.Columns[0].Width = 30;
            dgv_alunos.Columns[2].Width = 90;
            dgv_alunos.Columns[3].Width = 73;


            //Popular ComboBox Status
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Ativo", "Ativo");
            dic.Add("Paralisado", "Paralisado");
            dic.Add("Cancelado", "Cancelado");
            cb_status_aluno.Items.Clear();
            cb_status_aluno.DataSource = new BindingSource(dic, null);
            cb_status_aluno.DisplayMember = "Value";
            cb_status_aluno.ValueMember = "Key";

            //Popular ComboBox Turmas
            string vqueryTurmas = @"
            SELECT
                    N_ID_TURMA,
                    T_DSC_TURMA
            FROM
                tb_turmas
            ";
            cb_turma_aluno.Items.Clear();
            cb_turma_aluno.DataSource = Banco_de_Dados_Acad.dql(vqueryTurmas);
            cb_turma_aluno.DisplayMember= "T_DSC_TURMA";
            cb_turma_aluno.ValueMember= "N_ID_TURMA";

        }

        private void dgv_alunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();

                idSelecionado = dgv_alunos.Rows[0].Cells[0].Value.ToString();
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = string.Format(@"
                SELECT 
                    tba.N_ID_ALUNO,
                    tba.T_NOME_ALUNO,
                    tba.T_STATUS,
                    tba.T_TEL_ALUNO,
                    tba.N_ID_TURMA,
                    tbt.T_DSC_TURMA,
                    tba.T_FOTO,
                    tbt.N_MAX_ALUNOS,
                    (N_MAX_ALUNOS) - (      
                                        SELECT 
                                            count(tba.N_ID_ALUNO)
                                        FROM
                                            tb_alunos as tba
                                        WHERE
                                            tba.T_STATUS = 'Ativo' and tba.N_ID_TURMA = tbt.N_ID_TURMA
                                      ) as 'Vagas'
                FROM
                    tb_alunos as tba
                INNER JOIN 
                    tb_turmas as tbt on tbt.N_ID_TURMA = tba.N_ID_TURMA
                WHERE
                    N_ID_ALUNO = {0}", idSelecionado);

                dt = Banco_de_Dados_Acad.dql(vqueryCampos);

                tb_nome_aluno.Text = dt.Rows[0].Field<string>("T_NOME_ALUNO");
                cb_turma_aluno.Text = dt.Rows[0].Field<string>("T_DSC_TURMA");
                cb_status_aluno.Text = dt.Rows[0].Field<string>("T_STATUS");
                mtb_tel_aluno.Text = dt.Rows[0].Field<string>("T_TEL_ALUNO");
                tb_vagas.Text = dt.Rows[0].Field<Int64>("Vagas").ToString();
                turmaAtual = cb_turma_aluno.Text;
                pictureBox1.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
                foto_arq = pictureBox1.ImageLocation;
            }

        }


        private void btn_excluir_aluno_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show("Confirmar Exclusão?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (pergunta == DialogResult.Yes)
            {
                if (File.Exists(pictureBox1.ImageLocation))
                {
                    File.Delete(pictureBox1.ImageLocation);
                }

                string vqueryExcluirAluno = string.Format(@"
                DELETE FROM
                    tb_alunos
                WHERE 
                    N_ID_ALUNO = {0}
                ", idSelecionado);
                Banco_de_Dados_Acad.dml(vqueryExcluirAluno);
                dgv_alunos.Rows.Remove(dgv_alunos.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btn_salvar_aluno_Click(object sender, EventArgs e)
        {
            string turma = cb_turma_aluno.Text;
            if (tb_nome_aluno.Text != "" && cb_turma_aluno.Text != "" && mtb_tel_aluno.Text != "")
            {
                if (turma != turmaAtual)
                {
                    int Vagas = Int32.Parse(tb_vagas.Text);
                    if (Vagas < 1)
                    {
                        MessageBox.Show("Não há vagas na turma selecionada.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cb_turma_aluno.Focus();
                        return;
                    }
                }
                DialogResult pergunta = MessageBox.Show("Confirmar alterações?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pergunta == DialogResult.Yes)
                {
                    if (origemCompleto != "")
                    {
                        string vqueryAtualizarAluno = string.Format(@"
                        UPDATE 
                            tb_alunos
                        SET
                            T_NOME_ALUNO = '{0}',
                            T_TEL_ALUNO = '{1}',
                            T_STATUS = '{2}',
                            N_ID_TURMA = '{3}',
                            T_FOTO = '{4}'
                        WHERE
                            N_ID_ALUNO = {5}", tb_nome_aluno.Text, mtb_tel_aluno.Text, cb_status_aluno.SelectedValue, cb_turma_aluno.SelectedValue, destinoCompleto, idSelecionado);
                        Banco_de_Dados_Acad.dml(vqueryAtualizarAluno);

                        dgv_alunos.DataSource = Banco_de_Dados_Acad.dql(vqueryDGV);
                    }
                    else
                    {
                        string vqueryAtualizarAluno = string.Format(@"
                        UPDATE 
                            tb_alunos
                        SET
                            T_NOME_ALUNO = '{0}',
                            T_TEL_ALUNO = '{1}',
                            T_STATUS = '{2}',
                            N_ID_TURMA = '{3}'
                           
                        WHERE
                            N_ID_ALUNO = {4}", tb_nome_aluno.Text, mtb_tel_aluno.Text, cb_status_aluno.SelectedValue, cb_turma_aluno.SelectedValue, idSelecionado);
                        Banco_de_Dados_Acad.dml(vqueryAtualizarAluno);

                        dgv_alunos.DataSource = Banco_de_Dados_Acad.dql(vqueryDGV);
                    }
                }

            }

        }

        private void btn_imprimir_carteirinha_Click(object sender, EventArgs e)
        {
            
            string caminhoArqv = Globais.caminhoDir + @"\Carteirinhas\cateirinha_" + tb_nome_aluno.Text + ".pdf"; 
            FileStream arquivoPDF = new FileStream(caminhoArqv, FileMode.Create); 
            Document doc = new Document(PageSize.B8);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            doc.Open();
            string dados = "";


            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminhoDir + @"\Icones\logo_strong_arm.png");
            logo.ScaleToFit(60f, 30f);
            logo.Alignment = Element.ALIGN_CENTER;
            


            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Academia\n\n");
            

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 7, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add(tb_nome_aluno.Text + "\n");

            Paragraph paragrafo3 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 4, (int)System.Drawing.FontStyle.Regular));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("ID Aluno: 000" + idSelecionado);


            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            if (File.Exists(foto_arq))
            {
                iTextSharp.text.Image foto_aluno = iTextSharp.text.Image.GetInstance(foto_arq);
                doc.Add(foto_aluno);
            }
            doc.Add(paragrafo2);
            doc.Close();

            DialogResult resp = MessageBox.Show("Deseja abrir a carteirinha?", "Carteirinha:", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminhoDir + @"\Carteirinhas\cateirinha_" + tb_nome_aluno.Text + ".pdf");
            }
        }
    }
}
