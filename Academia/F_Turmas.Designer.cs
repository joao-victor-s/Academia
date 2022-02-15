namespace Academia
{
    partial class F_Turmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Turmas));
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nome_prof = new System.Windows.Forms.ComboBox();
            this.cb_status_turma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.n_max_alunos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_hor_turma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salvar_turma = new System.Windows.Forms.Button();
            this.btn_excluir_turma = new System.Windows.Forms.Button();
            this.btn_novo_turma = new System.Windows.Forms.Button();
            this.btn_imprimir_turma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nome_turma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_max_alunos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.Location = new System.Drawing.Point(12, 12);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.RowTemplate.ReadOnly = true;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(306, 267);
            this.dgv_turmas.TabIndex = 3;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Professor:";
            // 
            // cb_nome_prof
            // 
            this.cb_nome_prof.FormattingEnabled = true;
            this.cb_nome_prof.Location = new System.Drawing.Point(324, 77);
            this.cb_nome_prof.Name = "cb_nome_prof";
            this.cb_nome_prof.Size = new System.Drawing.Size(219, 21);
            this.cb_nome_prof.TabIndex = 5;
            this.cb_nome_prof.SelectedIndexChanged += new System.EventHandler(this.cb_nome_prof_SelectedIndexChanged);
            // 
            // cb_status_turma
            // 
            this.cb_status_turma.FormattingEnabled = true;
            this.cb_status_turma.Items.AddRange(new object[] {
            "Ativa",
            "Paralisada",
            "Desligada"});
            this.cb_status_turma.Location = new System.Drawing.Point(324, 130);
            this.cb_status_turma.Name = "cb_status_turma";
            this.cb_status_turma.Size = new System.Drawing.Size(110, 21);
            this.cb_status_turma.TabIndex = 7;
            this.cb_status_turma.SelectedIndexChanged += new System.EventHandler(this.cb_status_turma_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status:";
            // 
            // n_max_alunos
            // 
            this.n_max_alunos.Location = new System.Drawing.Point(325, 185);
            this.n_max_alunos.Name = "n_max_alunos";
            this.n_max_alunos.Size = new System.Drawing.Size(82, 20);
            this.n_max_alunos.TabIndex = 8;
            this.n_max_alunos.ValueChanged += new System.EventHandler(this.n_max_alunos_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Máx. de Alunos:";
            // 
            // cb_hor_turma
            // 
            this.cb_hor_turma.FormattingEnabled = true;
            this.cb_hor_turma.Location = new System.Drawing.Point(325, 240);
            this.cb_hor_turma.Name = "cb_hor_turma";
            this.cb_hor_turma.Size = new System.Drawing.Size(155, 21);
            this.cb_hor_turma.TabIndex = 10;
            this.cb_hor_turma.SelectedIndexChanged += new System.EventHandler(this.cb_hor_turma_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horário:";
            // 
            // btn_salvar_turma
            // 
            this.btn_salvar_turma.Location = new System.Drawing.Point(470, 6);
            this.btn_salvar_turma.Name = "btn_salvar_turma";
            this.btn_salvar_turma.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_turma.TabIndex = 0;
            this.btn_salvar_turma.Text = "Salvar";
            this.btn_salvar_turma.UseVisualStyleBackColor = true;
            this.btn_salvar_turma.Click += new System.EventHandler(this.btn_salvar_turma_Click);
            // 
            // btn_excluir_turma
            // 
            this.btn_excluir_turma.Location = new System.Drawing.Point(389, 6);
            this.btn_excluir_turma.Name = "btn_excluir_turma";
            this.btn_excluir_turma.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_turma.TabIndex = 1;
            this.btn_excluir_turma.Text = "Excluir";
            this.btn_excluir_turma.UseVisualStyleBackColor = true;
            this.btn_excluir_turma.Click += new System.EventHandler(this.btn_excluir_turma_Click);
            // 
            // btn_novo_turma
            // 
            this.btn_novo_turma.Location = new System.Drawing.Point(14, 6);
            this.btn_novo_turma.Name = "btn_novo_turma";
            this.btn_novo_turma.Size = new System.Drawing.Size(75, 23);
            this.btn_novo_turma.TabIndex = 2;
            this.btn_novo_turma.Text = "Novo";
            this.btn_novo_turma.UseVisualStyleBackColor = true;
            this.btn_novo_turma.Click += new System.EventHandler(this.btn_novo_turma_Click);
            // 
            // btn_imprimir_turma
            // 
            this.btn_imprimir_turma.Location = new System.Drawing.Point(308, 6);
            this.btn_imprimir_turma.Name = "btn_imprimir_turma";
            this.btn_imprimir_turma.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir_turma.TabIndex = 3;
            this.btn_imprimir_turma.Text = "Imprimir";
            this.btn_imprimir_turma.UseVisualStyleBackColor = true;
            this.btn_imprimir_turma.Click += new System.EventHandler(this.btn_imprimir_turma_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_imprimir_turma);
            this.panel1.Controls.Add(this.btn_novo_turma);
            this.panel1.Controls.Add(this.btn_excluir_turma);
            this.panel1.Controls.Add(this.btn_salvar_turma);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(-2, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 37);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome da Turma:";
            // 
            // tb_nome_turma
            // 
            this.tb_nome_turma.Location = new System.Drawing.Point(325, 26);
            this.tb_nome_turma.Name = "tb_nome_turma";
            this.tb_nome_turma.Size = new System.Drawing.Size(218, 20);
            this.tb_nome_turma.TabIndex = 14;
            this.tb_nome_turma.TextChanged += new System.EventHandler(this.tb_nome_turma_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vagas Disponíveis:";
            // 
            // tb_vagas
            // 
            this.tb_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_vagas.Location = new System.Drawing.Point(443, 185);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.ReadOnly = true;
            this.tb_vagas.Size = new System.Drawing.Size(100, 20);
            this.tb_vagas.TabIndex = 16;
            this.tb_vagas.TabStop = false;
            // 
            // F_Turmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 317);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_nome_turma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_hor_turma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_max_alunos);
            this.Controls.Add(this.cb_status_turma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_nome_prof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_turmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Turmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.F_Turmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_max_alunos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nome_prof;
        private System.Windows.Forms.ComboBox cb_status_turma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown n_max_alunos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_hor_turma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_salvar_turma;
        private System.Windows.Forms.Button btn_excluir_turma;
        private System.Windows.Forms.Button btn_novo_turma;
        private System.Windows.Forms.Button btn_imprimir_turma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nome_turma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vagas;
    }
}