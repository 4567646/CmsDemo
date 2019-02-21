/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：后台管理菜单接口实现                                                    
*│　作    者：廖峰                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-02-17 17:48:06                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Repository                                  
*│　类    名： MenuRepository                                      
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
using System.Collections.Generic;

namespace LF_CMS.Repository
{
    public class MenuRepository : BaseRepository<Menu, Int32>, IMenuRepository
    {
        public MenuRepository(IOptionsSnapshot<DbOption> options) : base(options)
        {

        }
        public int DeleteLogical(int[] ids)
        {
            string sql = "update Menu set IsDelete=1 where Id in @Ids";
            return _dbConnection.Execute(sql, new
            {
                Ids = ids
            });
        }

        public async Task<int> DeleteLogicalAsync(int[] ids)
        {
            string sql = "update Menu set IsDelete=1 where Id in @Ids";
            return await _dbConnection.ExecuteAsync(sql, new
            {
                Ids = ids
            });
        }


        public async Task<IEnumerable<Menu>> GetAllAsync()
        {
            var list = await _dbConnection.QueryAsync<Menu>(GetAllSql(), null);
            return list;
        }
        public IEnumerable<Menu> GetAll()
        {

            var list = _dbConnection.Query<Menu>(GetAllSql(), null);
            return list;
        }


        private string GetAllSql()
        {
            return @" SELECT Id ,ParentId,Name,DisplayName,IconUrl,LinkUrl,Sort,Permission,IsDisplay,IsSystem,AddManagerId,AddTime,ModifyManagerId,ModifyTime,IsDelete 
                            FROM Menu where IsDelete=0";
        }
    }
}