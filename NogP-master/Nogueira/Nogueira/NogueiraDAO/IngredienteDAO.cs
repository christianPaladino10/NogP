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

				var rw = dtIngredientes.NewRow();
				rw[1] = "";
				dtIngredientes.Rows.InsertAt(rw, 0);
				return dtIngredientes;
			}
			catch (Exception E)
			{
				MessageBox.Show(E.Message);
				return null;
			}
			finally
			{
				if (conn.State == ConnectionState.Open) conn.Close();
				if (conn != null) conn.Dispose();
			}
		}

		internal void CadastrarPizzaHasIngredientes(int idPizza, List<string> listIngrediente)
		{
			ConectarAccess();

			foreach (var item in listIngrediente)
			{
				string comando = "INSERT INTO Pizza_has_Ingredientes (Id_Pizza, Id_Ingrediente)" +
									"values(@Id_Pizza, @Id_Ingrediente)";

				OleDbCommand cmd = new OleDbCommand(comando, conn);

				cmd.Parameters.Add("@Id_Pizza", OleDbType.VarChar).Value = idPizza;
				cmd.Parameters.Add("@Id_Ingrediente", OleDbType.Decimal).Value = item;

				try
				{
					cmd.ExecuteNonQuery();
				}
				catch (Exception E)
				{
					MessageBox.Show(E.Message);
				}
			}

			if (conn.State == ConnectionState.Open) conn.Close();
			if (conn != null) conn.Dispose();
		}
	}
}
