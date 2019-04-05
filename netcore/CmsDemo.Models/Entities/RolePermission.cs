
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CmsDemo.Models.Entities
{
    /// <summary>
    /// liaofeng
    /// 2019-02-24 11:20:51
    /// 角色权限表
    /// </summary>
    [Table("RolePermission")]
    public class RolePermission : Entity
    {

        /// <summary>
        ///  
        /// </summary>
        [MaxLength(10)]
        public Int32? RoleId { get; set; }

        /// <summary>
        /// 权限ID  ,1,2,3,4,5,6,
        /// </summary>
        [MaxLength(10)]
        public Int32? PermissionId { get; set; }

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


    }
}
