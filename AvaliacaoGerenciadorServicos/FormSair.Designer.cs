namespace AvaliacaoGerenciadorServicos
{
    partial class FormSair
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_naosair = new System.Windows.Forms.Button();
            this.lbl_sair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(77, 112);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(98, 31);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.Text = "Sim";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_naosair
            // 
            this.btn_naosair.Location = new System.Drawing.Point(208, 112);
            this.btn_naosair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_naosair.Name = "btn_naosair";
            this.btn_naosair.Size = new System.Drawing.Size(95, 31);
            this.btn_naosair.TabIndex = 1;
            this.btn_naosair.Text = "Não";
            this.btn_naosair.UseVisualStyleBackColor = true;
            this.btn_naosair.Click += new System.EventHandler(this.btn_naosair_Click);
            // 
            // lbl_sair
            // 
            this.lbl_sair.AutoSize = true;
            this.lbl_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sair.Location = new System.Drawing.Point(91, 49);
            this.lbl_sair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sair.Name = "lbl_sair";
            this.lbl_sair.Size = new System.Drawing.Size(189, 25);
            this.lbl_sair.TabIndex = 3;
            this.lbl_sair.Text = "Deseja mesmo sair?";
            // 
            // FormSair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 197);
            this.Controls.Add(this.lbl_sair);
            this.Controls.Add(this.btn_naosair);
            this.Controls.Add(this.btn_sair);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_naosair;
        private System.Windows.Forms.Label lbl_sair;
    }
}