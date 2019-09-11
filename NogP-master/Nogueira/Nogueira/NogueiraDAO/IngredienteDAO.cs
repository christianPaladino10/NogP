using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nogueira.NogueiraDTO;

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

        internal List<IngredienteDTO> BuscarIngredientes(List<int> listaIdsPizzas)
        {
            ConectarAccess();
            List<IngredienteDTO> listaIngredientes = new List<IngredienteDTO>();

            foreach (var item in listaIdsPizzas)
            {
                try
                {
                    string comando = "SELECT * from Ingredientes where Id_Ingrediente = @Id_Ingrediente";
                    OleDbCommand cmd = new OleDbCommand(comando, conn);

                    cmd.Parameters.Add("@Id_Ingrediente", OleDbType.VarChar).Value = item;
                    var r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        IngredienteDTO ingrediente = new IngredienteDTO();

                        ingrediente.Id_Ingrediente = Convert.ToInt32(r["Id_Ingrediente"]);
                        ingrediente.Nome_Ingrediente = r["Nome_Ingrediente"].ToString();

                        listaIngredientes.Add(ingrediente);
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    return null;
                }
            }

            if (conn.State == ConnectionState.Open) conn.Close();
            if (conn != null) conn.Dispose();

            return listaIngredientes;

        }

        internal List<int> BuscarIDIngredientesDaPizzaSelecionada(PizzaDTO pizzaSelecionada)
        {
            ConectarAccess();

            string comando = "SELECT * from Pizzas inner join Pizza_has_Ingredientes " +
                "on Pizza_has_Ingredientes.Id_Pizza = Pizzas.Id_Pizza where  Pizzas.Id_Pizza = @Id_Pizza";

            OleDbCommand cmd = new OleDbCommand(comando, conn);
            List<int> idsIngredientes = new List<int>();
            cmd.Parameters.Add("@Id_Pizza", OleDbType.VarChar).Value = pizzaSelecionada.Id_Pizza;

            try
            {
                var reader = cmd.ExecuteReader();
                cmd.Dispose();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id_Ingrediente"]);
                    idsIngredientes.Add(id);
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return null;
            }

            if (conn.State == ConnectionState.Open) conn.Close();
            if (conn != null) conn.Dispose();

            return idsIngredientes;
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

        internal void DeletarIngredientesPizza(int idPizza)
        {
            ConectarAccess();

            string comando = "DELETE FROM Pizza_has_Ingredientes " +
                                "WHERE Id_Pizza = @Id_Pizza";

            OleDbCommand cmd = new OleDbCommand(comando, conn);
            cmd.Parameters.Add("@Id_Pizza", OleDbType.VarChar).Value = idPizza;

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

    }
}
