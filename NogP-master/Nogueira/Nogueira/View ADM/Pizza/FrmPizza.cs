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
    public partial class FrmPizza : Form
    {
        public string nomeUsuario { get; set; }
        public Form _objForm { get; set; }
        public FrmPizza()
        {
            InitializeComponent();
        }

        private void FrmPizza_Load(object sender, EventArgs e)
        {
            lblNome.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            lblNome.Text = this.nomeUsuario + ",";

            PreencherDataGrid();

            dataPizza.Columns["Id_Pizza"].HeaderText = "ID";
            dataPizza.Columns["Nome_Sabor"].HeaderText = "Descrição";
            dataPizza.Columns["Preco"].HeaderText = "Preço";
            dataPizza.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataPizza.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataPizza.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        internal void PreencherDataGrid()
        {
            PizzaBusiness pizzaBusiness = new PizzaBusiness();
            List<PizzaDTO> PizzaList = pizzaBusiness.TodasPizzas();
            BindingList<PizzaDTO> BindingPizzaList = new BindingList<PizzaDTO>(PizzaList);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = PizzaList;

            dataPizza.DataSource = bSource;
            dataPizza.Update();
            dataPizza.Refresh();
            dataPizza.Focus();
        }

        private void btnCadastrarPizza_Click(object sender, EventArgs e)
        {
            FrmCadastrarPizza frmcadastroPizza = new FrmCadastrarPizza();
            frmcadastroPizza.Show();
        }

        private void BtnExcluirPizza_Click(object sender, EventArgs e)
        {
            if (dataPizza.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma pizza para ser excluída");
            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja realemnte excluir este item?", "Excluir Pizza",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PizzaBusiness pizzaBusiness = new PizzaBusiness();

                    var itemToDelete = (PizzaDTO)dataPizza.SelectedRows[0].DataBoundItem;
                    pizzaBusiness.DeletarPizza(itemToDelete);

                    var dataSource = (BindingList<PizzaDTO>)dataPizza.DataSource;
                    dataSource.Remove(itemToDelete);
                }
            }
        }

        private void BtnEditarPizza_Click(object sender, EventArgs e)
        {
            if (dataPizza.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma pizza para ser editada");
            }
            else
            {
                var pizzaSelecionada = (PizzaDTO)dataPizza.SelectedRows[0].DataBoundItem;
                IngredienteBusiness ingredBusiness = new IngredienteBusiness();

                List<IngredienteDTO> listIngredientes = ingredBusiness.BuscarIngredientesDaPizzaSelecionada(pizzaSelecionada);

                FrmCadastrarPizza frmCadastrarPizza = new FrmCadastrarPizza();
                frmCadastrarPizza.objPizza = pizzaSelecionada;
                frmCadastrarPizza.listaIngredientes = listIngredientes;

                frmCadastrarPizza.Show();
            }
        }

    }
}
