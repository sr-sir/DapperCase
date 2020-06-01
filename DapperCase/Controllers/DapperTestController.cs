using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DapperCase.Interface;
using DapperCase.Model;
using DapperCase.Realize;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DapperTestController : ControllerBase
    {
        private readonly IFarmerUserServers _farmerUserServers;


        private readonly IMapper _map;
        public DapperTestController(IMapper mapper)
        {
            _farmerUserServers = new FarmerUserServers(mapper);

            _map = mapper;
        }


        [HttpGet("GetFarmerInfoList")]
        public async Task<GetFarmerInfoListResponse> GetFarmerListExcel()
        {
            var reply = await _farmerUserServers.GetFarmerListAsync();
            return _map.Map<GetFarmerInfoListResponse>(reply);
        }


        [HttpGet("Test")]
        public async Task<string> Test()
        {
            return "test";
        }
    }
}