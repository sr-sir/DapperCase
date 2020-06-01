using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCase.Model
{
    public class FarmerUser
    {

        public string OpenId { get; set; }

        public string WeChatName { get; set; }

        public string PhoneNumber { get; set; }

        public string AvatarUrl { get; set; }

        public string RealName { get; set; }

        public string IdNumber { get; set; }

        public string IdCardFrontPicUrl { get; set; }

        public string IdCardBackPicUrl { get; set; }

        public int NameAuditStatus { get; set; } = 2;
        public int IdCardFrontPicAuditStatus { get; set; } = 2;

        public int IdCardBackPicAuditStatus { get; set; } = 2;

        public string Location { get; set; }

        public DateTime CreatedUtcTime { get; set; } = DateTime.UtcNow.Date;

        /// <summary>
        /// 账号Id
        /// </summary>
        public string AccountinfoId { get; set; }

        public AccountInfo Account { get; set; }
    }
}
