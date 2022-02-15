namespace Academia
{
    partial class F_GestaoAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestaoAlunos));
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status_aluno = new System.Windows.Forms.ComboBox();
            this.mtb_tel_aluno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome_aluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_imprimir_carteirinha = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir_aluno = new System.Windows.Forms.Button();
            this.btn_salvar_aluno = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            this.cb_turma_aluno = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToAddRows = false;
            this.dgv_alunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.EnableHeadersVisualStyles = false;
            this.dgv_alunos.Location = new System.Drawing.Point(12, 12);
            this.dgv_alunos.MultiSelect = false;
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.ReadOnly = true;
            this.dgv_alunos.RowHeadersVisible = false;
            this.dgv_alunos.RowTemplate.ReadOnly = true;
            this.dgv_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alunos.Size = new System.Drawing.Size(295, 327);
            this.dgv_alunos.TabIndex = 4;
            this.dgv_alunos.SelectionChanged += new System.EventHandler(this.dgv_alunos_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Turma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status:";
            // 
            // cb_status_aluno
            // 
            this.cb_status_aluno.FormattingEnabled = true;
            this.cb_status_aluno.Location = new System.Drawing.Point(445, 74);
            this.cb_status_aluno.Name = "cb_status_aluno";
            this.cb_status_aluno.Size = new System.Drawing.Size(146, 21);
            this.cb_status_aluno.TabIndex = 12;
            // 
            // mtb_tel_aluno
            // 
            this.mtb_tel_aluno.Location = new System.Drawing.Point(328, 75);
            this.mtb_tel_aluno.Mask = "(99) 00000-0000";
            this.mtb_tel_aluno.Name = "mtb_tel_aluno";
            this.mtb_tel_aluno.Size = new System.Drawing.Size(111, 20);
            this.mtb_tel_aluno.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefone:";
            // 
            // tb_nome_aluno
            // 
            this.tb_nome_aluno.Location = new System.Drawing.Point(328, 31);
            this.tb_nome_aluno.Name = "tb_nome_aluno";
            this.tb_nome_aluno.Size = new System.Drawing.Size(263, 20);
            this.tb_nome_aluno.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // btn_imprimir_carteirinha
            // 
            this.btn_imprimir_carteirinha.Location = new System.Drawing.Point(381, 164);
            this.btn_imprimir_carteirinha.Name = "btn_imprimir_carteirinha";
            this.btn_imprimir_carteirinha.Size = new System.Drawing.Size(145, 23);
            this.btn_imprimir_carteirinha.TabIndex = 17;
            this.btn_imprimir_carteirinha.Text = "Imprimir Carteirinha";
            this.btn_imprimir_carteirinha.UseVisualStyleBackColor = true;
            this.btn_imprimir_carteirinha.Click += new System.EventHandler(this.btn_imprimir_carteirinha_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir_aluno);
            this.panel1.Controls.Add(this.btn_salvar_aluno);
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 46);
            this.panel1.TabIndex = 19;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(10, 11);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 2;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir_aluno
            // 
            this.btn_excluir_aluno.Location = new System.Drawing.Point(434, 11);
            this.btn_excluir_aluno.Name = "btn_excluir_aluno";
            this.btn_excluir_aluno.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_aluno.TabIndex = 1;
            this.btn_excluir_aluno.Text = "Excluir";
            this.btn_excluir_aluno.UseVisualStyleBackColor = true;
            this.btn_excluir_aluno.Click += new System.EventHandler(this.btn_excluir_aluno_Click);
            // 
            // btn_salvar_aluno
            // 
            this.btn_salvar_aluno.Location = new System.Drawing.Point(515, 11);
            this.btn_salvar_aluno.Name = "btn_salvar_aluno";
            this.btn_salvar_aluno.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_aluno.TabIndex = 0;
            this.btn_salvar_aluno.Text = "Salvar";
            this.btn_salvar_aluno.UseVisualStyleBackColor = true;
            this.btn_salvar_aluno.Click += new System.EventHandler(this.btn_salvar_aluno_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Vagas na Turma:";
            // 
            // tb_vagas
            // 
            this.tb_vagas.Location = new System.Drawing.Point(493, 127);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.ReadOnly = true;
            this.tb_vagas.Size = new System.Drawing.Size(98, 20);
            this.tb_vagas.TabIndex = 21;
            // 
            // cb_turma_aluno
            // 
            this.cb_turma_aluno.FormattingEnabled = true;
            this.cb_turma_aluno.Location = new System.Drawing.Point(331, 127);
            this.cb_turma_aluno.Name = "cb_turma_aluno";
            this.cb_turma_aluno.Size = new System.Drawing.Size(155, 21);
            this.cb_turma_aluno.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(392, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(367, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "             Adicione uma foto \r\ndando dois clicks no espaço acima";
            // 
            // F_GestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 424);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_turma_aluno);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_imprimir_carteirinha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_status_aluno);
            this.Controls.Add(this.mtb_tel_aluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome_aluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_alunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Alunos";
            this.Load += new System.EventHandler(this.F_GestaoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status_aluno;
        private System.Windows.Forms.MaskedTextBox mtb_tel_aluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome_aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_imprimir_carteirinha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir_aluno;
        private System.Windows.Forms.Button btn_salvar_aluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_vagas;
        private System.Windows.Forms.ComboBox cb_turma_aluno;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
    }
}