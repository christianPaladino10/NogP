namespace Nogueira.View_ADM.Motoboy
{
	partial class FrmCadastrarMotoboy
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNomeMotoboy = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtModeloMoto = new System.Windows.Forms.TextBox();
			this.txtPlacaMoto = new System.Windows.Forms.TextBox();
			this.txtCNH = new System.Windows.Forms.TextBox();
			this.btnCadastrarMotoboy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome:";
			// 
			// txtNomeMotoboy
			// 
			this.txtNomeMotoboy.Location = new System.Drawing.Point(141, 81);
			this.txtNomeMotoboy.Name = "txtNomeMotoboy";
			this.txtNomeMotoboy.Size = new System.Drawing.Size(152, 20);
			this.txtNomeMotoboy.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Modelo Moto:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(51, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Placa da Moto:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(51, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "CNH:";
			// 
			// txtModeloMoto
			// 
			this.txtModeloMoto.Location = new System.Drawing.Point(141, 122);
			this.txtModeloMoto.Name = "txtModeloMoto";
			this.txtModeloMoto.Size = new System.Drawing.Size(152, 20);
			this.txtModeloMoto.TabIndex = 5;
			// 
			// txtPlacaMoto
			// 
			this.txtPlacaMoto.Location = new System.Drawing.Point(141, 167);
			this.txtPlacaMoto.Name = "txtPlacaMoto";
			this.txtPlacaMoto.Size = new System.Drawing.Size(152, 20);
			this.txtPlacaMoto.TabIndex = 6;
			// 
			// txtCNH
			// 
			this.txtCNH.Location = new System.Drawing.Point(141, 207);
			this.txtCNH.Name = "txtCNH";
			this.txtCNH.Size = new System.Drawing.Size(152, 20);
			this.txtCNH.TabIndex = 7;
			// 
			// btnCadastrarMotoboy
			// 
			this.btnCadastrarMotoboy.Location = new System.Drawing.Point(429, 112);
			this.btnCadastrarMotoboy.Name = "btnCadastrarMotoboy";
			this.btnCadastrarMotoboy.Size = new System.Drawing.Size(170, 68);
			this.btnCadastrarMotoboy.TabIndex = 8;
			this.btnCadastrarMotoboy.Text = "Salvar";
			this.btnCadastrarMotoboy.UseVisualStyleBackColor = true;
			this.btnCadastrarMotoboy.Click += new System.EventHandler(this.btnCadastrarMotoboy_Click);
			// 
			// fmrCadastrarMotoboy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 455);
			this.Controls.Add(this.btnCadastrarMotoboy);
			this.Controls.Add(this.txtCNH);
			this.Controls.Add(this.txtPlacaMoto);
			this.Controls.Add(this.txtModeloMoto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNomeMotoboy);
			this.Controls.Add(this.label1);
			this.Name = "fmrCadastrarMotoboy";
			this.Text = "fmrCadastrarMotoboy";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNomeMotoboy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtModeloMoto;
		private System.Windows.Forms.TextBox txtPlacaMoto;
		private System.Windows.Forms.TextBox txtCNH;
		private System.Windows.Forms.Button btnCadastrarMotoboy;
	}
}