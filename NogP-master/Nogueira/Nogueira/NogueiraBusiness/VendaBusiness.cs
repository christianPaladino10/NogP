using Nogueira.NogueiraDAO;
using Nogueira.NogueiraDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogueira.NogueiraBusiness
{
    public class VendaBusiness
    {
        internal void GravarNpraN(object dataRow, int idVenda)
        {
            VendaDAO vendaDAO = new VendaDAO();
            vendaDAO.GravarNpraN(dataRow, idVenda);
        }

        internal int GravarPedido(VendaDTO vendaDTO)
        {
            VendaDAO vendaDAO = new VendaDAO();
            vendaDAO.GravarPedido(vendaDTO);
           return vendaDAO.BuscarIdVenda();
        }
    }
}
