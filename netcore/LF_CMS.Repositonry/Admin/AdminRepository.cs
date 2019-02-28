/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：用户表接口实现                                                    
*│　作    者：liaofeng                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-02-24 11:20:51                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Repository                                  
*│　类    名： AdminRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using LF_CMS.Core.DbHelper;
using LF_CMS.Core.Options;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using LF_CMS.Core.Repository;
using LF_CMS.Models.Entity;
using LF_CMS.Models;
using System.Linq;

namespace LF_CMS.Repository
{
    public class AdminRepository : BaseRepository<Admin, Int32>, IAdminRepository
    {
        public AdminRepository(IOptionsSnapshot<DbOption> options) : base(options)
        {

        }

        public int DeleteLogical(int[] ids)
        {
            string sql = "update Admin set IsDelete=1 where Id in @Ids";
            return _dbConnection.Execute(sql, new
            {
                Ids = ids
            });
        }

        public async Task<int> DeleteLogicalAsync(int[] ids)
        {
            string sql = "update Admin set IsDelete=1 where Id in @Ids";
            return await _dbConnection.ExecuteAsync(sql, new
            {
                Ids = ids
            });
        }

        public Admin GetAdminById(int id)
        {
            string sql = @"SELECT Id, UserName, Name, PassWord, Email, Mobile, RoleId, PermissionID, Avatar, Remark, LoginCount, IsDelete, IsLock, LoginLastIp, UpdateDate, CreateDate
                           FROM dbo.Admin where id =@id";
            //return _dbConnection.Get<Admin>(id);
            return _dbConnection.QueryFirst<Admin>(sql, new { id = id });

        }

        public Admin GetAdminByUserName(string userName)
        {
            string sql = @"SELECT Id, UserName, Name, PassWord, Email, Mobile, RoleId, PermissionID, Avatar, Remark, LoginCount, IsDelete, IsLock, LoginLastIp, UpdateDate, CreateDate
                           FROM dbo.Admin where UserName =@userName";
            return _dbConnection.QueryFirstOrDefault<Admin>(sql, new { UserName = userName });
        }
    }
}