using Nogueira.NogueiraDAO;
using Nogueira.NogueiraDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Nogueira.NogueiraBusiness
{
    public class PizzaBusiness
    {
        internal void Cadastrar(PizzaDTO dadosPizza)
        {
            PizzaDAO pizzaDAO = new PizzaDAO();
            pizzaDAO.Cadastrar(dadosPizza);
        }

		internal void CadastrarIngredientesPizza(List<string> listIngrediente, PizzaDTO dadosPizza)
		{
			PizzaDAO pizzaDAO = new PizzaDAO();
			IngredienteDAO ingredientesDAO = new IngredienteDAO();

			int idPizza = ((int)pizzaDAO.BuscarIdPizza(dadosPizza));
			ingredientesDAO.CadastrarPizzaHasIngredientes(idPizza, listIngrediente);
		
		}

		internal bool PizzaCadastrada(string nome_Sabor)
		{
			PizzaDAO pizzaDAO = new PizzaDAO();
			if (pizzaDAO.PizzaCadastrada(nome_Sabor))
			{
				return true;
			}
			else
			{
				return false;
			}			
		}

		internal DataTable BuscarTodasPizzas()
		{
			PizzaDAO pizzaDAO = new PizzaDAO();
			return pizzaDAO.BuscarTodasPizzas();
		}

        internal List<PizzaDTO> TodasPizzas()
        {
            PizzaDAO pizzaDAO = new PizzaDAO();
            return pizzaDAO.TodasPizzas();
        }

        internal double AlterarTextBoxConformeCombo(string pizzaSelecionada)
		{
			PizzaDAO pizzaDAO = new PizzaDAO();
			return pizzaDAO.AlterarTextBoxConformeCombo(pizzaSelecionada);
		}

		public string DescobrirMaiorValor(string preco1, string preco2)
		{
			preco1 = preco1.Replace("R$ ", "").Trim();
			preco2 = preco2.Replace("R$ ", "").Trim();

			double preco1Double = double.Parse(preco1);
			double preco2Double = double.Parse(preco2);

			if (preco1Double > preco2Double)
			{
				return preco1;
			}
			else
			{
				return preco2;
			}
		}

		internal string AutoSoma(DataGridView dataGridView1)
		{
			double soma = 0;
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells[2].Value != null)
				{
					var valorComR = row.Cells[2].Value.ToString();
					double precoAgregado = double.Parse(valorComR.Replace("R$ ", ""));
					soma += precoAgregado;
				}
			}
			string preco = Convert.ToString(soma.ToString());
			string preco1 = preco.Substring(0, 2);
			string preco2 = preco.Substring(2, 2);
			preco = preco1 + "." + preco2;

			return preco;
		}

        internal void DeletarPizza(PizzaDTO itemToDelete)
        {
            PizzaDAO pizzaDAO = new PizzaDAO();
            pizzaDAO.DeletarNpraNPizzaIngrediente(itemToDelete.Id_Pizza);
            pizzaDAO.ExcluirPizza(itemToDelete.Id_Pizza);
        }

        internal void EditarPizza(PizzaDTO itemToEdit)
        {
            throw new NotImplementedException();
        }

        internal void Atualizar(PizzaDTO dadosPizza)
        {
            throw new NotImplementedException();
        }

        internal void AtualizarIngredientesPizza(List<string> listIngrediente, PizzaDTO dadosPizza)
        {
            throw new NotImplementedException();
        }
    }
}
