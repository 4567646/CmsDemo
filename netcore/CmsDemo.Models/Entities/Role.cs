
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CmsDemo.Models.Entities
{
	/// <summary>
	/// liaofeng
	/// 2019-02-24 11:20:51
	/// 角色表
	/// </summary>
	[Table("Role")]
	public class Role:Entity
	{

		/// <summary>
		/// 角色名称
		/// </summary>
		[Required]
		[MaxLength(12)]
		public String Name {get;set;}

		/// <summary>
		/// 备注
		/// </summary>
		[MaxLength(128)]
		public String Remark {get;set;}

		/// <summary>
		/// 是否删除 0-否 1-是
		/// </summary>
		[Required]
		[MaxLength(1)]
		public Boolean IsDelete {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(23)]
		public DateTime? UpdateDate {get;set;}

		/// <summary>
		///  
		/// </summary>
		[Required]
		[MaxLength(23)]
		public DateTime CreateDate {get;set;}


	}
}
