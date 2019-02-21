/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：                                                    
*│　作    者：廖峰                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2019-02-17 17:16:12                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: LF_CMS.Models.Entity                                  
*│　类    名：NLog                                     
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LF_CMS.Models.Entity
{
	/// <summary>
	/// 廖峰
	/// 2019-02-17 17:16:12
	/// 
	/// </summary>
	[Table("NLog")]
	public class NLog
	{
		/// <summary>
		///  
		/// </summary>
		[Key]
		public Int32 Id {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(50)]
		public String Application {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(23)]
		public DateTime? Logged {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(50)]
		public String Level {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(512)]
		public String Message {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(250)]
		public String Logger {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(512)]
		public String Callsite {get;set;}

		/// <summary>
		///  
		/// </summary>
		[MaxLength(512)]
		public String Exception {get;set;}


	}
}
