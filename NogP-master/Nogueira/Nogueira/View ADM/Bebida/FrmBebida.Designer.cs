namespace Nogueira.View_ADM.Bebida
{
	partial class FrmBebida
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBebida));
			this.btnCadastrarBebida = new Bunifu.Framework.UI.BunifuFlatButton();
			this.label1 = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCadastrarBebida
			// 
			this.btnCadastrarBebida.Activecolor = System.Drawing.Color.Transparent;
			this.btnCadastrarBebida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnCadastrarBebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCadastrarBebida.BorderRadius = 0;
			this.btnCadastrarBebida.ButtonText = "Cadastrar Bebidas";
			this.btnCadastrarBebida.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCadastrarBebida.DisabledColor = System.Drawing.Color.Gray;
			this.btnCadastrarBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrarBebida.Iconcolor = System.Drawing.Color.Transparent;
			this.btnCadastrarBebida.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarBebida.Iconimage")));
			this.btnCadastrarBebida.Iconimage_right = null;
			this.btnCadastrarBebida.Iconimage_right_Selected = null;
			this.btnCadastrarBebida.Iconimage_Selected = null;
			this.btnCadastrarBebida.IconMarginLeft = 0;
			this.btnCadastrarBebida.IconMarginRight = 0;
			this.btnCadastrarBebida.IconRightVisible = true;
			this.btnCadastrarBebida.IconRightZoom = 0D;
			this.btnCadastrarBebida.IconVisible = true;
			this.btnCadastrarBebida.IconZoom = 90D;
			this.btnCadastrarBebida.IsTab = true;
			this.btnCadastrarBebida.Location = new System.Drawing.Point(71, 173);
			this.btnCadastrarBebida.Margin = new System.Windows.Forms.Padding(5);
			this.btnCadastrarBebida.Name = "btnCadastrarBebida";
			this.btnCadastrarBebida.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnCadastrarBebida.OnHovercolor = System.Drawing.Color.Silver;
			this.btnCadastrarBebida.OnHoverTextColor = System.Drawing.Color.White;
			this.btnCadastrarBebida.selected = false;
			this.btnCadastrarBebida.Size = new System.Drawing.Size(370, 139);
			this.btnCadastrarBebida.TabIndex = 11;
			this.btnCadastrarBebida.Text = "Cadastrar Bebidas";
			this.btnCadastrarBebida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCadastrarBebida.Textcolor = System.Drawing.Color.Silver;
			this.btnCadastrarBebida.TextFont = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrarBebida.Click += new System.EventHandler(this.btnCadastrarBebida_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(128, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "escolha o que deseja fazer neste momento";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(34, 25);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(0, 13);
			this.lblNome.TabIndex = 9;
			// 
			// FrmBebida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(869, 481);
			this.Controls.Add(this.btnCadastrarBebida);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblNome);
			this.Name = "FrmBebida";
			this.Text = "FrmBebida";
			this.Load += new System.EventHandler(this.FrmBebida_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuFlatButton btnCadastrarBebida;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblNome;
	}
}