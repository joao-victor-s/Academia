namespace Academia
{
    partial class F_Horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Horarios));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id_horario = new System.Windows.Forms.TextBox();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_horario = new System.Windows.Forms.MaskedTextBox();
            this.btn_novo_horario = new System.Windows.Forms.Button();
            this.btn_excluir_horario = new System.Windows.Forms.Button();
            this.btn_salvar_horario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tb_id_horario
            // 
            this.tb_id_horario.Location = new System.Drawing.Point(13, 30);
            this.tb_id_horario.Name = "tb_id_horario";
            this.tb_id_horario.ReadOnly = true;
            this.tb_id_horario.Size = new System.Drawing.Size(100, 20);
            this.tb_id_horario.TabIndex = 1;
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(13, 56);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.RowTemplate.ReadOnly = true;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(266, 183);
            this.dgv_horarios.TabIndex = 2;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horário:";
            // 
            // mtb_horario
            // 
            this.mtb_horario.Location = new System.Drawing.Point(179, 30);
            this.mtb_horario.Mask = "99\\h - 99\\h";
            this.mtb_horario.Name = "mtb_horario";
            this.mtb_horario.Size = new System.Drawing.Size(100, 20);
            this.mtb_horario.TabIndex = 4;
            // 
            // btn_novo_horario
            // 
            this.btn_novo_horario.Location = new System.Drawing.Point(12, 245);
            this.btn_novo_horario.Name = "btn_novo_horario";
            this.btn_novo_horario.Size = new System.Drawing.Size(75, 23);
            this.btn_novo_horario.TabIndex = 5;
            this.btn_novo_horario.Text = "Novo";
            this.btn_novo_horario.UseVisualStyleBackColor = true;
            this.btn_novo_horario.Click += new System.EventHandler(this.btn_novo_horario_Click);
            // 
            // btn_excluir_horario
            // 
            this.btn_excluir_horario.Location = new System.Drawing.Point(123, 245);
            this.btn_excluir_horario.Name = "btn_excluir_horario";
            this.btn_excluir_horario.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_horario.TabIndex = 6;
            this.btn_excluir_horario.Text = "Excluir";
            this.btn_excluir_horario.UseVisualStyleBackColor = true;
            this.btn_excluir_horario.Click += new System.EventHandler(this.btn_excluir_horario_Click);
            // 
            // btn_salvar_horario
            // 
            this.btn_salvar_horario.Location = new System.Drawing.Point(204, 245);
            this.btn_salvar_horario.Name = "btn_salvar_horario";
            this.btn_salvar_horario.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_horario.TabIndex = 7;
            this.btn_salvar_horario.Text = "Salvar";
            this.btn_salvar_horario.UseVisualStyleBackColor = true;
            this.btn_salvar_horario.Click += new System.EventHandler(this.btn_salvar_horario_Click);
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 278);
            this.Controls.Add(this.btn_salvar_horario);
            this.Controls.Add(this.btn_excluir_horario);
            this.Controls.Add(this.btn_novo_horario);
            this.Controls.Add(this.mtb_horario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.tb_id_horario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id_horario;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_horario;
        private System.Windows.Forms.Button btn_novo_horario;
        private System.Windows.Forms.Button btn_excluir_horario;
        private System.Windows.Forms.Button btn_salvar_horario;
    }
}