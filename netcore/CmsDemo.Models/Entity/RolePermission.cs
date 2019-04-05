/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：角色权限表                                                    
*│　作    者：liaofeng                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-24 11:20:51                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: CmsDemo.Models                                  
*│　类    名：RolePermission                                     
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CmsDemo.Models.Entity
{
	/// <summary>
	/// liaofeng
	/// 2019-02-24 11:20:51
	/// 角色权限表
	/// </summary>
	[Table("RolePermission")]
	public class RolePermission
	{
		/// <summary>
		///  
		/// </summary>
		[Key]
		public Int32 Id {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(10)]
		public Int32? RoleId {get;set;}

		/// <summary>
		/// 权限ID  ,1,2,3,4,5,6,
		/// </summary>
		[MaxLength(10)]
		public Int32? PermissionId {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(23)]
		public DateTime? UpdateDate {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(23)]
		public DateTime? CreateDate {get;set;}


	}
}
