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
			this.SuspendLayout();
			// 
			// btnCadastrarBebida
			// 
			this.btnCadastrarBebida.Location = new System.Drawing.Point(392, 87);
			this.btnCadastrarBebida.Name = "btnCadastrarBebida";
			this.btnCadastrarBebida.Size = new System.Drawing.Size(170, 68);
			this.btnCadastrarBebida.TabIndex = 17;
			this.btnCadastrarBebida.Text = "Salvar";
			this.btnCadastrarBebida.UseVisualStyleBackColor = true;
			this.btnCadastrarBebida.Click += new System.EventHandler(this.btnCadastrarBebida_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Preço";
			// 
			// txtDescricaoBebida
			// 
			this.txtDescricaoBebida.Location = new System.Drawing.Point(124, 87);
			this.txtDescricaoBebida.Name = "txtDescricaoBebida";
			this.txtDescricaoBebida.Size = new System.Drawing.Size(152, 20);
			this.txtDescricaoBebida.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Descrição";
			// 
			// maskedTextBoxPrecoBebida
			// 
			this.maskedTextBoxPrecoBebida.Location = new System.Drawing.Point(124, 133);
			this.maskedTextBoxPrecoBebida.Mask = "$ 99,99";
			this.maskedTextBoxPrecoBebida.Name = "maskedTextBoxPrecoBebida";
			this.maskedTextBoxPrecoBebida.Size = new System.Drawing.Size(152, 20);
			this.maskedTextBoxPrecoBebida.TabIndex = 18;
			// 
			// FrmCadastrarBebida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(817, 446);
			this.Controls.Add(this.maskedTextBoxPrecoBebida);
			this.Controls.Add(this.btnCadastrarBebida);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDescricaoBebida);
			this.Controls.Add(this.label1);
			this.Name = "FrmCadastrarBebida";
			this.Text = "FrmCadastrarBebida";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCadastrarBebida;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDescricaoBebida;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecoBebida;
	}
}