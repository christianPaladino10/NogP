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
		DataTable table = new DataTable();


		private void FrmNovoPedido_Load(object sender, EventArgs e)
		{
			PizzaBusiness pizzaBusiness = new PizzaBusiness();

			comboBoxPizza1Sabor.DataSource = pizzaBusiness.BuscarTodasPizzas();
			comboBoxPizza1Sabor.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxPizza1Sabor.ValueMember = "Id_Pizza";
			comboBoxPizza1Sabor.DisplayMember = "Nome_Sabor";
			//comboBoxPizza1Sabor.SelectedIndex = -1;

			comboBoxMeio1.DataSource = pizzaBusiness.BuscarTodasPizzas();
			comboBoxMeio1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxMeio1.ValueMember = "Id_Pizza";
			comboBoxMeio1.DisplayMember = "Nome_Sabor";
			//comboBoxMeio1.SelectedIndex = -1;

			comboBoxMeio2.DataSource = pizzaBusiness.BuscarTodasPizzas();
			comboBoxMeio2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxMeio2.ValueMember = "Id_Pizza";
			comboBoxMeio2.DisplayMember = "Nome_Sabor";

			table.Columns.Add("Qtde", typeof(int));
			table.Columns.Add("Descrição", typeof(string));
			table.Columns.Add("Vl. Unitário", typeof(string));
			table.Columns.Add("Total", typeof(string));

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

		private void comboBoxPizza1Sabor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxPizza1Sabor.SelectedIndex != 0)
			{
				PizzaBusiness pizzaBusiness = new PizzaBusiness();
				string pizzaSelecionada = comboBoxPizza1Sabor.Text;
				double preco = pizzaBusiness.AlterarTextBoxConformeCombo(pizzaSelecionada);
				string precoText = preco.ToString();

				maskedTextBoxPreco.Text = precoText;				
			}			
		}

		private void comboBoxMeio1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxMeio1.SelectedIndex != 0)
			{
				PizzaBusiness pizzaBusiness = new PizzaBusiness();
				string pizzaSelecionada = comboBoxMeio1.Text;
				double preco = pizzaBusiness.AlterarTextBoxConformeCombo(pizzaSelecionada);
				string precoText = preco.ToString();

				maskedTextBoxPrecoMeio1.Text = precoText;
			}
		}

		private void comboBoxMeio2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxMeio2.SelectedIndex != 0)
			{
				PizzaBusiness pizzaBusiness = new PizzaBusiness();
				string pizzaSelecionada = comboBoxMeio2.Text;
				double preco = pizzaBusiness.AlterarTextBoxConformeCombo(pizzaSelecionada);
				string precoText = preco.ToString();

				maskedTextBoxPrecoMeio2.Text = precoText;
			}
		}

		private void btnIncluir1Sabor_Click(object sender, EventArgs e)
		{
			table.Rows.Add(txtQtd1Sabor.Text, comboBoxPizza1Sabor.Text, maskedTextBoxPreco.Text, null);
			dataGridView1.DataSource = table;
		}

		private void btnIncluirMeio_Click(object sender, EventArgs e)
		{
			PizzaBusiness pizzaBusiness = new PizzaBusiness();
			string preco1 = maskedTextBoxPrecoMeio1.Text;
			string preco2 = maskedTextBoxPrecoMeio2.Text;
			string preco = pizzaBusiness.DescobrirMaiorValor(preco1, preco2);

			table.Rows.Add(1, "Meio " + comboBoxMeio1.Text + " & Meio " + comboBoxMeio2.Text, preco, null);
			dataGridView1.DataSource = table;
			SetDataGridView(dataGridView1);		
		}

		private void SetDataGridView(DataGridView dataGridView1)
		{
			dataGridView1.Columns[0].Width = 100;
			dataGridView1.Columns[1].Width = 460;
			dataGridView1.Columns[2].Width = 120;
			dataGridView1.Columns[3].Width = 120;
		}
	}
}
