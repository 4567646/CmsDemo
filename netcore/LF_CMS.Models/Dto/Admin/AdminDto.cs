using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.Models.Dto.Admin
{
    public class AdminDto
    {
        public Int32 Id { get; set; }
        
        public String UserName { get; set; }
        
        public String Name { get; set; }
        
        public String Email { get; set; }
        
        public String Mobile { get; set; }
        
        public String RoleId { get; set; }
        
        public String PermissionID { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public String Avatar { get; set; }
        
        
        public Int32? LoginCount { get; set; }
        
        public Boolean? IsDelete { get; set; }
        
        
        public String LoginLastIp { get; set; }
        
        public DateTime? UpdateDate { get; set; }
        
        public DateTime? CreateDate { get; set; }
    }
}
