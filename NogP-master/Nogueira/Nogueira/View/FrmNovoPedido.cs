﻿using Nogueira.NogueiraBusiness;
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
            MotoboyBusiness motoboyBusiness = new MotoboyBusiness();
            BebidaBusiness bebidaBusiness = new BebidaBusiness();

            comboBoxMotoboy.DataSource = motoboyBusiness.BuscarTodosMotoboy();
            comboBoxMotoboy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotoboy.ValueMember = "Id_Motoboy";
            comboBoxMotoboy.DisplayMember = "nome_Motoboy";

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

            comboBoxBebida.DataSource = bebidaBusiness.BuscarTodasBebidas();
            comboBoxBebida.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBebida.ValueMember = "Id_Bebida";
            comboBoxBebida.DisplayMember = "Descricao";

            table.Columns.Add("Qtde", typeof(int));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Vl. Unitário", typeof(string));
            table.Columns.Add("IdProduto", typeof(int));
            
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
            PizzaBusiness pizzaBusiness = new PizzaBusiness();

            table.Rows.Add(txtQtd1Sabor.Text, comboBoxPizza1Sabor.Text, maskedTextBoxPreco.Text, comboBoxPizza1Sabor.SelectedValue);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[3].Visible = false;

            SetDataGridView(dataGridView1);

            labelTotal.Text = pizzaBusiness.AutoSoma(dataGridView1);
        }

        private void btnIncluirMeio_Click(object sender, EventArgs e)
        {
            if (comboBoxMeio1.SelectedIndex != 0 && comboBoxMeio2.SelectedIndex != 0)
            {
                PizzaBusiness pizzaBusiness = new PizzaBusiness();
                string preco1 = maskedTextBoxPrecoMeio1.Text;
                string preco2 = maskedTextBoxPrecoMeio2.Text;
                string preco = pizzaBusiness.DescobrirMaiorValor(preco1, preco2);
                preco = "R$ " + preco;

                table.Rows.Add(1, "Meio " + comboBoxMeio1.Text + " & Meio " + comboBoxMeio2.Text, preco);
                dataGridView1.DataSource = table;
                SetDataGridView(dataGridView1);

                labelTotal.Text = pizzaBusiness.AutoSoma(dataGridView1);
            }
            else
            {
                MessageBox.Show("Selecione o sabor da outra metade da Pizza.");
            }
        }

        private void SetDataGridView(DataGridView dataGridView1)
        {
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 403;
            dataGridView1.Columns[2].Width = 125;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            PizzaBusiness pizzaBusiness = new PizzaBusiness();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }

            if (dataGridView1.Rows.Count == 1)
            {
                labelTotal.Text = "";
            }
            else
            {
                labelTotal.Text = pizzaBusiness.AutoSoma(dataGridView1);
            }
        }

        private void radioButtonEntrega_CheckedChanged(object sender, EventArgs e)
        {
            labelMotoboy.Visible = true;
            comboBoxMotoboy.Visible = true;
            groupBoxCliente.Visible = true;
            groupBoxPizza1Sabor.Visible = true;
            groupBoxPizzaMeio.Visible = true;
            groupBoxBebidas.Visible = true;
        }

        private void radioButtonBalcao_CheckedChanged(object sender, EventArgs e)
        {
            labelMotoboy.Visible = false;
            comboBoxMotoboy.Visible = false;
            groupBoxCliente.Visible = true;
            groupBoxPizza1Sabor.Visible = true;
            groupBoxPizzaMeio.Visible = true;
            groupBoxBebidas.Visible = true;
        }

        private void btnBuscarTel_Click_1(object sender, EventArgs e)
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

        private void BtnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(txtTelefone.Text))
                {
                    MessageBox.Show("Preencha um cliente para este pedido!");
                }
                else
                {
                    string numCliente = txtTelefone.Text;
                    ClienteBusiness clienteBusiness = new ClienteBusiness();
                    VendaDTO vendaDTO = new VendaDTO();
                    VendaBusiness vendaBusiness = new VendaBusiness();

                    vendaDTO.ClienteId = clienteBusiness.BuscarIdCliente(numCliente);
                    vendaDTO.ValorTotal = labelTotal.Text;

                    int idVenda = vendaBusiness.GravarPedido(vendaDTO);                   

                    foreach (var DataRow in table.Rows)
                    {
                        vendaBusiness.GravarNpraN(DataRow, idVenda);
                    }

                }
            }
            else
            {
                MessageBox.Show("Não há nenhum pedido a ser finalizado");
            }
        }

        private void BtnIncluirBebida_Click(object sender, EventArgs e)
        {
            PizzaBusiness pizzaBusiness = new PizzaBusiness();

            table.Rows.Add(txtQtdBebida.Text, comboBoxBebida.Text, maskedTextBoxPrecoBebida.Text);
            dataGridView1.DataSource = table;
            SetDataGridView(dataGridView1);

            labelTotal.Text = pizzaBusiness.AutoSoma(dataGridView1);
        }

        private void ComboBoxBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBebida.SelectedIndex != 0)
            {
                BebidaBusiness bebidaBusiness = new BebidaBusiness();
                string bebidaSelecionada = comboBoxBebida.Text;
                double preco = bebidaBusiness.AlterarTextBoxConformeCombo(bebidaSelecionada);
                string precoText = preco.ToString();

                if (precoText.Contains(","))
                {
                    if (precoText.Length > 3)
                    {
                        maskedTextBoxPrecoBebida.Text = preco.ToString() + "0";
                    }
                    else
                    {
                        maskedTextBoxPrecoBebida.Text = "0" + preco.ToString() + "0";
                    }
                }
                else
                {
                    if (precoText.Length > 1)
                    {
                        maskedTextBoxPrecoBebida.Text = preco.ToString() + "00";
                    }
                    else
                    {
                        maskedTextBoxPrecoBebida.Text = "0" + preco.ToString() + "00";
                    }
                    
                }
               
            }
        }
    }
}
