using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nogueira.NogueiraBusiness;
using Nogueira.NogueiraDTO;

namespace Nogueira.View_ADM.Motoboy
{
	public partial class FrmCadastrarMotoboy : Form
	{
		public FrmCadastrarMotoboy()
		{
			InitializeComponent();
		}

		private void btnCadastrarMotoboy_Click(object sender, EventArgs e)
		{
			MotoboyDTO dadosMotoboy = new MotoboyDTO();
			MotoboyBusiness motoboyBusiness = new MotoboyBusiness();

			if (txtNomeMotoboy.Text == string.Empty)
			{
				MessageBox.Show("Nome é requerido!");
			}
			else
			{
				dadosMotoboy.Nome_Motoboy = txtNomeMotoboy.Text.Trim();
				dadosMotoboy.Modelo_Moto = txtModeloMoto.Text.Trim();
				dadosMotoboy.Placa_Moto = txtPlacaMoto.Text.Trim();
				dadosMotoboy.CNH = txtCNH.Text.Trim();

				motoboyBusiness.Cadastrar(dadosMotoboy);
			}
		}
	}
}
