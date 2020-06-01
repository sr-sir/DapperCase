using DapperCase.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCase
{
    public class MySqlConnIni
    {
        public static MySqlConn MySqlConn = new MySqlConn();

        public MySqlConnIni(IConfiguration configuration)
        {
            MySqlConn.ConnStr = configuration["ConnectionStrings:DefaultConnection"];
        }

    }
}
