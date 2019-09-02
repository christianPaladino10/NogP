using Nogueira.NogueiraDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Nogueira.NogueiraDAO
{
	public class PizzaDAO
	{
		OleDbConnection conn;

		public void ConectarAccess()
		{
			Conexao con = new Conexao();
			conn = con.ConectarAccess(ref conn);
		}
		
		internal Nullable <int> BuscarIdPizza(PizzaDTO dadosPizza)
		{
			ConectarAccess();

			int id_Pizza;
			string comando = "SELECT Id_Pizza FROM Pizzas WHERE Nome_Sabor = @Nome_Sabor";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			cmd.Parameters.Add("@Nome_Sabor", OleDbType.VarChar).Value = dadosPizza.Nome_Sabor;

			try
			{
				return id_Pizza = (int)cmd.ExecuteScalar();
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

		internal bool PizzaCadastrada(string nome_Sabor)
		{
			ConectarAccess();

			string result = "";
			string comando = "SELECT Nome_Sabor FROM Pizzas WHERE Nome_Sabor = @Nome_Sabor";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			cmd.Parameters.Add("@Nome_Sabor", OleDbType.VarChar).Value = nome_Sabor;

			try
			{
				result = (string)cmd.ExecuteScalar();
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

			if (result == string.Empty || result == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		internal double AlterarTextBoxConformeCombo(string nome_Sabor)
		{
			ConectarAccess();

			string comando = "SELECT Preco FROM Pizzas WHERE Nome_Sabor = @Nome_Sabor";

			OleDbCommand cmd = new OleDbCommand(comando, conn);
			cmd.Parameters.Add("@Nome_Sabor", OleDbType.VarChar).Value = nome_Sabor;

			try
			{
				var result = cmd.ExecuteScalar();
				double preco = double.Parse(result.ToString());
				return preco;
			}
			catch (Exception E)
			{
				MessageBox.Show(E.Message);
				return 0;
			}
			finally
			{
				if (conn.State == ConnectionState.Open) conn.Close();
				if (conn != null) conn.Dispose();
			}
		}

		internal DataTable BuscarTodasPizzas()
		{
			ConectarAccess();

			DataTable dt = new DataTable();
			string comando = "SELECT * FROM Pizzas";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			try
			{
				dt.Load(cmd.ExecuteReader());

				var rw = dt.NewRow();  
				rw[1] = "";                  
				dt.Rows.InsertAt(rw, 0);
				return dt;
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

        internal void ExcluirPizza(int id_Pizza)
        {
            ConectarAccess();

            string comando = "Delete FROM Pizzas where Id_Pizza = @Id_Pizza";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            cmd.Parameters.Add("@Id_Pizza", OleDbType.Integer).Value = id_Pizza;         

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pizza Excluída com Sucesso!");
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
        }

        internal void DeletarNpraNPizzaIngrediente(int id_Pizza)
        {
            ConectarAccess();
            string comando = "Delete FROM Pizza_has_Ingredientes where Id_Pizza = @Id_Pizza";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            cmd.Parameters.Add("@Id_Pizza", OleDbType.Integer).Value = id_Pizza;

            try
            {
                cmd.ExecuteNonQuery();
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
        }

        internal List<PizzaDTO> TodasPizzas()
        {
            ConectarAccess();

            List<PizzaDTO> pizzaList = new List<PizzaDTO>();
            string comando = "SELECT * FROM Pizzas";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            try
            {
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PizzaDTO pizza = new PizzaDTO();
                    pizza.Id_Pizza = Convert.ToInt32(reader["Id_Pizza"]);
                    pizza.Nome_Sabor = reader["Nome_Sabor"].ToString();
                    pizza.Preco = Convert.ToDouble(reader["Preco"]);

                    pizzaList.Add(pizza);
                }
                return pizzaList;
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

        internal void Cadastrar(PizzaDTO dadosPizza)
		{
			ConectarAccess();

			string comando = "INSERT INTO Pizzas (Nome_Sabor, Preco)" +
									"values(@Nome_Sabor, @Preco)";

			OleDbCommand cmd = new OleDbCommand(comando, conn);

			cmd.Parameters.Add("@Nome_Sabor", OleDbType.VarChar).Value = dadosPizza.Nome_Sabor;
			string preco = dadosPizza.Preco.ToString();
			string aux = preco.Substring(0, 2);
			string aux2 = preco.Substring(2, 2);
			preco = aux + "," + aux2;
			cmd.Parameters.Add("@Preco", OleDbType.Currency).Value = preco;

			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Pizza Cadastrada com Sucesso!");
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
		}



	}
}
