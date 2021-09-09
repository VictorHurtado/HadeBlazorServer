using Dapper;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using CititorServer.Data.Model;
using System;
using System.Collections.Generic;

namespace CititorServer.Data.Service
{
    public class MenuService:IMenuService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;

        public MenuService(SqlConnectionConfiguration configuration)
        {

            _configuration = configuration;

        }
        public async Task<IEnumerable<MenuInfo>> GetMenuData()
        {
            IEnumerable<MenuInfo> menuInfos;
            using (var conn = new MySqlConnection(_configuration.Value)){
                const string query = @"Select * from MenuInfo";
                if(conn.State == ConnectionState.Closed){
                    conn.Open();
                }
                try
                {
                    menuInfos= await conn.QueryAsync<MenuInfo>(query);
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
            return menuInfos;
        }
        

    }
}
