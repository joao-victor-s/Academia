namespace Academia
{
    partial class F_GestaoProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestaoProf));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome_prof = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_prof = new System.Windows.Forms.MaskedTextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_salvar_prof = new System.Windows.Forms.Button();
            this.btn_excluir_prof = new System.Windows.Forms.Button();
            this.dgv_prof = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // tb_nome_prof
            // 
            this.tb_nome_prof.Location = new System.Drawing.Point(327, 35);
            this.tb_nome_prof.Name = "tb_nome_prof";
            this.tb_nome_prof.Size = new System.Drawing.Size(197, 20);
            this.tb_nome_prof.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // mtb_prof
            // 
            this.mtb_prof.Location = new System.Drawing.Point(412, 74);
            this.mtb_prof.Mask = "(99) 00000-0000";
            this.mtb_prof.Name = "mtb_prof";
            this.mtb_prof.Size = new System.Drawing.Size(112, 20);
            this.mtb_prof.TabIndex = 7;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(12, 315);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 8;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_salvar_prof
            // 
            this.btn_salvar_prof.Location = new System.Drawing.Point(437, 315);
            this.btn_salvar_prof.Name = "btn_salvar_prof";
            this.btn_salvar_prof.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_prof.TabIndex = 9;
            this.btn_salvar_prof.Text = "Salvar";
            this.btn_salvar_prof.UseVisualStyleBackColor = true;
            this.btn_salvar_prof.Click += new System.EventHandler(this.btn_salvar_prof_Click);
            // 
            // btn_excluir_prof
            // 
            this.btn_excluir_prof.Location = new System.Drawing.Point(356, 315);
            this.btn_excluir_prof.Name = "btn_excluir_prof";
            this.btn_excluir_prof.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_prof.TabIndex = 10;
            this.btn_excluir_prof.Text = "Excluir";
            this.btn_excluir_prof.UseVisualStyleBackColor = true;
            this.btn_excluir_prof.Click += new System.EventHandler(this.btn_excluir_prof_Click);
            // 
            // dgv_prof
            // 
            this.dgv_prof.AllowUserToAddRows = false;
            this.dgv_prof.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_prof.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_prof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prof.EnableHeadersVisualStyles = false;
            this.dgv_prof.Location = new System.Drawing.Point(12, 16);
            this.dgv_prof.MultiSelect = false;
            this.dgv_prof.Name = "dgv_prof";
            this.dgv_prof.ReadOnly = true;
            this.dgv_prof.RowHeadersVisible = false;
            this.dgv_prof.RowTemplate.ReadOnly = true;
            this.dgv_prof.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_prof.Size = new System.Drawing.Size(309, 253);
            this.dgv_prof.TabIndex = 11;
            this.dgv_prof.SelectionChanged += new System.EventHandler(this.dgv_prof_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(354, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(327, 74);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(79, 21);
            this.cb_status.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(339, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "             Adicione uma foto \r\ndando dois clicks no espaço acima";
            // 
            // F_GestaoProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_prof);
            this.Controls.Add(this.btn_excluir_prof);
            this.Controls.Add(this.btn_salvar_prof);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.mtb_prof);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nome_prof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Professores";
            this.Load += new System.EventHandler(this.F_GestaoProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome_prof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_prof;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_salvar_prof;
        private System.Windows.Forms.Button btn_excluir_prof;
        private System.Windows.Forms.DataGridView dgv_prof;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
    }
}