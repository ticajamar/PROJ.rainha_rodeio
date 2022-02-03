using Microsoft.Data.SqlClient;
using System;

namespace rainha_rodeio.SQL
{
    public class BaseSQL
    {
        protected static string _bancoSQL;
        protected static string _usuarioSQL;
        protected static string _senhaSQL;
        protected static string _servidorSQL;
        public BaseSQL()
        {

        }

        public static void RegisterDatabaseInfo(string servidor, string banco, string usuario, string senha)
        {

            if (string.IsNullOrEmpty(servidor))
                throw new ArgumentNullException("Servidor de banco de dados não informado.");

            if (string.IsNullOrEmpty(banco))
                throw new ArgumentNullException("Nome do banco de dados não informado.");

            if (string.IsNullOrEmpty(usuario))
                throw new ArgumentNullException("Usuário de banco de dados não informado.");

            if (string.IsNullOrEmpty(senha))
                throw new ArgumentNullException("Senha do banco de dados não informado.");

            _bancoSQL = banco;
            _usuarioSQL = usuario;
            _senhaSQL = senha;
            _servidorSQL = servidor;
        }

        private string GetSQLServerStringConnection()
        {
            if (string.IsNullOrEmpty(_bancoSQL) || string.IsNullOrEmpty(_usuarioSQL)
                || string.IsNullOrEmpty(_senhaSQL) || string.IsNullOrEmpty(_servidorSQL))
                throw new Exception("Informações do banco de dados não registrado.");

            return CreateSQLServerStringConnection(_servidorSQL, _bancoSQL, _usuarioSQL, _senhaSQL);
        }

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(this.GetSQLServerStringConnection());
        }

        //public MySqlConnection GetMySqlConnection()
        //{
        //    return new MySqlConnection(this.());
        //}

        private string CreateSQLServerStringConnection(string servidor, string banco, string usuario, string senha)
        {
            return string.Format("Password={0};Persist Security Info=True;User ID={1};Initial Catalog={2};Data Source={3};Connection Timeout=5", senha, usuario, banco, servidor);
        }
    }
}
