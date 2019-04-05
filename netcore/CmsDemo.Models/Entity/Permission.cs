/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：权限表                                                    
*│　作    者：liaofeng                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-24 11:20:51                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: CmsDemo.Models                                  
*│　类    名：Permission                                     
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
	/// 权限表
	/// </summary>
	[Table("Permission")]
	public class Permission
	{
		/// <summary>
		///  
		/// </summary>
		[Key]
		public Int32 Id {get;set;}

		/// <summary>
		/// 权限名称：页面名称，模块名称，按钮名称等。
		/// </summary>
		[MaxLength(32)]
		public String Name {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(10)]
		public Int32? ParentId {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(128)]
		public String IconUrl {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(128)]
		public String LinkUrl {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(10)]
		public Int32? Sort {get;set;}

		/// <summary>
		/// 权限类型：1:模块,2:菜单,3:按钮
		/// </summary>
		[MaxLength(10)]
		public Int32? Type {get;set;}

		/// <summary>
		/// 添加人
		/// </summary>
		[MaxLength(10)]
		public Int32? AddManagerId {get;set;}

		/// <summary>
		/// 修改人
		/// </summary>
		[MaxLength(10)]
		public Int32? UpdateManagerId {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(1)]
		public Boolean? IsDisplay {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(1)]
		public Boolean? IsDelete {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(23)]
		public DateTime? UpdateTime {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(23)]
		public DateTime? CreateTime {get;set;}


	}
}
