using Dapper;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using CititorServer.Data.Model;

namespace CititorServer.Data.Service
{
    public class ClienteService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public ClienteService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> ArticleInser(Article article)
        {
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("idArticulo", article.idArticulo,DbType.Int32);
                parameters.Add("DescripcionArticulo", article.DescripcionArticulo, DbType.String);
                parameters.Add("cantArticulosDispo", article.cantArticulosDispo, DbType.Int32);
                parameters.Add("valor", article.valor, DbType.Double);
                const string query = @"INSERT INTO articulo (idArticulo, DescripcionArticulo, cantArticulosDispo, valor) 
                VALUES (@idArticulo, @DescripcionArticulo, @cantArticulosDispo,@valor)";
                await conn.ExecuteAsync(query, new { article.idArticulo, article.DescripcionArticulo, 
                article.cantArticulosDispo,article.valor }, commandType: CommandType.Text);
            }
        return true;
        }
    }
}
