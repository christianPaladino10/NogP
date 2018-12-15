using Nogueira.NogueiraDAO;
using Nogueira.NogueiraDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

	}
}
