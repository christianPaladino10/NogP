namespace Nogueira
{
    partial class FrmPainelADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPainelADM));
            this.labelNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPainelPizza = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAdm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(86, 26);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 13);
            this.labelNome.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnPainelPizza);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 649);
            this.panel1.TabIndex = 2;
            // 
            // btnPainelPizza
            // 
            this.btnPainelPizza.Activecolor = System.Drawing.Color.Transparent;
            this.btnPainelPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPainelPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPainelPizza.BorderRadius = 0;
            this.btnPainelPizza.ButtonText = "        Pizza";
            this.btnPainelPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPainelPizza.DisabledColor = System.Drawing.Color.Gray;
            this.btnPainelPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainelPizza.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPainelPizza.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPainelPizza.Iconimage")));
            this.btnPainelPizza.Iconimage_right = null;
            this.btnPainelPizza.Iconimage_right_Selected = null;
            this.btnPainelPizza.Iconimage_Selected = null;
            this.btnPainelPizza.IconMarginLeft = 0;
            this.btnPainelPizza.IconMarginRight = 0;
            this.btnPainelPizza.IconRightVisible = true;
            this.btnPainelPizza.IconRightZoom = 0D;
            this.btnPainelPizza.IconVisible = true;
            this.btnPainelPizza.IconZoom = 90D;
            this.btnPainelPizza.IsTab = true;
            this.btnPainelPizza.Location = new System.Drawing.Point(0, 304);
            this.btnPainelPizza.Margin = new System.Windows.Forms.Padding(5);
            this.btnPainelPizza.Name = "btnPainelPizza";
            this.btnPainelPizza.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPainelPizza.OnHovercolor = System.Drawing.Color.Silver;
            this.btnPainelPizza.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPainelPizza.selected = false;
            this.btnPainelPizza.Size = new System.Drawing.Size(279, 65);
            this.btnPainelPizza.TabIndex = 4;
            this.btnPainelPizza.Text = "        Pizza";
            this.btnPainelPizza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainelPizza.Textcolor = System.Drawing.Color.Silver;
            this.btnPainelPizza.TextFont = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainelPizza.Click += new System.EventHandler(this.btnPainelPizza_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(86, 248);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 24);
            this.lblNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seja Bem Vindo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelAdm
            // 
            this.panelAdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdm.Location = new System.Drawing.Point(279, 0);
            this.panelAdm.Name = "panelAdm";
            this.panelAdm.Size = new System.Drawing.Size(695, 649);
            this.panelAdm.TabIndex = 3;
            // 
            // FrmPainelADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(974, 649);
            this.Controls.Add(this.panelAdm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNome);
            this.Name = "FrmPainelADM";
            this.Text = "FrmPainelADM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPainelADM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private Bunifu.Framework.UI.BunifuFlatButton btnPainelPizza;
        private System.Windows.Forms.Panel panelAdm;
    }
}