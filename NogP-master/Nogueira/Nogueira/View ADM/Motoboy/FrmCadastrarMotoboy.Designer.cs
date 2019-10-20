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
            this.btnAtualizarMotoboy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNomeMotoboy
            // 
            this.txtNomeMotoboy.Location = new System.Drawing.Point(188, 100);
            this.txtNomeMotoboy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeMotoboy.Name = "txtNomeMotoboy";
            this.txtNomeMotoboy.Size = new System.Drawing.Size(201, 22);
            this.txtNomeMotoboy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo Moto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Placa da Moto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "CNH:";
            // 
            // txtModeloMoto
            // 
            this.txtModeloMoto.Location = new System.Drawing.Point(188, 150);
            this.txtModeloMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModeloMoto.Name = "txtModeloMoto";
            this.txtModeloMoto.Size = new System.Drawing.Size(201, 22);
            this.txtModeloMoto.TabIndex = 5;
            // 
            // txtPlacaMoto
            // 
            this.txtPlacaMoto.Location = new System.Drawing.Point(188, 206);
            this.txtPlacaMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlacaMoto.Name = "txtPlacaMoto";
            this.txtPlacaMoto.Size = new System.Drawing.Size(201, 22);
            this.txtPlacaMoto.TabIndex = 6;
            // 
            // txtCNH
            // 
            this.txtCNH.Location = new System.Drawing.Point(188, 255);
            this.txtCNH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Size = new System.Drawing.Size(201, 22);
            this.txtCNH.TabIndex = 7;
            // 
            // btnCadastrarMotoboy
            // 
            this.btnCadastrarMotoboy.Location = new System.Drawing.Point(579, 108);
            this.btnCadastrarMotoboy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarMotoboy.Name = "btnCadastrarMotoboy";
            this.btnCadastrarMotoboy.Size = new System.Drawing.Size(227, 84);
            this.btnCadastrarMotoboy.TabIndex = 8;
            this.btnCadastrarMotoboy.Text = "Salvar";
            this.btnCadastrarMotoboy.UseVisualStyleBackColor = true;
            this.btnCadastrarMotoboy.Click += new System.EventHandler(this.btnCadastrarMotoboy_Click);
            // 
            // btnAtualizarMotoboy
            // 
            this.btnAtualizarMotoboy.Location = new System.Drawing.Point(71, 377);
            this.btnAtualizarMotoboy.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizarMotoboy.Name = "btnAtualizarMotoboy";
            this.btnAtualizarMotoboy.Size = new System.Drawing.Size(227, 84);
            this.btnAtualizarMotoboy.TabIndex = 9;
            this.btnAtualizarMotoboy.Text = "Atualizar";
            this.btnAtualizarMotoboy.UseVisualStyleBackColor = true;
            this.btnAtualizarMotoboy.Click += new System.EventHandler(this.BtnAtualizarMotoboy_Click);
            // 
            // FrmCadastrarMotoboy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 560);
            this.Controls.Add(this.btnAtualizarMotoboy);
            this.Controls.Add(this.btnCadastrarMotoboy);
            this.Controls.Add(this.txtCNH);
            this.Controls.Add(this.txtPlacaMoto);
            this.Controls.Add(this.txtModeloMoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeMotoboy);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCadastrarMotoboy";
            this.Text = "fmrCadastrarMotoboy";
            this.Load += new System.EventHandler(this.FrmCadastrarMotoboy_Load);
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
        private System.Windows.Forms.Button btnAtualizarMotoboy;
    }
}