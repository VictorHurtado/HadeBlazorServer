using Dapper;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using CititorServer.Data.Model;
using System;

namespace CititorServer.Data.Service
{
    public class ArticleService:IArticleService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;

        public ArticleService(SqlConnectionConfiguration configuration)
        {

            _configuration = configuration;

        }
        public async Task<bool> ArticleInsert(Article article)
        {
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("idArticulo", article.idArticulo,DbType.Int32);
                parameters.Add("descripcionArticulo", article.descripcionArticulo, DbType.String);
                parameters.Add("cantArticulosDispo", article.cantArticulosDispo, DbType.Int32);
                parameters.Add("valor", article.valor, DbType.Double);
                const string query = @"INSERT INTO articulo (idArticulo, DescripcionArticulo, cantArticulosDispo, valor) 
                VALUES (@idArticulo, @DescripcionArticulo, @cantArticulosDispo,@valor)";
                await conn.ExecuteAsync(query, new { article.idArticulo, article.descripcionArticulo, 
                article.cantArticulosDispo,article.valor }, commandType: CommandType.Text);
            }
        return true;
        }
        
        public async Task<bool> ArticleUpdate(Article article)
        {
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                 parameters.Add("idArticulo", article.idArticulo,DbType.Int32);
                parameters.Add("descripcionArticulo", article.descripcionArticulo, DbType.String);
                parameters.Add("cantArticulosDispo", article.cantArticulosDispo, DbType.Int32);
                parameters.Add("valor", article.valor, DbType.Double);
                const string query = @"UPDATE articulo 
                SET idArticulo = @idArticulo, 
                DescripcionArticulo = @descripcionArticulo,
                cantArticulosDispo = @cantArticulosDispo,
                valor = @valor
                WHERE idArticulo = @idArticulo";
                await conn.ExecuteAsync(query, new { article.idArticulo, article.descripcionArticulo, 
                article.cantArticulosDispo, article.valor }, commandType: 
                CommandType.Text);
            }
        return true;
        }
        public async Task<Article> ArticleGet(int idArticle)
        {   
            Article article=new Article();
            await using (var conn = new MySqlConnection(_configuration.Value))
            {
                conn.Open();
                const string query = @"SELECT * FROM articulo WHERE idArticulo= ?idArticle";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idArticle", idArticle);

                using (var reader = await command.ExecuteReaderAsync())
                   
                
                    while ( await reader.ReadAsync())
                    {

                        
                       
                        
                            article.idArticulo = reader.GetFieldValue<int>(0);
                            article.descripcionArticulo = reader.GetFieldValue<string>(1);
                            article.cantArticulosDispo = reader.GetFieldValue<int>(2);
                            article.valor = reader.GetFieldValue<int>(3);

                    }
                
            }
            return article;
        }
    }
}
