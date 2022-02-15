namespace Academia
{
    partial class F_NovoAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NovoAluno));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome_aluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_tel_aluno = new System.Windows.Forms.MaskedTextBox();
            this.cb_status_aluno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_turma_aluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sel_turma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar_aluno = new System.Windows.Forms.Button();
            this.btn_adc_foto4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tb_nome_aluno
            // 
            this.tb_nome_aluno.Location = new System.Drawing.Point(12, 29);
            this.tb_nome_aluno.Name = "tb_nome_aluno";
            this.tb_nome_aluno.Size = new System.Drawing.Size(263, 20);
            this.tb_nome_aluno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // mtb_tel_aluno
            // 
            this.mtb_tel_aluno.Location = new System.Drawing.Point(281, 29);
            this.mtb_tel_aluno.Mask = "(99) 00000-0000";
            this.mtb_tel_aluno.Name = "mtb_tel_aluno";
            this.mtb_tel_aluno.Size = new System.Drawing.Size(111, 20);
            this.mtb_tel_aluno.TabIndex = 3;
            // 
            // cb_status_aluno
            // 
            this.cb_status_aluno.FormattingEnabled = true;
            this.cb_status_aluno.Location = new System.Drawing.Point(12, 72);
            this.cb_status_aluno.Name = "cb_status_aluno";
            this.cb_status_aluno.Size = new System.Drawing.Size(121, 21);
            this.cb_status_aluno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // tb_turma_aluno
            // 
            this.tb_turma_aluno.Location = new System.Drawing.Point(140, 72);
            this.tb_turma_aluno.Name = "tb_turma_aluno";
            this.tb_turma_aluno.ReadOnly = true;
            this.tb_turma_aluno.Size = new System.Drawing.Size(229, 20);
            this.tb_turma_aluno.TabIndex = 6;
            this.tb_turma_aluno.Tag = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Turma:";
            // 
            // btn_sel_turma
            // 
            this.btn_sel_turma.Location = new System.Drawing.Point(367, 70);
            this.btn_sel_turma.Name = "btn_sel_turma";
            this.btn_sel_turma.Size = new System.Drawing.Size(25, 23);
            this.btn_sel_turma.TabIndex = 8;
            this.btn_sel_turma.Text = "...";
            this.btn_sel_turma.UseVisualStyleBackColor = true;
            this.btn_sel_turma.Click += new System.EventHandler(this.btn_sel_turma_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_salvar_aluno);
            this.panel1.Location = new System.Drawing.Point(3, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 37);
            this.panel1.TabIndex = 12;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(12, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar_aluno
            // 
            this.btn_salvar_aluno.Location = new System.Drawing.Point(322, 3);
            this.btn_salvar_aluno.Name = "btn_salvar_aluno";
            this.btn_salvar_aluno.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_aluno.TabIndex = 0;
            this.btn_salvar_aluno.Text = "Salvar";
            this.btn_salvar_aluno.UseVisualStyleBackColor = true;
            this.btn_salvar_aluno.Click += new System.EventHandler(this.btn_salvar_aluno_Click);
            // 
            // btn_adc_foto4
            // 
            this.btn_adc_foto4.Location = new System.Drawing.Point(431, 8);
            this.btn_adc_foto4.Name = "btn_adc_foto4";
            this.btn_adc_foto4.Size = new System.Drawing.Size(115, 23);
            this.btn_adc_foto4.TabIndex = 13;
            this.btn_adc_foto4.Text = "Adicionar Foto";
            this.btn_adc_foto4.UseVisualStyleBackColor = true;
            this.btn_adc_foto4.Click += new System.EventHandler(this.btn_adc_foto4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(431, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 220);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_adc_foto4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sel_turma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_turma_aluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_status_aluno);
            this.Controls.Add(this.mtb_tel_aluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome_aluno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome_aluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_tel_aluno;
        private System.Windows.Forms.ComboBox cb_status_aluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar_aluno;
        public System.Windows.Forms.TextBox tb_turma_aluno;
        private System.Windows.Forms.Button btn_sel_turma;
        private System.Windows.Forms.Button btn_adc_foto4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}