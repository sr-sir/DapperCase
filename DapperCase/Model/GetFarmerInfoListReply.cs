using System;
using System.Collections.Generic;

namespace DapperCase.Model
{
    public class GetFarmerInfoListReply
    {
        public List<GetFarmerInfoListItem> Item { get; set; }

        public int TotalCount { get; set; }

    }

    public class GetFarmerInfoListItem
    {
        /// <summary>
        /// 农户ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 账户登录手机号
        /// </summary>
        public string LoginPhone { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 投诉率
        /// </summary>
        public decimal Percent { get; set; }

        /// <summary>
        /// 投诉数量
        /// </summary>
        public decimal Complaints { get; set; }

        /// <summary>
        /// 今日投诉数量
        /// </summary>
        public decimal TodayComplaints { get; set; }
    }
}