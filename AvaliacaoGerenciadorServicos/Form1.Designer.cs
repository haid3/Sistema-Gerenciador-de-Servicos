namespace AvaliacaoGerenciadorServicos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txtbox_usuario = new System.Windows.Forms.TextBox();
            this.txtbox_senha = new System.Windows.Forms.TextBox();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_encerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERENCIAMENTO DE SERVIÇOS";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(269, 232);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(108, 25);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "USUÁRIO:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(269, 282);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(87, 25);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "SENHA:";
            // 
            // txtbox_usuario
            // 
            this.txtbox_usuario.Location = new System.Drawing.Point(382, 229);
            this.txtbox_usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_usuario.Multiline = true;
            this.txtbox_usuario.Name = "txtbox_usuario";
            this.txtbox_usuario.Size = new System.Drawing.Size(194, 28);
            this.txtbox_usuario.TabIndex = 4;
            this.txtbox_usuario.TextChanged += new System.EventHandler(this.txtbox_usuario_TextChanged_1);
            // 
            // txtbox_senha
            // 
            this.txtbox_senha.Location = new System.Drawing.Point(382, 279);
            this.txtbox_senha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_senha.Multiline = true;
            this.txtbox_senha.Name = "txtbox_senha";
            this.txtbox_senha.PasswordChar = '*';
            this.txtbox_senha.Size = new System.Drawing.Size(194, 28);
            this.txtbox_senha.TabIndex = 5;
            this.txtbox_senha.TextChanged += new System.EventHandler(this.txtbox_usuario_TextChanged);
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(281, 354);
            this.btn_logar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(120, 34);
            this.btn_logar.TabIndex = 6;
            this.btn_logar.Text = "LOGAR";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_encerrar
            // 
            this.btn_encerrar.Location = new System.Drawing.Point(454, 354);
            this.btn_encerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_encerrar.Name = "btn_encerrar";
            this.btn_encerrar.Size = new System.Drawing.Size(121, 34);
            this.btn_encerrar.TabIndex = 7;
            this.btn_encerrar.Text = "ENCERRAR";
            this.btn_encerrar.UseVisualStyleBackColor = true;
            this.btn_encerrar.Click += new System.EventHandler(this.btn_encerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AvaliacaoGerenciadorServicos.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 93);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_encerrar);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.txtbox_senha);
            this.Controls.Add(this.txtbox_usuario);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txtbox_usuario;
        private System.Windows.Forms.TextBox txtbox_senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_encerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

