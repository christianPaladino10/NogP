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
    public partial class FrmCadastrarPizza : Form
    {
        public FrmPizza _parentForm { get; set; }
        public PizzaDTO objPizza = new PizzaDTO();
        public List<IngredienteDTO> listaIngredientes = new List<IngredienteDTO>();

        public FrmCadastrarPizza(FrmPizza parent)
        {
            InitializeComponent();
            _parentForm = parent;
        }

        private void FrmCadastrarPizza_Load(object sender, EventArgs e)
        {
            IngredienteBusiness ingredienteBusiness = new IngredienteBusiness();
            comboBox1.DataSource = ingredienteBusiness.PreencherIngredientes();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ValueMember = "Id_Ingrediente";
            comboBox1.DisplayMember = "Nome_Ingrediente";
            comboBox1.SelectedIndex = -1;

            comboBox2.DataSource = ingredienteBusiness.PreencherIngredientes();
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.ValueMember = "Id_Ingrediente";
            comboBox2.DisplayMember = "Nome_Ingrediente";
            comboBox2.SelectedIndex = -1;

            comboBox3.DataSource = ingredienteBusiness.PreencherIngredientes();
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.ValueMember = "Id_Ingrediente";
            comboBox3.DisplayMember = "Nome_Ingrediente";
            comboBox3.SelectedIndex = -1;

            comboBox4.DataSource = ingredienteBusiness.PreencherIngredientes();
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.ValueMember = "Id_Ingrediente";
            comboBox4.DisplayMember = "Nome_Ingrediente";
            comboBox4.SelectedIndex = -1;

            comboBox5.DataSource = ingredienteBusiness.PreencherIngredientes();
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.ValueMember = "Id_Ingrediente";
            comboBox5.DisplayMember = "Nome_Ingrediente";
            comboBox5.SelectedIndex = -1;

            btnAtualizarPizza.Visible = false;
            btnCadastrarPizza.Visible = true;

            if (listaIngredientes.Count > 0)
            {
                txtSaborPizza.Text = objPizza.Nome_Sabor;
                maskedTextBoxPreco.Text = objPizza.Preco.ToString();
                btnAtualizarPizza.Visible = true;
                btnCadastrarPizza.Visible = false;

                int qntsCombos = listaIngredientes.Count();
                bool c1 = false, c2 = false, c3 = false, c4 = false, c5 = false;

                for (int i = 0; i < qntsCombos; i++)
                {
                    if (!c1)
                    {
                        comboBox1.SelectedIndex = comboBox1.FindStringExact(listaIngredientes[i].Nome_Ingrediente);
                        c1 = true;
                        continue;
                    }
                    if (!c2)
                    {
                        comboBox2.SelectedIndex = comboBox2.FindStringExact(listaIngredientes[i].Nome_Ingrediente);
                        c2 = true;
                        continue;
                    }
                    if (!c3)
                    {
                        comboBox3.SelectedIndex = comboBox3.FindStringExact(listaIngredientes[i].Nome_Ingrediente);
                        c3 = true;
                        continue;
                    }
                    if (!c4)
                    {
                        comboBox4.SelectedIndex = comboBox4.FindStringExact(listaIngredientes[i].Nome_Ingrediente);
                        c4 = true;
                        continue;
                    }
                    if (!c5)
                    {
                        comboBox5.SelectedIndex = comboBox5.FindStringExact(listaIngredientes[i].Nome_Ingrediente);
                        c5 = true;
                        continue;
                    }
                }
            }
        }

        private void btnCadastrarPizza_Click(object sender, EventArgs e)
        {
            PizzaDTO dadosPizza = new PizzaDTO();
            PizzaBusiness pizzaBusiness = new PizzaBusiness();

            if (txtSaborPizza.Text == string.Empty || comboBox1.Text == string.Empty || !maskedTextBoxPreco.MaskFull)
            {
                MessageBox.Show("Preencha corretamente as informações para cadastrar a Pizza");
            }
            else
            {
                dadosPizza.Nome_Sabor = txtSaborPizza.Text.Trim();
                if (pizzaBusiness.PizzaCadastrada(dadosPizza.Nome_Sabor))
                {
                    MessageBox.Show("Sabor de Pizza já cadastrada no Sistema!");
                }
                else
                {
                    var listIngrediente = new List<string>();
                    BuscarIngredientes(listIngrediente);

                    listIngrediente = listIngrediente.Distinct().ToList();

                    string preco = maskedTextBoxPreco.Text.Replace("R$ ", "").Trim();
                    dadosPizza.Preco = double.Parse(preco);
                    pizzaBusiness.Cadastrar(dadosPizza);

                    pizzaBusiness.CadastrarIngredientesPizza(listIngrediente, dadosPizza);

                    _parentForm.PreencherDataGrid();
                    this.Close();
                }
            }
        }

        private List<string> BuscarIngredientes(List<string> listIngrediente)
        {
            object valor = comboBox1.SelectedValue;
            listIngrediente.Add(valor.ToString());

            if (comboBox2.SelectedIndex != -1)
            {
                valor = comboBox2.SelectedValue;
                listIngrediente.Add(valor.ToString());
            }
            if (comboBox3.SelectedIndex != -1)
            {
                valor = comboBox3.SelectedValue;
                listIngrediente.Add(valor.ToString());
            }
            if (comboBox4.SelectedIndex != -1)
            {
                valor = comboBox4.SelectedValue;
                listIngrediente.Add(valor.ToString());
            }
            if (comboBox5.SelectedIndex != -1)
            {
                valor = comboBox5.SelectedValue;
                listIngrediente.Add(valor.ToString());
            }
            return listIngrediente;
        }

        private void BtnAtualizarPizza_Click(object sender, EventArgs e)
        {
            PizzaDTO dadosPizza = new PizzaDTO();
            PizzaBusiness pizzaBusiness = new PizzaBusiness();

            if (txtSaborPizza.Text == string.Empty || comboBox1.Text == string.Empty || !maskedTextBoxPreco.MaskFull)
            {
                MessageBox.Show("Preencha corretamente as informações para cadastrar a Pizza");
            }
            else
            {
                var listIngrediente = new List<string>();
                BuscarIngredientes(listIngrediente);

                listIngrediente = listIngrediente.Distinct().Where(x => !string.IsNullOrEmpty(x)).ToList();

                dadosPizza.Id_Pizza = objPizza.Id_Pizza;
                dadosPizza.Nome_Sabor = txtSaborPizza.Text.Trim();
                string preco = maskedTextBoxPreco.Text.Replace("R$ ", "").Trim();
                dadosPizza.Preco = double.Parse(preco);
                pizzaBusiness.Atualizar(dadosPizza);

                List<string> listaIngredientesCarregadosNaTela = listaIngredientes.Select(x => x.Id_Ingrediente.ToString()).ToList();

                if (!listaIngredientesCarregadosNaTela.SequenceEqual(listIngrediente))
                {
                    pizzaBusiness.AtualizarIngredientesPizza(listIngrediente, dadosPizza);
                    MessageBox.Show("Pizza Atualizada com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Pizza Atualizada com Sucesso!");
                }

                _parentForm.PreencherDataGrid();
                this.Close();
            }
        }
    }
}
