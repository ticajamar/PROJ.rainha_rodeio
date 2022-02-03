using Microsoft.Data.SqlClient;
using rainha_rodeio.DTO;
using rainha_rodeio.Models;
using rainha_rodeio.SQL;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using rainha_rodeio.Data;

namespace rainha_rodeio.Services
{
    public class HomeServices
    {
        public HomeServices()
        {
            BaseSQL.RegisterDatabaseInfo("172.16.0.4", "AmberCute", "ambercute", "#CXk8nsw@r");
        }

        #region Consultas TipoCabelo
        public IList<TipoCabeloDTO> GetTipoCabelo()
        {
            IList<TipoCabeloDTO> listModel = new List<TipoCabeloDTO>();
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM TipoCabelo");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        TipoCabeloDTO model = new TipoCabeloDTO();

                        model.Id = Convert.ToInt32(oReader["Id"]);
                        model.Nome = oReader.GetString("Nome");
                        
                        listModel.Add(model);
                    }
                }
                myConnection.Close();
            }
            return listModel;
        }
        public IList<TipoComprimentoCabeloDTO> GetTipoComprimentoCabelo()
        {
            IList<TipoComprimentoCabeloDTO> listModel = new List<TipoComprimentoCabeloDTO>();
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM TipoComprimentoCabelo");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        TipoComprimentoCabeloDTO model = new TipoComprimentoCabeloDTO();

                        model.Id = Convert.ToInt32(oReader["Id"]);
                        model.Nome = oReader.GetString("Nome");

                        listModel.Add(model);
                    }
                }
                myConnection.Close();
            }
            return listModel;
        }
        public IList<TipoCorCabeloDTO> GetTipoCorCabelo()
        {
            IList<TipoCorCabeloDTO> listModel = new List<TipoCorCabeloDTO>();
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM TipoCorCabelo");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        TipoCorCabeloDTO model = new TipoCorCabeloDTO();

                        model.Id = Convert.ToInt32(oReader["Id"]);
                        model.Nome = oReader.GetString("Nome");

                        listModel.Add(model);
                    }
                }
                myConnection.Close();
            }
            return listModel;
        }
        #endregion
        #region Consulta Escolaridade
        public IList<EscolaridadeDTO> GetEscolaridade()
        {
            IList<EscolaridadeDTO> listModel = new List<EscolaridadeDTO>();
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM Escolaridade");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        EscolaridadeDTO model = new EscolaridadeDTO();

                        model.Id = Convert.ToInt32(oReader["Id"]);
                        model.Nome = oReader.GetString("Nome");

                        listModel.Add(model);
                    }
                }
                myConnection.Close();
            }
            return listModel;
        }
        #endregion
        #region Consultas Peles e Olhos
        public IList<TipoCorPeleDTO> GetTipoCorPele()
        {
            IList<TipoCorPeleDTO> listModel = new List<TipoCorPeleDTO>();
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM TipoCorPele");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        TipoCorPeleDTO model = new TipoCorPeleDTO();

                        model.Id = Convert.ToInt32(oReader["Id"]);
                        model.Nome = oReader.GetString("Nome");

                        listModel.Add(model);
                    }
                }
                myConnection.Close();
            }
            return listModel;
        }
        public IList<TipoCorOlhoDTO> GetTipoCorOlho()
        {
            IList<TipoCorOlhoDTO> listModel = new List<TipoCorOlhoDTO>();
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM TipoCorOlho");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        TipoCorOlhoDTO model = new TipoCorOlhoDTO();

                        model.Id = Convert.ToInt32(oReader["Id"]);
                        model.Nome = oReader.GetString("Nome");

                        listModel.Add(model);
                    }
                }
                myConnection.Close();
            }
            return listModel;
        }
        #endregion


        #region Salvar
        public void Insert(ModeloDTO model)
        {
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("INSERT INTO [dbo].[Modelo]([Nome],[Cpf],[Rg],[DataNascimento],[Celular],[Email],[Endereco],[EnderecoNumero],[Bairro],[Cep],[IdCidade],[DataInclusao],[DataUltimaAlteracao],");
                query.AppendLine("[Ativo],[Foto],[Observacao],[IdEscolaridade],[CaminhoFoto],[Peso],[IdTipoCorOlho],[IdTipoCorPele],[Manequim],[NumeroCalcado],[NumeroChapeu],[IdTipoComprimentoCabelo],");
                query.AppendLine("[IdTipoCorCabelo],[MedidaBusto],[MedidaCintura],[MedidaQuadril])");
                query.AppendLine("VALUES (@NOME,@RG,@DATANASCIMENTO,@CELULAR,@EMAIL,@ENDERECO,@BAIRRO,@CEP,@IDESCOLARIDADE,@PESO,@IDTIPOCOROLHO,@IDTIPOCORPELE,@MANEQUIM,@NUMEROCALCADO,@NUMEROCHAPEU,");
                query.AppendLine("VALUES (@IDTIPOCOMPRIMENTOCABELO,@IDTIPOCORCABELO,@MEDIDABUSTO,@MEDIDACINTURA,@MEDIDAQUADRIL)");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);
                command.CommandType = CommandType.Text;

                AddParameters(command, model);

                int rowAffected = command.ExecuteNonQuery();

                myConnection.Close();
            }
        }

        private void AddParameters(SqlCommand command, ModeloDTO model)
        {
            command.Parameters.Add("@NOME", SqlDbType.NVarChar);
            command.Parameters["@NOME"].Value = model.Nome;

            command.Parameters.Add("@RG", SqlDbType.Int);
            command.Parameters["@RG"].Value = model.Rg;

            command.Parameters.Add("@DATANASCIMENTO", SqlDbType.Date);
            command.Parameters["@DATANASCIMENTO"].Value = model.DataNascimento;

            command.Parameters.Add("@CELULAR", SqlDbType.Int);
            command.Parameters["@CELULAR"].Value = model.Celular;

            command.Parameters.Add("@EMAIL", SqlDbType.NVarChar);
            command.Parameters["@EMAIL"].Value = model.Email;

            command.Parameters.Add("@ENDERECO", SqlDbType.NVarChar);
            command.Parameters["@ENDERECO"].Value = model.Endereco;

            command.Parameters.Add("@BAIRRO", SqlDbType.NVarChar);
            command.Parameters["@BAIRRO"].Value = model.Bairro;

            command.Parameters.Add("@CEP", SqlDbType.Int);
            command.Parameters["@CEP"].Value = model.Cep;

            command.Parameters.Add("@IDESCOLARIDADE", SqlDbType.Int);
            command.Parameters["@IDESCOLARIDADE"].Value = model.IdEscolaridade;

            command.Parameters.Add("@PESO", SqlDbType.Int);
            command.Parameters["@PESO"].Value = model.Peso;

            command.Parameters.Add("@IDTIPOCOROLHO", SqlDbType.Int);
            command.Parameters["@IDTIPOCOROLHO"].Value = model.IdTipoCorOlho;

            command.Parameters.Add("@IDTIPOCORPELE", SqlDbType.Int);
            command.Parameters["@IDTIPOCORPELE"].Value = model.IdTipoCorPele;

            command.Parameters.Add("@MANEQUIM", SqlDbType.Int);
            command.Parameters["@MANEQUIM"].Value = model.Manequim;

            command.Parameters.Add("@NUMEROCALCADO", SqlDbType.Int);
            command.Parameters["@NUMEROCALCADO"].Value = model.NumeroCalcado;

            command.Parameters.Add("@NUMEROCHAPEU", SqlDbType.Int);
            command.Parameters["@NUMEROCHAPEU"].Value = model.NumeroChapeu;

            command.Parameters.Add("@IDTIPOCOMPRIMENTOCABELO", SqlDbType.Int);
            command.Parameters["@IDTIPOCOMPRIMENTOCABELO"].Value = model.IdTipoComprimentoCabelo;

            command.Parameters.Add("@IDTIPOCORCABELO", SqlDbType.Int);
            command.Parameters["@IDTIPOCORCABELO"].Value = model.IdTipoCorCabelo;

            command.Parameters.Add("@MEDIDABUSTO", SqlDbType.Int);
            command.Parameters["@MEDIDABUSTO"].Value = model.MedidaBusto;

            command.Parameters.Add("@MEDIDACINTURA", SqlDbType.Int);
            command.Parameters["@MEDIDACINTURA"].Value = model.MedidaCintura;

            command.Parameters.Add("@MEDIDAQUADRIL", SqlDbType.Int);
            command.Parameters["@MEDIDAQUADRIL"].Value = model.MedidaQuadril;
        }
        #endregion
    }
}
