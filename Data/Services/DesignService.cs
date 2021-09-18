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
    public class DesignService:IDesignService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;

        
        public DesignService(SqlConnectionConfiguration configuration)
        {

            _configuration = configuration;

        }
        public async Task<bool> DesignInsert(Design design)
        {
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("idDiseño", design.idDiseño,DbType.Int32);
                parameters.Add("descripcion", design.descripcion,DbType.String);
                parameters.Add("imagenDiseño", design.imagenDiseño, DbType.String);
                parameters.Add("fechaCarga", design.fechaCarga, DbType.DateTime);
                parameters.Add("Tamaño", design.Tamaño, DbType.String);
                parameters.Add("status", design.status, DbType.Int32);
                const string query = @"INSERT INTO diseños (idDiseño,descripcion, imagenDiseño, fechaCarga, Tamaño,status) 
                VALUES (@idDiseño,@descripcion, @imagenDiseño, @fechaCarga,@Tamaño,@status)";
                await conn.ExecuteAsync(query, new { design.idDiseño, design.descripcion, design.imagenDiseño, 
                design.fechaCarga,design.Tamaño,design.status }, commandType: CommandType.Text);
            }
            return true;
        }
        
        public async Task<bool> DesignUpdate(Design design)
        {
               
        Console.WriteLine(design.idDiseño+""+design.status+"-------");
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                 parameters.Add("idDiseño", design.idDiseño,DbType.Int32);
                 parameters.Add("descripcion", design.descripcion,DbType.String);
                parameters.Add("imagenDiseño", design.imagenDiseño, DbType.String);
                parameters.Add("fechaCarga", design.fechaCarga, DbType.DateTime);
                parameters.Add("Tamaño", design.Tamaño, DbType.String);
                parameters.Add("status", design.status, DbType.Int32);
                const string query = @"UPDATE diseños 
                SET idDiseño = @idDiseño, 
                descripcion = @descripcion,
                imagenDiseño = @imagenDiseño,
                fechaCarga = @fechaCarga,
                Tamaño = @Tamaño,
                status=@status
                WHERE idDiseño = @idDiseño";
                await conn.ExecuteAsync(query, new { design.idDiseño,design.descripcion, design.imagenDiseño, 
                design.fechaCarga, design.Tamaño,design.status }, commandType: 
                CommandType.Text);
            }
        return true;
        }
        public async Task<Design> DesignGet(int idDiseño)
        {   
            Design design=new Design();
            await using (var conn = new MySqlConnection(_configuration.Value))
            {
                conn.Open();
                const string query = @"SELECT * FROM diseños WHERE idDiseño= ?idDiseño";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idDiseño", idDiseño);

                using (var reader = await command.ExecuteReaderAsync())
                   
                
                    while ( await reader.ReadAsync())
                    {

                        
                       
                        
                            design.idDiseño = reader.GetFieldValue<int>(0);
                            design.imagenDiseño = reader.GetFieldValue<string>(1);
                            design.descripcion= reader.GetFieldValue<string>(2);
                            design.fechaCarga = reader.GetFieldValue<DateTime>(3);
                            design.Tamaño = reader.GetFieldValue<string>(4);
                            design.status = reader.GetFieldValue<int>(5);

                    }
                
            }
            return design;
        }
        public async Task<IEnumerable<Design>> AllDesignsGet()
        {   
            IEnumerable<Design> designs;
            await using (var conn = new MySqlConnection(_configuration.Value))
            {
                conn.Open();
                const string query = @"SELECT * FROM diseños";
                if(conn.State == ConnectionState.Closed){
                    conn.Open();
                }
                try
                {
                    designs= await conn.QueryAsync<Design>(query);
                    
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
            return designs;
        }
    }
}
