namespace Nogueira.View_ADM.Bebida
{
	partial class FrmCadastrarBebida
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
            this.btnCadastrarBebida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoBebida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxPrecoBebida = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizarBebida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarBebida
            // 
            this.btnCadastrarBebida.Location = new System.Drawing.Point(523, 107);
            this.btnCadastrarBebida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarBebida.Name = "btnCadastrarBebida";
            this.btnCadastrarBebida.Size = new System.Drawing.Size(227, 84);
            this.btnCadastrarBebida.TabIndex = 17;
            this.btnCadastrarBebida.Text = "Salvar";
            this.btnCadastrarBebida.UseVisualStyleBackColor = true;
            this.btnCadastrarBebida.Click += new System.EventHandler(this.btnCadastrarBebida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Preço";
            // 
            // txtDescricaoBebida
            // 
            this.txtDescricaoBebida.Location = new System.Drawing.Point(165, 107);
            this.txtDescricaoBebida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricaoBebida.Name = "txtDescricaoBebida";
            this.txtDescricaoBebida.Size = new System.Drawing.Size(201, 22);
            this.txtDescricaoBebida.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descrição";
            // 
            // maskedTextBoxPrecoBebida
            // 
            this.maskedTextBoxPrecoBebida.Location = new System.Drawing.Point(165, 164);
            this.maskedTextBoxPrecoBebida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxPrecoBebida.Mask = "$ 99,99";
            this.maskedTextBoxPrecoBebida.Name = "maskedTextBoxPrecoBebida";
            this.maskedTextBoxPrecoBebida.Size = new System.Drawing.Size(201, 22);
            this.maskedTextBoxPrecoBebida.TabIndex = 18;
            // 
            // btnAtualizarBebida
            // 
            this.btnAtualizarBebida.Location = new System.Drawing.Point(48, 290);
            this.btnAtualizarBebida.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizarBebida.Name = "btnAtualizarBebida";
            this.btnAtualizarBebida.Size = new System.Drawing.Size(227, 84);
            this.btnAtualizarBebida.TabIndex = 19;
            this.btnAtualizarBebida.Text = "Atualizar";
            this.btnAtualizarBebida.UseVisualStyleBackColor = true;
            this.btnAtualizarBebida.Click += new System.EventHandler(this.BtnAtualizarBebida_Click);
            // 
            // FrmCadastrarBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 549);
            this.Controls.Add(this.btnAtualizarBebida);
            this.Controls.Add(this.maskedTextBoxPrecoBebida);
            this.Controls.Add(this.btnCadastrarBebida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricaoBebida);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCadastrarBebida";
            this.Text = "FrmCadastrarBebida";
            this.Load += new System.EventHandler(this.FrmCadastrarBebida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCadastrarBebida;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDescricaoBebida;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecoBebida;
        private System.Windows.Forms.Button btnAtualizarBebida;
    }
}