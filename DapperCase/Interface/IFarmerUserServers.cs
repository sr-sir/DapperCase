using Abp.Dependency;
using DapperCase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCase.Interface
{
    public interface IFarmerUserServers : ITransientDependency
    {
        Task<GetFarmerInfoListReply> GetFarmerListAsync();
    }
}
