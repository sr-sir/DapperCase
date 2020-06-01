using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCase.Model
{
    public class FarmerInfo
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
    public class AccountInfo
    {
        /// <summary>
        /// 账户登录手机号
        /// </summary>
        public string LoginPhone { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; } = string.Empty;

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCardNumber { get; set; } = string.Empty;

        /// <summary>
        /// 身份证正面图片地址
        /// </summary>
        public string IdCardFrontPicUrl { get; set; } = string.Empty;

        /// <summary>
        /// 身份证背面图片地址
        /// </summary>
        public string IdCardBackPicUrl { get; set; } = string.Empty;

        /// <summary>
        /// 真实姓名审核状态
        /// </summary>
        public int RealNameAuditStatus { get; set; }

        /// <summary>
        /// 身份证正面审核状态
        /// </summary>
        public int IdCardFrontPicAuditStatus { get; set; }

        /// <summary>
        /// 身份证背面审核状态
        /// </summary>
        public int IdCardBackPicAuditStatus { get; set; }

        /// <summary>
        /// 资料提交时间
        /// </summary>
        public DateTime? SubTime { get; set; }

        /// <summary>
        /// 完成审核时间
        /// </summary>
        public DateTime? AuditTime { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        public bool AccountStatus { get; set; }



    }

}
