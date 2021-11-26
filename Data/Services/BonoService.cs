using Dapper;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using CititorServer.Data.Model;
using CititorServer.Data.Service;
using System;

using System.Collections.Generic;

namespace CititorServer.Data.Service
{
    public class BonoService:IBonoService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;

        
        public BonoService(SqlConnectionConfiguration configuration)
        {

            _configuration = configuration;

        }
        
        public async Task<IEnumerable<Bono>> AllBonoGet()
        {   
            IEnumerable<Bono> bono;
            await using (var conn = new MySqlConnection(_configuration.Value))
            {
                conn.Open();
                const string query = @"SELECT * FROM bonos";
                if(conn.State == ConnectionState.Closed){
                    conn.Open();
                }
                try
                {
                    bono= await conn.QueryAsync<Bono>(query);
                    
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
            return bono;
        }
        public async Task<Bono> bonoGet(String co_alpha)
        {   
            Bono bono =new Bono();
            await using (var conn = new MySqlConnection(_configuration.Value))
            {
                conn.Open();
                const string query = @"SELECT * FROM bonos WHERE co_alpha=?co_alpha ";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?co_alpha", co_alpha);
                 using (var reader = await command.ExecuteReaderAsync())
                   
                
                    while ( await reader.ReadAsync())
                    {

                        
                       
                        
                            bono.idBono = reader.GetFieldValue<int>(0);
                            bono.co_alpha = reader.GetFieldValue<string>(1);
                            bono.porcentaje= reader.GetFieldValue<double>(2);
                        

                    }
               
                
            }
            return bono;
        }
        
    }
}
