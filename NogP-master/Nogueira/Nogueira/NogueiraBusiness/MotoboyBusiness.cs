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
	public class MotoboyBusiness
	{
		internal void Cadastrar(MotoboyDTO dadosMotoboy)
		{
			MotoboyDAO motoboyDAO = new MotoboyDAO();
			motoboyDAO.Cadastrar(dadosMotoboy);
		}

		internal DataTable BuscarTodosMotoboy()
		{
			MotoboyDAO motoboyDAO = new MotoboyDAO();
			return motoboyDAO.BuscarTodosMotoboy();
		}

        internal List<MotoboyDTO> TodosMotoboy()
        {
            MotoboyDAO motoboyDAO = new MotoboyDAO();
            return motoboyDAO.TodosMotoboy();
        }

        internal void DeletarMotoboy(MotoboyDTO itemToDelete)
        {
            MotoboyDAO motoboyDAO = new MotoboyDAO();
            motoboyDAO.DeletarMotoboy(itemToDelete.Id_Motoboy);
        }

        internal void AtualizarMotoboy(MotoboyDTO dadosMotoboy)
        {
            MotoboyDAO motoboyDAO = new MotoboyDAO();
            motoboyDAO.Atualizar(dadosMotoboy);
        }
    }
}
