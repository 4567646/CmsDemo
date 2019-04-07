using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CmsDemo.Core.Entities
{
    /// <summary>
    /// liaofeng
    /// 2019-02-24 11:20:51
    /// 用户表
    /// </summary>
    [Table("Admin")]
    public class Admin : AggregateRoot
    {

        /// <summary>
        /// 登录用户名
        /// </summary>
        [MaxLength(32)]
        public String UserName { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [MaxLength(64)]
        public String Name { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(32)]
        public String PassWord { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(128)]
        public String Email { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [MaxLength(12)]
        public String Mobile { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(32)]
        public String RoleId { get; set; }

        /// <summary>
        /// 权限ID ,1,2,3,4,5,6,
        /// </summary>
        [MaxLength(256)]
        public String PermissionID { get; set; }

        /// <summary>
        /// 头像url
        /// </summary>
        [MaxLength(128)]
        public String Avatar { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(256)]
        public String Remark { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(10)]
        public Int32? LoginCount { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [MaxLength(1)]
        public Boolean? IsDelete { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(1)]
        public Boolean? IsLock { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(32)]
        public String LoginLastIp { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(23)]
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(23)]
        public DateTime? CreateDate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this.GetType().Equals(obj.GetType()) == false)
            {
                return false;
            }
            Admin temp = null;
            temp = (Admin)obj;
            return this.UserName.Equals(temp.UserName);
        }
        //重写GetHashCode方法（重写Equals方法必须重写GetHashCode方法，否则发生警告

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
