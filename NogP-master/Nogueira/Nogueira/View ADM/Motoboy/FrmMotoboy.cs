using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogueira.View_ADM.Motoboy
{
	public partial class FrmMotoboy : Form
	{
		public string nomeUsuario { get; set; }
		public Form _objForm { get; set; }

		public FrmMotoboy()
		{
			InitializeComponent();
		}

		private void FrmMotoboy_Load(object sender, EventArgs e)
		{
			lblNome.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
			lblNome.Text = this.nomeUsuario + ",";
		}

		private void btnCadastrarMotoboy_Click(object sender, EventArgs e)
		{
			FrmCadastrarMotoboy frmCadastrarMotoboy = new FrmCadastrarMotoboy();
			frmCadastrarMotoboy.Show();
		}

	}
}
