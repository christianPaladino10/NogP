using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nogueira.NogueiraDAO;
using Nogueira.NogueiraDTO;

namespace Nogueira.NogueiraBusiness
{
	public class IngredienteBusiness
	{
		internal DataTable PreencherIngredientes()
		{
			IngredienteDAO ingredienteDAO = new IngredienteDAO();
			return ingredienteDAO.GetIngredientes();			
		}

        internal List<IngredienteDTO> BuscarIngredientesDaPizzaSelecionada(PizzaDTO pizzaSelecionada)
        {
            IngredienteDAO ingredienteDAO = new IngredienteDAO();
            var listaIdsPizzas = ingredienteDAO.BuscarIDIngredientesDaPizzaSelecionada(pizzaSelecionada);

            return ingredienteDAO.BuscarIngredientes(listaIdsPizzas);
        }
    }
}
