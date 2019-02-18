using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogueira.View_ADM.Bebida
{
	public partial class FrmBebida : Form
	{
		public FrmBebida()
		{
			InitializeComponent();
		}
		public string nomeUsuario { get; set; }

		private void FrmBebida_Load(object sender, EventArgs e)
		{
			lblNome.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
			lblNome.Text = this.nomeUsuario + ",";
		}

		private void btnCadastrarBebida_Click(object sender, EventArgs e)
		{
			FrmCadastrarBebida frmCadastrarBebida = new FrmCadastrarBebida();
			frmCadastrarBebida.Show();
		}
	}
}
