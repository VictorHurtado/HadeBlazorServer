using Dapper;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using CititorServer.Data.Model;
using CititorServer.Data.Service;
using System;

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
                parameters.Add("imagenDiseño", design.imagenDiseño, DbType.String);
                parameters.Add("fechaCarga", design.fechaCarga, DbType.String);
                parameters.Add("Tamaño", design.Tamaño, DbType.String);
                const string query = @"INSERT INTO diseños (idDiseño, imagenDiseño, fechaCarga, Tamaño) 
                VALUES (@idDiseño, @imagenDiseño, @fechaCarga,@Tamaño)";
                await conn.ExecuteAsync(query, new { design.idDiseño, design.imagenDiseño, 
                design.fechaCarga,design.Tamaño }, commandType: CommandType.Text);
            }
        return true;
        }
        
        public async Task<bool> DesignUpdate(Design design)
        {
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                 parameters.Add("idDiseño", design.idDiseño,DbType.Int32);
                parameters.Add("imagenDiseño", design.imagenDiseño, DbType.String);
                parameters.Add("fechaCarga", design.fechaCarga, DbType.String);
                parameters.Add("Tamaño", design.Tamaño, DbType.String);
                const string query = @"UPDATE diseños 
                SET idDiseño = @idDiseño, 
                imagenDiseño = @imagenDiseño,
                fechaCarga = @fechaCarga,
                Tamaño = @Tamaño
                WHERE idDiseño = @idDiseño";
                await conn.ExecuteAsync(query, new { design.idDiseño, design.imagenDiseño, 
                design.fechaCarga, design.Tamaño }, commandType: 
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
                            design.fechaCarga = reader.GetFieldValue<string>(2);
                            design.Tamaño = reader.GetFieldValue<string>(3);

                    }
                
            }
            return design;
        }
    }
}
