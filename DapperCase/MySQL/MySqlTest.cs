using Dapper;
using DapperCase.Interface;
using DapperCase.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCase.MySQL
{
    public class MySqlTest : IMySQL
    {
        public async Task<List<FarmerUser>> GetFarmerListAsync()
        {
            List<FarmerUser> farmerSetRet = null;

            StringBuilder sbSql = new StringBuilder();
            DynamicParameters param = new DynamicParameters();

            sbSql.Append("SELECT f.*,a.* FROM FarmerUser f left JOIN accountinfo a ON f.AccountinfoId=a.Id left JOIN comment s ON f.Id =s.ToUserId  WHERE 1=1");


            sbSql.Append(" GROUP BY f.Id ORDER BY a.CreationTime DESC");



            using (MySqlConnection conn = new MySqlConnection(MySqlConnIni.MySqlConn.ConnStr))
            {
                var result = await conn.QueryAsync<FarmerUser, AccountInfo, FarmerUser>(sbSql.ToString(), (f, a) =>
                {
                    f.Account = a;
                    return f;
                }, param);

                farmerSetRet = result.ToList();
            }

            return farmerSetRet;
        }

    }
}
