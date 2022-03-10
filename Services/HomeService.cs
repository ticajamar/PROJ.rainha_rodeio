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
using System.IO;
using Microsoft.AspNetCore.Http;

namespace rainha_rodeio.Services
{
    public class HomeService
    {
        public HomeService()
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
        public async Task Insert(ModeloDTO model)
        {
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("INSERT INTO [dbo].[Modelo]([Nome],[Endereco],[Bairro],[Cidade],[Cep],[UF],[Fone],[Celular],[Email],[Rg],[Cpf],[DataNascimento],[Idade]");
                query.AppendLine(",[IdEscolaridade],[Peso],[Altura],[IdTipoCorOlho],[IdTipoCorPele],[Manequim],[NumeroCalcado],[NumeroChapeu],[IdTipoComprimentoCabelo]");
                query.AppendLine(",[IdTipoCabelo],[IdTipoCorCabelo],[MedidaBusto],[MedidaCintura],[MedidaQuadril],[Foto],[CaminhoFoto],[DataInclusao])");

                query.AppendLine("VALUES(@NOME,@ENDERECO,@BAIRRO,@CIDADE,@CEP,@UF,@FONE,@CELULAR,@EMAIL,@RG,@CPF,@DATANASCIMENTO,@IDADE,@IDESCOLARIDADE,@PESO,@ALTURA");
                query.AppendLine(",@IDTIPOCOROLHO,@IDTIPOCORPELE,@MANEQUIM,@NUMEROCALCADO,@NUMEROCHAPEU,@IDTIPOCOMPRIMENTOCABELO,@IDTIPOCABELO,@IDTIPOCORCABELO,@MEDIDABUSTO");
                query.AppendLine(",@MEDIDACINTURA,@MEDIDAQUADRIL,@FOTO,@CAMINHOFOTO,GETDATE())");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);
                command.CommandType = CommandType.Text;

                AddParameters(command, model);

                int rowAffected = command.ExecuteNonQuery();

                myConnection.Close();
            }
        }

        private void AddParameters(SqlCommand command, ModeloDTO model)
        {
            command.Parameters.Add("@DATAINCLUSAO", SqlDbType.Date);
            command.Parameters["@DATAINCLUSAO"].Value = model.DataInclusao;

            command.Parameters.Add("@NOME", SqlDbType.NVarChar);
            command.Parameters["@NOME"].Value = model.Nome;

            command.Parameters.Add("@ENDERECO", SqlDbType.NVarChar);
            command.Parameters["@ENDERECO"].Value = model.Endereco;

            command.Parameters.Add("@BAIRRO", SqlDbType.NVarChar);
            command.Parameters["@BAIRRO"].Value = model.Bairro;

            command.Parameters.Add("@CIDADE", SqlDbType.NVarChar);
            command.Parameters["@CIDADE"].Value = model.Cidade;

            command.Parameters.Add("@CEP", SqlDbType.Int);
            command.Parameters["@CEP"].Value = model.Cep;

            command.Parameters.Add("@UF", SqlDbType.NVarChar);
            command.Parameters["@UF"].Value = model.UF;

            command.Parameters.Add("@FONE", SqlDbType.BigInt);
            command.Parameters["@FONE"].Value = model.Fone;

            command.Parameters.Add("@CELULAR", SqlDbType.NVarChar);
            command.Parameters["@CELULAR"].Value = model.Celular;

            command.Parameters.Add("@EMAIL", SqlDbType.NVarChar);
            command.Parameters["@EMAIL"].Value = model.Email;

            command.Parameters.Add("@RG", SqlDbType.NVarChar);
            command.Parameters["@RG"].Value = model.RG;

            command.Parameters.Add("@CPF", SqlDbType.NVarChar);
            command.Parameters["@CPF"].Value = model.CPF;

            command.Parameters.Add("@DATANASCIMENTO", SqlDbType.NVarChar);
            command.Parameters["@DATANASCIMENTO"].Value = model.DataNascimento;

            command.Parameters.Add("@IDADE", SqlDbType.Int);
            command.Parameters["@IDADE"].Value = model.Idade;

            command.Parameters.Add("@IDESCOLARIDADE", SqlDbType.Int);
            command.Parameters["@IDESCOLARIDADE"].Value = model.IdEscolaridade;

            command.Parameters.Add("@PESO", SqlDbType.Int);
            command.Parameters["@PESO"].Value = model.Peso;

            command.Parameters.Add("@ALTURA", SqlDbType.Int);
            command.Parameters["@ALTURA"].Value = model.Altura;

            command.Parameters.Add("@IDTIPOCOROLHO", SqlDbType.Int);
            command.Parameters["@IDTIPOCOROLHO"].Value = model.IdTipoCorOlho;

            command.Parameters.Add("@IDTIPOCORPELE", SqlDbType.Int);
            command.Parameters["@IDTIPOCORPELE"].Value = model.IdTipoCorPele;

            command.Parameters.Add("@MANEQUIM", SqlDbType.NVarChar);
            command.Parameters["@MANEQUIM"].Value = model.Manequim;

            command.Parameters.Add("@NUMEROCALCADO", SqlDbType.Int);
            command.Parameters["@NUMEROCALCADO"].Value = model.NumeroCalcado;

            command.Parameters.Add("@NUMEROCHAPEU", SqlDbType.Int);
            command.Parameters["@NUMEROCHAPEU"].Value = model.NumeroChapeu;

            command.Parameters.Add("@IDTIPOCOMPRIMENTOCABELO", SqlDbType.Int);
            command.Parameters["@IDTIPOCOMPRIMENTOCABELO"].Value = model.IdTipoComprimentoCabelo;

            command.Parameters.Add("@IDTIPOCABELO", SqlDbType.Int);
            command.Parameters["@IDTIPOCABELO"].Value = model.IdTipoCabelo;

            command.Parameters.Add("@IDTIPOCORCABELO", SqlDbType.Int);
            command.Parameters["@IDTIPOCORCABELO"].Value = model.IdTipoCorCabelo;

            command.Parameters.Add("@MEDIDABUSTO", SqlDbType.Int);
            command.Parameters["@MEDIDABUSTO"].Value = model.MedidaBusto;

            command.Parameters.Add("@MEDIDACINTURA", SqlDbType.Int);
            command.Parameters["@MEDIDACINTURA"].Value = model.MedidaCintura;

            command.Parameters.Add("@MEDIDAQUADRIL", SqlDbType.Int);
            command.Parameters["@MEDIDAQUADRIL"].Value = model.MedidaQuadril;

            command.Parameters.Add("@FOTO", SqlDbType.NVarChar);
            command.Parameters["@FOTO"].Value = model.Foto;

            command.Parameters.Add("@CAMINHOFOTO", SqlDbType.NVarChar);
            command.Parameters["@CAMINHOFOTO"].Value = model.CaminhoFoto;
        }
        #endregion
        #region Salvar Foto
        public string SaveFoto(string caminhoFoto, IFormFile file, string nomeArquivo)
        {
            string ext = Path.GetExtension(file.FileName);

            string fileName = nomeArquivo;

            string fullPath = Path.Combine(caminhoFoto, fileName);

            using (Stream fileStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
            {
                file.CopyTo(fileStream);
            }
            return fileName;
        }
        #endregion
        #region Verifica CPF

        public bool VerifyCpf(string cpf, string comando)
        {
            bool retorno = false;
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine(comando);

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);
                command.Parameters.Add("@CPF", SqlDbType.NVarChar);
                command.Parameters["@CPF"].Value = cpf;

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        retorno = true;
                        break;
                    }
                }
                myConnection.Close();
            }
            return retorno;
        }


        public bool CheckCpf(string cpf)
        {
            return VerifyCpf(cpf, "SELECT [CPF] FROM [AmberCute].[dbo].[Modelo] WHERE CPF = @CPF");
        }
        #endregion
        #region GetLastId
        public IList<ModeloDTO> GetLastId()
        {
            IList<ModeloDTO> listModel = new List<ModeloDTO>();
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT TOP 1 Id FROM Modelo ORDER BY Id DESC;");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        ModeloDTO model = new ModeloDTO();

                        model.Id = Convert.ToInt32(oReader["Id"]);
                        listModel.Add(model);
                    }
                }
                myConnection.Close();
            }
            return listModel;
        }
        #endregion
        #region Consultas Modelo
        public IList<ModeloModel> GetModeloGeral()
        {
            IList<ModeloModel> listModel = new List<ModeloModel>();
            using (var myConnection = new BaseSQL().GetSqlConnection())
            {
                myConnection.Open();
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT * FROM Modelo");

                SqlCommand command = new SqlCommand(query.ToString(), myConnection);

                using (SqlDataReader oReader = command.ExecuteReader())
                {
                    while (oReader.Read())
                    {

                        listModel.Add(Transform(oReader));
                    }
                }
                myConnection.Close();
            }
            return listModel;
        }

        private ModeloModel Transform(SqlDataReader oReader)
        {
            ModeloModel model = new ModeloModel();
            model.Id = Convert.ToInt32(oReader["Id"]);
            model.Nome = oReader.GetString("nome");
            model.Endereco = oReader.GetString("Endereco");
            model.Cidade = oReader.GetString("Cidade").ToString();
            model.Bairro = oReader.GetString("Bairro").ToString();
            model.Cep = Convert.ToInt32(oReader["Id"]);
            model.UF = oReader.GetString("UF").ToString();
            model.Fone = Convert.ToInt32(oReader["Id"]);
            model.Celular = oReader.GetString("Celular").ToString();
            model.Email = oReader.GetString("Email").ToString();
            model.RG = oReader.GetString("RG").ToString();
            model.CPF = oReader.GetString("CPF").ToString();
            model.DataNascimento = oReader.GetString("DataNascimento").ToString();
            model.Idade = Convert.ToInt32(oReader["Id"]);
            model.IdEscolaridade = Convert.ToInt32(oReader["Id"]);
            model.Peso = Convert.ToInt32(oReader["Id"]);
            model.Altura = Convert.ToInt32(oReader["Id"]);
            model.IdTipoCorOlho = Convert.ToInt32(oReader["Id"]);
            model.IdTipoCorPele = Convert.ToInt32(oReader["Id"]);
            model.Manequim = oReader.GetString("Manequim").ToString();
            model.NumeroCalcado = Convert.ToInt32(oReader["Id"]);
            model.NumeroChapeu = Convert.ToInt32(oReader["Id"]);
            model.IdTipoComprimentoCabelo = Convert.ToInt32(oReader["Id"]);
            model.IdTipoCabelo = Convert.ToInt32(oReader["Id"]);
            model.IdTipoCorCabelo = Convert.ToInt32(oReader["Id"]);
            model.MedidaBusto = Convert.ToInt32(oReader["Id"]);
            model.MedidaCintura = Convert.ToInt32(oReader["Id"]);
            model.MedidaQuadril = Convert.ToInt32(oReader["Id"]);
            model.CaminhoFoto = oReader.GetString("CaminhoFoto").ToString();
            model.Foto = oReader.GetString("Foto").ToString();

            return model;
        }
        #endregion
    }
}
