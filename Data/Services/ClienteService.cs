using Dapper;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using CititorServer.Data.Model;
using CititorServer.Data.Service;
using System;

namespace CititorServer.Data.Service
{
    public class ClienteService:IClienteService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;

        public ClienteService(SqlConnectionConfiguration configuration)
        {

            _configuration = configuration;

        }
        public async Task<bool> ClienteInsert(Cliente cliente)
        {
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("dnicliente", cliente.dnicliente,DbType.Int32);
                parameters.Add("nombreCliente", cliente.nombreCliente, DbType.String);
                parameters.Add("apellidoCliente", cliente.apellidoCliente, DbType.String);
                parameters.Add("correoCliente", cliente.correoCliente, DbType.String);
                parameters.Add("direccionCliente", cliente.direccionCliente, DbType.String);
                const string query = @"INSERT INTO cliente (dnicliente, nombreCliente, apellidoCliente, correoCliente, direccionCliente) 
                VALUES (@dnicliente, @nombreCliente, @apellidoCliente,@correoCliente,@direccionCliente)";
                await conn.ExecuteAsync(query, new { cliente.dnicliente, cliente.nombreCliente, 
                cliente.apellidoCliente,cliente.correoCliente,cliente.direccionCliente }, commandType: CommandType.Text);
            }
        return true;
        }
        
        public async Task<bool> ClienteUpdate(Cliente cliente)
        {
            using (var conn = new MySqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                 parameters.Add("dnicliente", cliente.dnicliente,DbType.Int32);
                parameters.Add("nombreCliente", cliente.nombreCliente, DbType.String);
                parameters.Add("apellidoCliente", cliente.apellidoCliente, DbType.String);
                parameters.Add("correoCliente", cliente.correoCliente, DbType.String);
                parameters.Add("direccionCliente", cliente.direccionCliente, DbType.String);
                const string query = @"UPDATE cliente 
                SET dnicliente = @dnicliente, 
                nombreCliente = @nombreCliente,
                apellidoCliente = @apellidoCliente,
                correoCliente = @correoCliente,
                direccionCliente = @direccionCliente
                WHERE dnicliente = @dnicliente";
                await conn.ExecuteAsync(query, new { cliente.dnicliente, cliente.nombreCliente, 
                cliente.apellidoCliente, cliente.correoCliente, cliente.direccionCliente }, commandType: 
                CommandType.Text);
            }
        return true;
        }
        public async Task<Cliente> ClienteGet(int dnicliente)
        {   
            Cliente cliente=new Cliente();
            await using (var conn = new MySqlConnection(_configuration.Value))
            {
                conn.Open();
                const string query = @"SELECT * FROM cliente WHERE dnicliente= ?dnicliente";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?dnicliente", dnicliente);

                using (var reader = await command.ExecuteReaderAsync())
                   
                
                    while ( await reader.ReadAsync())
                    {

                        
                       
                        
                            cliente.dnicliente = reader.GetFieldValue<int>(0);
                            cliente.nombreCliente = reader.GetFieldValue<string>(1);
                            cliente.apellidoCliente = reader.GetFieldValue<string>(2);
                            cliente.correoCliente = reader.GetFieldValue<string>(3);
                            cliente.direccionCliente = reader.GetFieldValue<string>(4);

                    }
                
            }
            return cliente;
        }
    }
}