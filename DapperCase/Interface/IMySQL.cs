using DapperCase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCase.Interface
{
    public interface IMySQL
    {
        Task<List<FarmerUser>> GetFarmerListAsync();
    }
}
