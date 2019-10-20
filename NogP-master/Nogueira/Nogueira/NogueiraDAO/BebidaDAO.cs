﻿using System;
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
    public class BebidaDAO
    {
        OleDbConnection conn;

        public void ConectarAccess()
        {
            Conexao con = new Conexao();
            conn = con.ConectarAccess(ref conn);
        }

        internal void Cadastrar(BebidaDTO dadosBebida)
        {
            ConectarAccess();

            string comando = "INSERT INTO Bebidas (Descricao, Preco)" +
                                    "values(@Descricao, @Preco)";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            cmd.Parameters.Add("@Descricao", OleDbType.VarChar).Value = dadosBebida.DescricaoBebida;
            cmd.Parameters.Add("@Preco", OleDbType.VarChar).Value = dadosBebida.Preco;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bebida Cadastrado com Sucesso!");
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

        internal double AlterarTextBoxConformeCombo(string bebidaSelecionada)
        {

            ConectarAccess();

            string comando = "SELECT Preco FROM Bebidas WHERE Descricao = @Descricao";

            OleDbCommand cmd = new OleDbCommand(comando, conn);
            cmd.Parameters.Add("@Descricao", OleDbType.VarChar).Value = bebidaSelecionada;

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

        internal void AtualizarBebida(BebidaDTO dadosBebida)
        {
            ConectarAccess();

            string comando = "UPDATE Bebidas SET Descricao = @Descricao, Preco = @Preco " +
                                    "WHERE Id_Bebida = @Id_Bebida";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            cmd.Parameters.Add("@Descricao", OleDbType.VarChar).Value = dadosBebida.DescricaoBebida;
            cmd.Parameters.Add("@Preco", OleDbType.Currency).Value = dadosBebida.Preco;
            cmd.Parameters.Add("@Id_Bebida", OleDbType.VarChar).Value = dadosBebida.IdBebida;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bebida Atualizada com Sucesso!");
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

        internal void ExcluirBebida(int idBebida)
        {
            ConectarAccess();

            string comando = "Delete FROM Bebidas where Id_Bebida= @Id_Bebida";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            cmd.Parameters.Add("@Id_Bebida", OleDbType.Integer).Value = idBebida;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bebida Excluída com Sucesso!");
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

        internal DataTable BuscarTodasBebidas()
        {
            ConectarAccess();

            DataTable dt = new DataTable();
            string comando = "SELECT * FROM Bebidas";

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

        internal List<BebidaDTO> TodasBebidas()
        {
            ConectarAccess();

            List<BebidaDTO> bebidaList = new List<BebidaDTO>();
            string comando = "SELECT * FROM Bebidas";

            OleDbCommand cmd = new OleDbCommand(comando, conn);

            try
            {
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    BebidaDTO bebida = new BebidaDTO();
                    bebida.IdBebida = Convert.ToInt32(reader["Id_Bebida"]);
                    bebida.DescricaoBebida = reader["Descricao"].ToString();
                    bebida.Preco = Convert.ToDouble(reader["Preco"]);

                    bebidaList.Add(bebida);
                }
                return bebidaList;
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
    }
}
