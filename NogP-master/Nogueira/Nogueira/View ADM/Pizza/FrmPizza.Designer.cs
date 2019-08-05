namespace Nogueira
{
    partial class FrmPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizza));
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarPizza = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(56, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 17);
            this.lblNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "escolha o que deseja fazer neste momento";
            // 
            // btnCadastrarPizza
            // 
            this.btnCadastrarPizza.Activecolor = System.Drawing.Color.Transparent;
            this.btnCadastrarPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCadastrarPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarPizza.BorderRadius = 0;
            this.btnCadastrarPizza.ButtonText = "               Cadastrar Pizza";
            this.btnCadastrarPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarPizza.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrarPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPizza.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrarPizza.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarPizza.Iconimage")));
            this.btnCadastrarPizza.Iconimage_right = null;
            this.btnCadastrarPizza.Iconimage_right_Selected = null;
            this.btnCadastrarPizza.Iconimage_Selected = null;
            this.btnCadastrarPizza.IconMarginLeft = 0;
            this.btnCadastrarPizza.IconMarginRight = 0;
            this.btnCadastrarPizza.IconRightVisible = true;
            this.btnCadastrarPizza.IconRightZoom = 0D;
            this.btnCadastrarPizza.IconVisible = false;
            this.btnCadastrarPizza.IconZoom = 90D;
            this.btnCadastrarPizza.IsTab = true;
            this.btnCadastrarPizza.Location = new System.Drawing.Point(128, 213);
            this.btnCadastrarPizza.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCadastrarPizza.Name = "btnCadastrarPizza";
            this.btnCadastrarPizza.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCadastrarPizza.OnHovercolor = System.Drawing.Color.Silver;
            this.btnCadastrarPizza.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrarPizza.selected = false;
            this.btnCadastrarPizza.Size = new System.Drawing.Size(493, 171);
            this.btnCadastrarPizza.TabIndex = 5;
            this.btnCadastrarPizza.Text = "               Cadastrar Pizza";
            this.btnCadastrarPizza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarPizza.Textcolor = System.Drawing.Color.Silver;
            this.btnCadastrarPizza.TextFont = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPizza.Click += new System.EventHandler(this.btnCadastrarPizza_Click);
            // 
            // FrmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1385, 947);
            this.Controls.Add(this.btnCadastrarPizza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPizza";
            this.Text = "FrmPizza";
            this.Load += new System.EventHandler(this.FrmPizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrarPizza;
    }
}