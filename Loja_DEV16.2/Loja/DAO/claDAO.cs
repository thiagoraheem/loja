using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Loja.DAO
{
    class claDatabase
    {
        String sConexao = "Data Source=(local);Initial Catalog=Loja;Integrated Security=True";
        SqlConnection connection;

        public claDatabase()
        {
            try
            {
                /*SqlConnection*/
                connection = new SqlConnection();

                connection.ConnectionString = sConexao;
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }

        public System.Data.ConnectionState State()
        {
            return connection.State;
        }

        public long ExecuteNonQuery(String sql, int iTimeOut = 30)
        {
            try
            {

                long lRegistrosAfetados = 0;
                SqlCommand oCMD = new SqlCommand();
                oCMD = connection.CreateCommand();
                oCMD.CommandText = sql;
                oCMD.CommandTimeout = iTimeOut;
                lRegistrosAfetados = oCMD.ExecuteNonQuery();

                return lRegistrosAfetados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public SqlDataReader ExecuteReader(String sql, int iTimeOut = 30)
        {

            SqlCommand oCMD;
            SqlDataReader oDR;

            oDR = null;

            try
            {
                oCMD = connection.CreateCommand();
                oCMD.CommandText = sql;
                oCMD.CommandTimeout = iTimeOut;
                oDR = oCMD.ExecuteReader();

                return oDR;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public SqlDataReader ExecuteReader(String sql, SqlParameter[] parametros, System.Data.CommandType tipo = System.Data.CommandType.Text, int iTimeOut = 30)
        {
            try
            {

                SqlCommand oCMD = new SqlCommand();
                oCMD = connection.CreateCommand();
                oCMD.CommandText = sql;
                oCMD.CommandTimeout = iTimeOut;
                oCMD.CommandType = tipo;
                oCMD.Parameters.AddRange(parametros);

                SqlDataReader oDR;
                oDR = oCMD.ExecuteReader();

                return oDR;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }

    class claAcesso {
        #region Produtos
        public static List<claProdutos> FU_PegarProdutos() {
            claDatabase oDB = new claDatabase();
            List<claProdutos> produtos = new List<claProdutos>();
            SqlDataReader oDR;

            try
            {
                oDR = oDB.ExecuteReader("SELECT * FROM tbl_Produtos");

                while (oDR.Read())
                {
                    claProdutos prod = new claProdutos();

                    prod.Codproduto = oDR["CodProduto"].ToString();
                    prod.Desproduto = oDR["DesProduto"].ToString();
                    prod.Deslocal = oDR["DesLocal"].ToString();
                    prod.Vlrunitario = (oDR["VlrUnitario"] != DBNull.Value) ? (Nullable<double>)oDR["VlrUnitario"] : null;
                    prod.Qtdproduto = (oDR["QtdProduto"] != DBNull.Value) ? (Nullable<double>)oDR["QtdProduto"] : null;
                    prod.Vlrcusto = (oDR["VlrCusto"] != DBNull.Value) ? (Nullable<double>)oDR["VlrCusto"] : null;
                    prod.Vlrpercent = (oDR["VlrPercent"] != DBNull.Value) ? (Nullable<double>)oDR["VlrPercent"] : null;
                    prod.Estminimo = (oDR["EstMinimo"] != DBNull.Value) ? (Nullable<double>)oDR["EstMinimo"] : null;
                    prod.DatCadastro = oDR["DatCadastro"].ToString();
                    prod.Desfornecedor = oDR["DesFornecedor"].ToString();
                    prod.Codrefantiga = oDR["CodRefAntiga"].ToString();
                    prod.Desfaz = (oDR["DesFaz"] != DBNull.Value) ? (Nullable<double>)oDR["DesFaz"] : null;
                    prod.Vlrultpreco = (oDR["VlrUltPreco"] != DBNull.Value) ? (Nullable<double>)oDR["VlrUltPreco"] : null;
                    prod.Imagem = oDR["Imagem"];

                    produtos.Add(prod);

                    prod = null;
                }

                return produtos;

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao carregar os dados: " + ex.Message);
            }
            finally
            {
                oDB.Close();
            }
        }

        public static double FU_PegaTotalItens(List<claProdutos> produtos) {

            double qtdItens = 0;
            try {

                foreach (claProdutos produto in produtos) {
                    qtdItens += (produto.Qtdproduto == null) ? 0 : (double) produto.Qtdproduto;
                }

            }
            catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }

            return qtdItens;
        }
        #endregion

        #region Orcamento
        public static String FU_IncluirOrcamento(String CodOrcamento, String CodProduto)
        {
            claDatabase oDB = new claDatabase();

            SqlDataReader oDR;
            String retorno = "";

            try
            {
                SqlParameter[] parametros = {
					new SqlParameter("CodOrca", SqlDbType.VarChar),
					new SqlParameter("CodProduto", SqlDbType.VarChar),
				};
                parametros[0].Value = CodOrcamento;
                parametros[1].Value = CodProduto;

                oDR = oDB.ExecuteReader("spc_AdicionarOrcamento", parametros, CommandType.StoredProcedure);

                if (oDR.Read()) {
                    retorno = oDR[0].ToString(); 
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao carregar os dados: " + ex.Message);
            }
            finally
            {
                oDB.Close();
            }

            return retorno;
        }

        public static List<claOrcamento> FU_PegaOrcamento(String CodOrcamento) { 
            claDatabase oDB = new claDatabase();

            SqlDataReader oDR;

            List<claOrcamento> orcamentos = new List<claOrcamento>();

            try
            {
                SqlParameter[] parametros = {
					new SqlParameter("Orcamento", SqlDbType.VarChar)
				};
                parametros[0].Value = CodOrcamento;

                oDR = oDB.ExecuteReader("SELECT CodOrca, CodProduto, DatOrca, DesLocal, DescProduto, FlgStatus, PF, Quantidade, VlrCusto, VlrUnitario FROM tbl_Orcamento WHERE (CodOrca = @Orcamento)", parametros, CommandType.Text);

                while (oDR.Read())
                {
                    claOrcamento orcamento = new claOrcamento();

                    orcamento.CodOrca = oDR["CodOrca"].ToString();
                    orcamento.CodProduto = oDR["CodProduto"].ToString();
                    orcamento.DescProduto = oDR["DescProduto"].ToString();
                    orcamento.Quantidade = (oDR["Quantidade"] != DBNull.Value) ? (Nullable<double>)oDR["Quantidade"] : null;
                    orcamento.VlrUnitario = (oDR["VlrUnitario"] != DBNull.Value) ? (Nullable<double>)oDR["VlrUnitario"] : null;
                    orcamento.VlrCusto = (oDR["VlrCusto"] != DBNull.Value) ? (Nullable<double>)oDR["VlrCusto"] : null;
                    orcamento.DesLocal = oDR["DesLocal"].ToString();
                    orcamento.Pf = (oDR["PF"] != DBNull.Value) ? (Nullable<double>)oDR["PF"] : null;
                    orcamento.FlgStatus = oDR["FlgStatus"].ToString();
                    orcamento.DatOrca = (oDR["DatOrca"] != DBNull.Value) ? (Nullable<DateTime>)oDR["DatOrca"] : null;

                    orcamentos.Add(orcamento);

                    orcamento = null;
                }

                return orcamentos;

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao carregar os dados: " + ex.Message);
            }
            finally
            {
                oDB.Close();
            }
        }

        public static void SU_OrcAltQuantidade(String CodOrca, String CodProduto, Double Quantidade) {
            claDatabase oDB = new claDatabase();

            SqlDataReader oDR;

            try
            {

                if (Quantidade != 0)
                {
                    SqlParameter[] parametros = {
					    new SqlParameter("CodOrca", SqlDbType.VarChar),
					    new SqlParameter("CodProduto", SqlDbType.VarChar),
                        new SqlParameter("Quantidade", SqlDbType.Float)
				    };
                    parametros[0].Value = CodOrca;
                    parametros[1].Value = CodProduto;
                    parametros[2].Value = Quantidade;

                    oDR = oDB.ExecuteReader("UPDATE tbl_Orcamento SET Quantidade = @Quantidade, PF = VlrUnitario * @Quantidade WHERE CodOrca = @CodOrca AND CodProduto = @CodProduto", parametros, CommandType.Text);
                }
                else {
                    SqlParameter[] parametros2 = {
					    new SqlParameter("CodOrca", SqlDbType.VarChar),
					    new SqlParameter("CodProduto", SqlDbType.VarChar),
                        new SqlParameter("Quantidade", SqlDbType.Float)
				    };
                    parametros2[0].Value = CodOrca;
                    parametros2[1].Value = CodProduto;
                    parametros2[2].Value = Quantidade;
                    oDR = oDB.ExecuteReader("DELETE FROM tbl_Orcamento WHERE CodOrca = @CodOrca AND CodProduto = @CodProduto", parametros2, CommandType.Text);
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao executar ação: " + ex.Message);
            }
            finally
            {
                oDB.Close();
            }
          
        }

        public static void SU_OrcAltValor(String CodOrca, String CodProduto, Double VlrUnitario)
        {
            claDatabase oDB = new claDatabase();

            SqlDataReader oDR;

            try
            {
                SqlParameter[] parametros = {
					new SqlParameter("CodOrca", SqlDbType.VarChar),
					new SqlParameter("CodProduto", SqlDbType.VarChar),
                    new SqlParameter("VlrUnitario", SqlDbType.Float)
				};
                parametros[0].Value = CodOrca;
                parametros[1].Value = CodProduto;
                parametros[2].Value = VlrUnitario;

                oDR = oDB.ExecuteReader("UPDATE tbl_Orcamento SET VlrUnitario = @VlrUnitario, PF = @VlrUnitario * Quantidade WHERE CodOrca = @CodOrca AND CodProduto = @CodProduto", parametros, CommandType.Text);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao executar ação: " + ex.Message);
            }
            finally
            {
                oDB.Close();
            }

        }


        #endregion

        #region TipoVenda
        public static List<claTipoVenda> FU_PegarTipoVendas()
        {
            claDatabase oDB = new claDatabase();
            List<claTipoVenda> tipovenda = new List<claTipoVenda>();
            SqlDataReader oDR;

            try
            {
                oDR = oDB.ExecuteReader("SELECT * FROM tbl_TipoVenda");

                while (oDR.Read())
                {
                    claTipoVenda tipo = new claTipoVenda();

                    tipo.CodTipoVenda = (int)oDR["CodTipoVenda"];
                    tipo.DesTipoVenda = oDR["DesTipoVenda"].ToString();
                    tipo.flgAtivo = (Boolean)oDR["flgAtivo"];
                    tipo.flgAVista = (Boolean)oDR["flgAVista"];
                    tipo.QtdDias = (oDR["QtdDias"] != DBNull.Value) ? (Nullable<double>)oDR["QtdDias"] : null;

                    tipovenda.Add(tipo);

                    tipo = null;
                }

                return tipovenda;

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao carregar os dados: " + ex.Message);
            }
            finally
            {
                oDB.Close();
            }
        }
        #endregion
    }

}
