using Dapper;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using CititorServer.Data.Model;

using System;

using System.Collections.Generic;

namespace CititorServer.Data.Service
{
    public class ListdeService:IListdeService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;

        
        public ListdeService(SqlConnectionConfiguration configuration)
        {

            _configuration = configuration;

        }
        public async Task<bool> ListdeInsert(Listde listde)
        {
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("id", listde.id,DbType.Int32);
                parameters.Add("idArticulo", listde.idArticulo,DbType.Int32);
                parameters.Add("cantArticulo", listde.cantArticulo, DbType.Int32);
                parameters.Add("subtotal", listde.subtotal, DbType.Int32);
                parameters.Add("idDiseño", listde.idDiseño, DbType.String);

                const string query = @"INSERT INTO `lista_deseos`(`id`, `idArticulo`, `cantArticulo`, `subtotal`, `idDiseño`) VALUES (@id,@idArticulo,@cantArticulo,@subtotal,@idDiseño)";
                await conn.ExecuteAsync(query, new { listde.id, listde.idArticulo, listde.cantArticulo, listde.subtotal,listde.idDiseño}, commandType: CommandType.Text);
            }
            return true;
        }
        
        public async Task<bool> ListdeUpdate(Listde listde)
        {
               
        Console.WriteLine(listde.id+""+listde.idArticulo+"-------");
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                 parameters.Add("id", listde.id,DbType.Int32);
                 parameters.Add("idArticulo", listde.idArticulo,DbType.String);
                parameters.Add("idDiseño", listde.idDiseño, DbType.String);
                parameters.Add("subtotal", listde.subtotal, DbType.DateTime);
                parameters.Add("cantArticulo", listde.cantArticulo, DbType.String);
              
                const string query = @"UPDATE `lista_deseos` SET `id`=@id,`idArticulo`=@idArticulo,`cantArticulo`=@cantArticulo,`subtotal`=@subtotal,`idDiseño`=@idDiseño WHERE id=@id";
                await conn.ExecuteAsync(query, new { listde.id,listde.idArticulo, listde.cantArticulo, 
                listde.subtotal, listde.idDiseño }, commandType: 
                CommandType.Text);
            }
        return true;
        }
         public async Task<bool> ListdeUpdateDesign(int idArticulo, int idDiseño)
        {
            
            Console.WriteLine("AQUI "+ idArticulo + idDiseño);
    
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                
                parameters.Add("idArticulo", idArticulo,DbType.String);
                parameters.Add("idDiseño", idDiseño, DbType.String);
              
              
                const string query = @"UPDATE `lista_deseos` SET `idDiseño`=@idDiseño WHERE idArticulo=@idArticulo";
                await conn.ExecuteAsync(query, new { idArticulo,idDiseño}, commandType: 
                CommandType.Text);
            }
        return true;
        }
       public async Task<Listde> ListdeGet(int idListde)
        {
            Listde listde=new Listde();
            await using (var conn = new MySqlConnection(_configuration.Value))
            {
                conn.Open();
                const string query = @"SELECT * FROM lista_deseos WHERE id= ?idListde";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?id", idListde);

                using (var reader = await command.ExecuteReaderAsync())


                    while ( await reader.ReadAsync())
                    {

                            listde.id = reader.GetFieldValue<int>(0);
                            listde.idArticulo = reader.GetFieldValue<int>(1);
                            listde.cantArticulo= reader.GetFieldValue<int>(2);
                            listde.subtotal = reader.GetFieldValue<int>(3);
                            listde.idDiseño = reader.GetFieldValue<int>(4);


                    }

            }
            return listde;
        }
        public async Task<IEnumerable<Listde>> AllListdeGet()
        {
            IEnumerable<Listde> listde;
            await using (var conn = new MySqlConnection(_configuration.Value))
            {
                conn.Open();
                const string query = @"SELECT * FROM lista_deseos";
                if(conn.State == ConnectionState.Closed){
                    conn.Open();
                }
                try
                {
                    listde= await conn.QueryAsync<Listde>(query);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally{
                    if(conn.State== ConnectionState.Open){
                        conn.Close();
                    }
                }



            }
            return listde;
        }
        public async Task<IEnumerable<Article>> AllArticleListDe()
        {
            IEnumerable<Article> articles;
            await using (var conn = new MySqlConnection(_configuration.Value))
            {
                conn.Open();
                const string query = @"SELECT A.* FROM articulo A JOIN lista_deseos LD ON LD.idArticulo=A.idArticulo";
                if(conn.State == ConnectionState.Closed){
                    conn.Open();
                }
                try
                {
                    articles= await conn.QueryAsync<Article>(query);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally{
                    if(conn.State== ConnectionState.Open){
                        conn.Close();
                    }
                }



            }
            return articles;
        }
    }
}
