using DapperCase.Model;
using DapperCase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DapperCase.MySQL;

namespace DapperCase.Realize
{
    public class FarmerUserServers : IFarmerUserServers
    {
        private readonly IMySQL mySQL;
        private readonly IMapper mapper;

        public FarmerUserServers(IMapper mapper)
        {
            this.mySQL = new MySqlTest();
            this.mapper = mapper;
        }


        public async Task<GetFarmerInfoListReply> GetFarmerListAsync()
        {
            var farmerInfoSet = await mySQL.GetFarmerListAsync();
            //var farmerInfoCount = await _farmerUserRepository.GetFarmerCountAsync(phone, loginPhone, startTime, endTime, complaints);

            var reply = mapper.Map<GetFarmerInfoListReply>(farmerInfoSet);
            //reply.TotalCount = farmerInfoCount;

            //for (int i = 0; i < reply.Item.Count; i++)
            //{
            //    reply.Item[i].Percent = decimal.Round(await _commentService.GetFarmerComplaintPercent(reply.Item[i].Id), 2);
            //    reply.Item[i].Complaints = decimal.Round(await _CommentRepositories.GetComplaintCountAsync(reply.Item[i].Id));
            //    reply.Item[i].TodayComplaints = decimal.Round(await _CommentRepositories.GetTodayComplaintCountAsync(reply.Item[i].Id));
            //}



            return reply;
        }

    }
}
