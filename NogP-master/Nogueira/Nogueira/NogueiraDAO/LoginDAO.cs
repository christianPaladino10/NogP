using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nogueira.NogueiraBusiness;
using Nogueira.NogueiraDTO;

namespace Nogueira.NogueiraDAO
{
    public class LoginDAO
    {
        OleDbConnection conn;

        public void ConectarAccess()
        {
            Conexao con = new Conexao();
            conn = con.ConectarAccess(ref conn);
        }

        internal bool ValidarLoginDAO(LoginDTO dadosLogin)
        {
            ConectarAccess();

            string comando = "SELECT * FROM Login WHERE User = @user and Senha = @senha";

            OleDbCommand cmd = new OleDbCommand(comando, conn);
            cmd.Parameters.Add("@user", OleDbType.VarChar).Value = dadosLogin.User;
            cmd.Parameters.Add("@senha", OleDbType.VarChar).Value = dadosLogin.Senha;
            try
            {
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Credenciais inválidas");
                }
                return true;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                if (conn != null) conn.Dispose();
            }
        }
    }
}
