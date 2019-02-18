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

namespace Nogueira.View_ADM.Bebida
{
	public partial class FrmCadastrarBebida : Form
	{
		public FrmCadastrarBebida()
		{
			InitializeComponent();
		}

		private void btnCadastrarBebida_Click(object sender, EventArgs e)
		{
			BebidaDTO dadosBebida = new BebidaDTO();
			BebidaBusiness bebidaBusiness = new BebidaBusiness();

			if (txtDescricaoBebida.Text == string.Empty)
			{
				MessageBox.Show("Descrição é requerido!");
			}
			else
			{
				if (maskedTextBoxPrecoBebida.TextLength < 3)
				{
					MessageBox.Show("Digite um preço corretamente!");
				}
				else
				{
					dadosBebida.DescricaoBebida = txtDescricaoBebida.Text.Trim();
					string preco = maskedTextBoxPrecoBebida.Text.Replace("R$ ", "").Trim();
					dadosBebida.Preco = double.Parse(preco);

					bebidaBusiness.CadastrarBebida(dadosBebida);
				}				
			}

		}
	}
}
