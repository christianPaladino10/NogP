using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogueira.NogueiraDAO
{
	public class IngredienteDAO
	{
		OleDbConnection conn;

		public void ConectarAccess()
		{
			Conexao con = new Conexao();
			conn = con.ConectarAccess(ref conn);
		}

		public DataTable GetIngredientes()
		{
			ConectarAccess();

			DataTable dtIngredientes = new DataTable("Ingredientes");
			string comando = "SELECT * FROM INGREDIENTES";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			try
			{
				dtIngredientes.Load(cmd.ExecuteReader());
			}
			catch (Exception E)
			{
				MessageBox.Show(E.Message);
			}
			finally
			{
				if (conn.State == ConnectionState.Open) conn.Close();
				if (conn != null) conn.Dispose();
			}

			return dtIngredientes;
		}
	}
}
