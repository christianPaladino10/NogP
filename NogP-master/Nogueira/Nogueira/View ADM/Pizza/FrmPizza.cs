using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogueira
{
    public partial class FrmPizza : Form
    {
        public string nomeUsuario { get; set; }
        public Form _objForm { get; set; }
        public FrmPizza()
        {
            InitializeComponent();
        }

        private void FrmPizza_Load(object sender, EventArgs e)
        {
            lblNome.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            lblNome.Text = this.nomeUsuario + ",";
        }

        private void btnCadastrarPizza_Click(object sender, EventArgs e)
        {
            FrmCadastrarPizza frmcadastroPizza = new FrmCadastrarPizza();
            frmcadastroPizza.Show();
        }
    }
}
