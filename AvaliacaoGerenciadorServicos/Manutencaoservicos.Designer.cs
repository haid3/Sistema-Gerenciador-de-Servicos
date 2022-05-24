namespace AvaliacaoGerenciadorServicos
{
    partial class Manutencaoservicos
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
            this.lbl_servicoscontrarados = new System.Windows.Forms.Label();
            this.maskedtextbox_datacontratoservico = new System.Windows.Forms.MaskedTextBox();
            this.lbl_datacontratoservico = new System.Windows.Forms.Label();
            this.lbl_valorservico = new System.Windows.Forms.Label();
            this.txtbox_vendedorservico = new System.Windows.Forms.TextBox();
            this.lbl_vendedorservico = new System.Windows.Forms.Label();
            this.lbl_servico = new System.Windows.Forms.Label();
            this.combobox_servico = new System.Windows.Forms.ComboBox();
            this.maskedtextbox_valorservico = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_clienteservico = new System.Windows.Forms.Label();
            this.txtbox_cupomservico = new System.Windows.Forms.TextBox();
            this.lbl_cupomservico = new System.Windows.Forms.Label();
            this.btn_fecharservico = new System.Windows.Forms.Button();
            this.btn_excluirservico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_servicoscontrarados
            // 
            this.lbl_servicoscontrarados.AutoSize = true;
            this.lbl_servicoscontrarados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servicoscontrarados.Location = new System.Drawing.Point(69, 282);
            this.lbl_servicoscontrarados.Name = "lbl_servicoscontrarados";
            this.lbl_servicoscontrarados.Size = new System.Drawing.Size(284, 29);
            this.lbl_servicoscontrarados.TabIndex = 45;
            this.lbl_servicoscontrarados.Text = "Servicos já contratados:";
            // 
            // maskedtextbox_datacontratoservico
            // 
            this.maskedtextbox_datacontratoservico.Location = new System.Drawing.Point(901, 90);
            this.maskedtextbox_datacontratoservico.Mask = "00/00/0000";
            this.maskedtextbox_datacontratoservico.Name = "maskedtextbox_datacontratoservico";
            this.maskedtextbox_datacontratoservico.Size = new System.Drawing.Size(214, 22);
            this.maskedtextbox_datacontratoservico.TabIndex = 44;
            this.maskedtextbox_datacontratoservico.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_datacontratoservico
            // 
            this.lbl_datacontratoservico.AutoSize = true;
            this.lbl_datacontratoservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datacontratoservico.Location = new System.Drawing.Point(896, 48);
            this.lbl_datacontratoservico.Name = "lbl_datacontratoservico";
            this.lbl_datacontratoservico.Size = new System.Drawing.Size(204, 29);
            this.lbl_datacontratoservico.TabIndex = 39;
            this.lbl_datacontratoservico.Text = "Data de Contrato";
            // 
            // lbl_valorservico
            // 
            this.lbl_valorservico.AutoSize = true;
            this.lbl_valorservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorservico.Location = new System.Drawing.Point(462, 165);
            this.lbl_valorservico.Name = "lbl_valorservico";
            this.lbl_valorservico.Size = new System.Drawing.Size(79, 29);
            this.lbl_valorservico.TabIndex = 35;
            this.lbl_valorservico.Text = "Valor:";
            // 
            // txtbox_vendedorservico
            // 
            this.txtbox_vendedorservico.Location = new System.Drawing.Point(744, 216);
            this.txtbox_vendedorservico.Multiline = true;
            this.txtbox_vendedorservico.Name = "txtbox_vendedorservico";
            this.txtbox_vendedorservico.Size = new System.Drawing.Size(333, 34);
            this.txtbox_vendedorservico.TabIndex = 34;
            // 
            // lbl_vendedorservico
            // 
            this.lbl_vendedorservico.AutoSize = true;
            this.lbl_vendedorservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendedorservico.Location = new System.Drawing.Point(739, 165);
            this.lbl_vendedorservico.Name = "lbl_vendedorservico";
            this.lbl_vendedorservico.Size = new System.Drawing.Size(129, 29);
            this.lbl_vendedorservico.TabIndex = 33;
            this.lbl_vendedorservico.Text = "Vendedor:";
            // 
            // lbl_servico
            // 
            this.lbl_servico.AutoSize = true;
            this.lbl_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servico.Location = new System.Drawing.Point(71, 165);
            this.lbl_servico.Name = "lbl_servico";
            this.lbl_servico.Size = new System.Drawing.Size(105, 29);
            this.lbl_servico.TabIndex = 29;
            this.lbl_servico.Text = "Serviço:";
            // 
            // combobox_servico
            // 
            this.combobox_servico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_servico.DropDownWidth = 150;
            this.combobox_servico.FormattingEnabled = true;
            this.combobox_servico.Items.AddRange(new object[] {
            "TV",
            "TV + Internet ",
            "TV + Internet + Plano celular"});
            this.combobox_servico.Location = new System.Drawing.Point(76, 216);
            this.combobox_servico.Name = "combobox_servico";
            this.combobox_servico.Size = new System.Drawing.Size(294, 24);
            this.combobox_servico.TabIndex = 51;
            // 
            // maskedtextbox_valorservico
            // 
            this.maskedtextbox_valorservico.Location = new System.Drawing.Point(467, 218);
            this.maskedtextbox_valorservico.Mask = "00,00";
            this.maskedtextbox_valorservico.Name = "maskedtextbox_valorservico";
            this.maskedtextbox_valorservico.Size = new System.Drawing.Size(109, 22);
            this.maskedtextbox_valorservico.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 34);
            this.textBox1.TabIndex = 54;
            // 
            // lbl_clienteservico
            // 
            this.lbl_clienteservico.AutoSize = true;
            this.lbl_clienteservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clienteservico.Location = new System.Drawing.Point(69, 38);
            this.lbl_clienteservico.Name = "lbl_clienteservico";
            this.lbl_clienteservico.Size = new System.Drawing.Size(239, 29);
            this.lbl_clienteservico.TabIndex = 53;
            this.lbl_clienteservico.Text = "Selecione o Cliente:";
            // 
            // txtbox_cupomservico
            // 
            this.txtbox_cupomservico.Location = new System.Drawing.Point(465, 78);
            this.txtbox_cupomservico.Multiline = true;
            this.txtbox_cupomservico.Name = "txtbox_cupomservico";
            this.txtbox_cupomservico.Size = new System.Drawing.Size(333, 34);
            this.txtbox_cupomservico.TabIndex = 56;
            // 
            // lbl_cupomservico
            // 
            this.lbl_cupomservico.AutoSize = true;
            this.lbl_cupomservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cupomservico.Location = new System.Drawing.Point(460, 38);
            this.lbl_cupomservico.Name = "lbl_cupomservico";
            this.lbl_cupomservico.Size = new System.Drawing.Size(251, 29);
            this.lbl_cupomservico.TabIndex = 55;
            this.lbl_cupomservico.Text = "Cupom de Desconto:";
            // 
            // btn_fecharservico
            // 
            this.btn_fecharservico.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_fecharservico.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_fecharservico.Location = new System.Drawing.Point(1000, 517);
            this.btn_fecharservico.Name = "btn_fecharservico";
            this.btn_fecharservico.Size = new System.Drawing.Size(176, 48);
            this.btn_fecharservico.TabIndex = 58;
            this.btn_fecharservico.Text = "Fechar";
            this.btn_fecharservico.UseVisualStyleBackColor = false;
            this.btn_fecharservico.Click += new System.EventHandler(this.btn_fecharservico_Click);
            // 
            // btn_excluirservico
            // 
            this.btn_excluirservico.BackColor = System.Drawing.Color.Red;
            this.btn_excluirservico.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_excluirservico.Location = new System.Drawing.Point(784, 517);
            this.btn_excluirservico.Name = "btn_excluirservico";
            this.btn_excluirservico.Size = new System.Drawing.Size(176, 48);
            this.btn_excluirservico.TabIndex = 57;
            this.btn_excluirservico.Text = "Excluir";
            this.btn_excluirservico.UseVisualStyleBackColor = false;
            // 
            // Manutencaoservicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 590);
            this.Controls.Add(this.btn_fecharservico);
            this.Controls.Add(this.btn_excluirservico);
            this.Controls.Add(this.txtbox_cupomservico);
            this.Controls.Add(this.lbl_cupomservico);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_clienteservico);
            this.Controls.Add(this.maskedtextbox_valorservico);
            this.Controls.Add(this.combobox_servico);
            this.Controls.Add(this.lbl_servicoscontrarados);
            this.Controls.Add(this.maskedtextbox_datacontratoservico);
            this.Controls.Add(this.lbl_datacontratoservico);
            this.Controls.Add(this.lbl_valorservico);
            this.Controls.Add(this.txtbox_vendedorservico);
            this.Controls.Add(this.lbl_vendedorservico);
            this.Controls.Add(this.lbl_servico);
            this.Name = "Manutencaoservicos";
            this.Text = "Manutencaoservicos";
            this.Load += new System.EventHandler(this.Manutencaoservicos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Manutencaoservicos_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Manutencaoservicos_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_servicoscontrarados;
        private System.Windows.Forms.MaskedTextBox maskedtextbox_datacontratoservico;
        private System.Windows.Forms.Label lbl_datacontratoservico;
        private System.Windows.Forms.Label lbl_valorservico;
        private System.Windows.Forms.TextBox txtbox_vendedorservico;
        private System.Windows.Forms.Label lbl_vendedorservico;
        private System.Windows.Forms.Label lbl_servico;
        private System.Windows.Forms.ComboBox combobox_servico;
        private System.Windows.Forms.MaskedTextBox maskedtextbox_valorservico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_clienteservico;
        private System.Windows.Forms.TextBox txtbox_cupomservico;
        private System.Windows.Forms.Label lbl_cupomservico;
        private System.Windows.Forms.Button btn_fecharservico;
        private System.Windows.Forms.Button btn_excluirservico;
    }
}