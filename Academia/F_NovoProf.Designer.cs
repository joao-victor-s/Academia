namespace Academia
{
    partial class F_NovoProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NovoProf));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_adc_foto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar_aluno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status_prof = new System.Windows.Forms.ComboBox();
            this.mtb_tel_prof = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome_prof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(431, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btn_adc_foto
            // 
            this.btn_adc_foto.Location = new System.Drawing.Point(431, 7);
            this.btn_adc_foto.Name = "btn_adc_foto";
            this.btn_adc_foto.Size = new System.Drawing.Size(115, 23);
            this.btn_adc_foto.TabIndex = 28;
            this.btn_adc_foto.Text = "Adicionar Foto";
            this.btn_adc_foto.UseVisualStyleBackColor = true;
            this.btn_adc_foto.Click += new System.EventHandler(this.btn_adc_foto_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_salvar_aluno);
            this.panel1.Location = new System.Drawing.Point(3, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 26);
            this.panel1.TabIndex = 27;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(12, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_salvar_aluno
            // 
            this.btn_salvar_aluno.Location = new System.Drawing.Point(332, 3);
            this.btn_salvar_aluno.Name = "btn_salvar_aluno";
            this.btn_salvar_aluno.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_aluno.TabIndex = 0;
            this.btn_salvar_aluno.Text = "Salvar";
            this.btn_salvar_aluno.UseVisualStyleBackColor = true;
            this.btn_salvar_aluno.Click += new System.EventHandler(this.btn_salvar_aluno_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Status:";
            // 
            // cb_status_prof
            // 
            this.cb_status_prof.FormattingEnabled = true;
            this.cb_status_prof.Location = new System.Drawing.Point(12, 71);
            this.cb_status_prof.Name = "cb_status_prof";
            this.cb_status_prof.Size = new System.Drawing.Size(121, 21);
            this.cb_status_prof.TabIndex = 19;
            // 
            // mtb_tel_prof
            // 
            this.mtb_tel_prof.Location = new System.Drawing.Point(281, 28);
            this.mtb_tel_prof.Mask = "(99) 00000-0000";
            this.mtb_tel_prof.Name = "mtb_tel_prof";
            this.mtb_tel_prof.Size = new System.Drawing.Size(111, 20);
            this.mtb_tel_prof.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Telefone:";
            // 
            // tb_nome_prof
            // 
            this.tb_nome_prof.Location = new System.Drawing.Point(12, 28);
            this.tb_nome_prof.Name = "tb_nome_prof";
            this.tb_nome_prof.Size = new System.Drawing.Size(263, 20);
            this.tb_nome_prof.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // F_NovoProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 224);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_adc_foto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_status_prof);
            this.Controls.Add(this.mtb_tel_prof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome_prof);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Professor";
            this.Load += new System.EventHandler(this.F_NovoProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_adc_foto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar_aluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status_prof;
        private System.Windows.Forms.MaskedTextBox mtb_tel_prof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome_prof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}