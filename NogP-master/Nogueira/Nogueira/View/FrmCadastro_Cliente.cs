using Nogueira.NogueiraBusiness;
using Nogueira.NogueiraDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogueira
{
    public partial class FrmCadastro_Cliente : Form
    {
        public FrmCadastro_Cliente()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ClienteDTO dadosCliente = new ClienteDTO();
            ClienteBusiness clienteBusiness = new ClienteBusiness();

            dadosCliente.Nome = txtNome.Text;
            dadosCliente.Telefone = txtTelefone.Text.Replace("-", "");
            dadosCliente.Endereco = txtEndereco.Text;
            dadosCliente.Numero = txtNumero.Text;
            dadosCliente.Complemento = txtComplemento.Text;
            dadosCliente.PontoReferencia = txtPonto_Referencia.Text;
            dadosCliente.DataAniversario = txtData_Aniversario.Text;
			dadosCliente.Bairro = txtBairro.Text;

            clienteBusiness.Cadastrar(dadosCliente);
        }

		private void txtCEP_Leave(object sender, EventArgs e)
		{
			var ws = new WSCorreios.AtendeClienteClient();
			var resposta = ws.consultaCEP(txtCEP.Text);

			txtEndereco.Text = resposta.end;
			txtBairro.Text = resposta.bairro;
		}
	}
}
