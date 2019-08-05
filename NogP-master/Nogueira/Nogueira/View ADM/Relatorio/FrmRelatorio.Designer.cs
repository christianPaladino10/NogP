namespace Nogueira.View_ADM.Relatorio
{
    partial class FrmRelatorio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPizza = new System.Windows.Forms.TabPage();
            this.btnPizzaRelat = new System.Windows.Forms.Button();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartPizza = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPizza);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1413, 616);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPizza
            // 
            this.tabPizza.Controls.Add(this.btnPizzaRelat);
            this.tabPizza.Controls.Add(this.txtAte);
            this.tabPizza.Controls.Add(this.txtDe);
            this.tabPizza.Controls.Add(this.label2);
            this.tabPizza.Controls.Add(this.label1);
            this.tabPizza.Controls.Add(this.chartPizza);
            this.tabPizza.Location = new System.Drawing.Point(4, 25);
            this.tabPizza.Name = "tabPizza";
            this.tabPizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPizza.Size = new System.Drawing.Size(1405, 587);
            this.tabPizza.TabIndex = 0;
            this.tabPizza.Text = "tabPizza";
            this.tabPizza.UseVisualStyleBackColor = true;
            // 
            // btnPizzaRelat
            // 
            this.btnPizzaRelat.Location = new System.Drawing.Point(544, 52);
            this.btnPizzaRelat.Name = "btnPizzaRelat";
            this.btnPizzaRelat.Size = new System.Drawing.Size(127, 46);
            this.btnPizzaRelat.TabIndex = 5;
            this.btnPizzaRelat.Text = "Pesquisar";
            this.btnPizzaRelat.UseVisualStyleBackColor = true;
            this.btnPizzaRelat.Click += new System.EventHandler(this.BtnPizzaRelat_Click);
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(337, 66);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(140, 22);
            this.txtAte.TabIndex = 4;
            this.txtAte.ValidatingType = typeof(System.DateTime);
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(77, 64);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(127, 22);
            this.txtDe.TabIndex = 3;
            this.txtDe.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "De";
            // 
            // chartPizza
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPizza.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPizza.Legends.Add(legend1);
            this.chartPizza.Location = new System.Drawing.Point(716, 3);
            this.chartPizza.Name = "chartPizza";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPizza.Series.Add(series1);
            this.chartPizza.Size = new System.Drawing.Size(689, 581);
            this.chartPizza.TabIndex = 0;
            this.chartPizza.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1405, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 685);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRelatorio";
            this.Text = "FrmRelatorio";
            this.tabControl1.ResumeLayout(false);
            this.tabPizza.ResumeLayout(false);
            this.tabPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPizza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPizza;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPizzaRelat;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.MaskedTextBox txtDe;
    }
}