using AutoMapper;
using DapperCase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCase
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<GetFarmerInfoListResponse, GetFarmerInfoListReply>();
            CreateMap<GetFarmerInfoListReply, List<FarmerUser>>();
            CreateMap<GetFarmerInfoListReply, GetFarmerInfoListResponse>();
            CreateMap<List<FarmerUser>, GetFarmerInfoListReply>();
        }
    }
}
