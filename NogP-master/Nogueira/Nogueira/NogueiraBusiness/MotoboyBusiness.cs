using System;
using System.Collections.Generic;
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
	}
}
