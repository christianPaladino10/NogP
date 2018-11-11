using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nogueira.NogueiraDTO;
using Nogueira.NogueiraDAO;

namespace Nogueira.NogueiraBusiness
{
    public class ClienteBusiness
    {
        internal void Cadastrar(ClienteDTO dadosCliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.Cadastrar(dadosCliente);
        }

        internal void BuscarPorTelefone(string telefone, ClienteDTO dadosCliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.BuscarPorTelefone(telefone, dadosCliente);
        }
    }
}
