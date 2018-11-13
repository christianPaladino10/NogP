using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nogueira.NogueiraDAO;
using Nogueira.NogueiraDTO;

namespace Nogueira.NogueiraBusiness
{
    public class LoginBusiness
    {
        internal bool ValidarLogin(LoginDTO dadosLogin)
        {
            LoginDAO dao = new LoginDAO();

            if (dao.ValidarLoginDAO(dadosLogin))
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
