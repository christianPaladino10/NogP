using Nogueira.NogueiraBusiness;
using Nogueira.NogueiraDTO;
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
    public partial class FrmNovoPedido : Form
    {
        public FrmNovoPedido()
        {
            InitializeComponent();
        }

        private void btnBuscarTel_Click(object sender, EventArgs e)
        {
            if (txtTelefone.Text == string.Empty)
            {
                MessageBox.Show("Digite um número de telefone");
            }
            else
            {
                string telefone = txtTelefone.Text.Replace("-", "");
                ClienteDTO dadosCliente = new ClienteDTO();
                ClienteBusiness clienteBusiness = new ClienteBusiness();

                clienteBusiness.BuscarPorTelefone(telefone, dadosCliente);

                txtNome.Text = dadosCliente.Nome;
                txtEndereco.Text = dadosCliente.Endereco;
                txtNumero.Text = dadosCliente.Numero;
                txtPonto_Referencia.Text = dadosCliente.PontoReferencia;
                txtComplemento.Text = dadosCliente.Complemento;
            }      
        }
	}
}
