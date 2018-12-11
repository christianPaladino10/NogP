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
			int idPizza = ((int)pizzaDAO.BuscarIdPizza(dadosPizza)); 
			//Christian teste
		}
	}
}
