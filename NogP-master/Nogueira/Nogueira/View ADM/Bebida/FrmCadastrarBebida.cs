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
        public FrmBebida _parentForm { get; set; }
        public BebidaDTO objBebida = new BebidaDTO();

        public FrmCadastrarBebida(FrmBebida parent)
		{
			InitializeComponent();
            _parentForm = parent;
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
				if (!maskedTextBoxPrecoBebida.MaskFull)
				{
					MessageBox.Show("Digite um preço corretamente!");
				}
				else
				{
					dadosBebida.DescricaoBebida = txtDescricaoBebida.Text.Trim();
					string preco = maskedTextBoxPrecoBebida.Text.Replace("R$ ", "").Trim();
					dadosBebida.Preco = double.Parse(preco);

					bebidaBusiness.CadastrarBebida(dadosBebida);

                    _parentForm.PreencherDataGrid();
                    this.Close();
                }				
			}

		}

        private void FrmCadastrarBebida_Load(object sender, EventArgs e)
        {
            btnAtualizarBebida.Visible = false;
            btnCadastrarBebida.Visible = true;

            if (objBebida.IsEdit)
            {
                btnAtualizarBebida.Visible = true;
                btnCadastrarBebida.Visible = false;

                txtDescricaoBebida.Text = objBebida.DescricaoBebida;
                maskedTextBoxPrecoBebida.Text = objBebida.Preco.ToString();
            }
            
        }

        private void BtnAtualizarBebida_Click(object sender, EventArgs e)
        {
            BebidaDTO dadosBebida = new BebidaDTO();
            BebidaBusiness bebidaBusiness = new BebidaBusiness();

            if (txtDescricaoBebida.Text == string.Empty)
            {
                MessageBox.Show("Descrição é requerido!");
            }
            else
            {
                if (!maskedTextBoxPrecoBebida.MaskFull)
                {
                    MessageBox.Show("Digite um preço corretamente!");
                }
                else
                {
                    dadosBebida.DescricaoBebida = txtDescricaoBebida.Text.Trim();
                    string preco = maskedTextBoxPrecoBebida.Text.Replace("R$ ", "").Trim();
                    dadosBebida.Preco = double.Parse(preco);
                    dadosBebida.IdBebida = objBebida.IdBebida;

                    bebidaBusiness.AtualizarBebida(dadosBebida);

                    _parentForm.PreencherDataGrid();
                    this.Close();
                }
            }
        }
    }
}
