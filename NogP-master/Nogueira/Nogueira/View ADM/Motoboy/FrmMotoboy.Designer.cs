namespace Nogueira.View_ADM.Motoboy
{
	partial class FrmMotoboy
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMotoboy));
			this.btnCadastrarMotoboy = new Bunifu.Framework.UI.BunifuFlatButton();
			this.label1 = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCadastrarMotoboy
			// 
			this.btnCadastrarMotoboy.Activecolor = System.Drawing.Color.Transparent;
			this.btnCadastrarMotoboy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnCadastrarMotoboy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCadastrarMotoboy.BorderRadius = 0;
			this.btnCadastrarMotoboy.ButtonText = "Cadastrar Motoboy";
			this.btnCadastrarMotoboy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCadastrarMotoboy.DisabledColor = System.Drawing.Color.Gray;
			this.btnCadastrarMotoboy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrarMotoboy.Iconcolor = System.Drawing.Color.Transparent;
			this.btnCadastrarMotoboy.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarMotoboy.Iconimage")));
			this.btnCadastrarMotoboy.Iconimage_right = null;
			this.btnCadastrarMotoboy.Iconimage_right_Selected = null;
			this.btnCadastrarMotoboy.Iconimage_Selected = null;
			this.btnCadastrarMotoboy.IconMarginLeft = 0;
			this.btnCadastrarMotoboy.IconMarginRight = 0;
			this.btnCadastrarMotoboy.IconRightVisible = true;
			this.btnCadastrarMotoboy.IconRightZoom = 0D;
			this.btnCadastrarMotoboy.IconVisible = true;
			this.btnCadastrarMotoboy.IconZoom = 90D;
			this.btnCadastrarMotoboy.IsTab = true;
			this.btnCadastrarMotoboy.Location = new System.Drawing.Point(87, 178);
			this.btnCadastrarMotoboy.Margin = new System.Windows.Forms.Padding(5);
			this.btnCadastrarMotoboy.Name = "btnCadastrarMotoboy";
			this.btnCadastrarMotoboy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnCadastrarMotoboy.OnHovercolor = System.Drawing.Color.Silver;
			this.btnCadastrarMotoboy.OnHoverTextColor = System.Drawing.Color.White;
			this.btnCadastrarMotoboy.selected = false;
			this.btnCadastrarMotoboy.Size = new System.Drawing.Size(370, 139);
			this.btnCadastrarMotoboy.TabIndex = 8;
			this.btnCadastrarMotoboy.Text = "Cadastrar Motoboy";
			this.btnCadastrarMotoboy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCadastrarMotoboy.Textcolor = System.Drawing.Color.Silver;
			this.btnCadastrarMotoboy.TextFont = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrarMotoboy.Click += new System.EventHandler(this.btnCadastrarMotoboy_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(144, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "escolha o que deseja fazer neste momento";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(50, 30);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(0, 13);
			this.lblNome.TabIndex = 6;
			// 
			// FrmMotoboy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 485);
			this.Controls.Add(this.btnCadastrarMotoboy);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblNome);
			this.Name = "FrmMotoboy";
			this.Text = "FrmMotoboy";
			this.Load += new System.EventHandler(this.FrmMotoboy_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuFlatButton btnCadastrarMotoboy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblNome;
	}
}