using System;
using System.Collections.Generic;
using System.Text;

namespace LF_CMS.Core.Model
{
    /**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：属性节点                                                    
*│　作    者：廖峰                                            
*│　版    本：1.0                                                 
*│　创建时间：2019/2/17 12:16:25                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： LF_CMS.Core.Model                                  
*│　类    名： TreeItem                                      
*└──────────────────────────────────────────────────────────────┘
*/
    public class TreeItem<T>
    {
        public T Item { get; set; }
        public IEnumerable<TreeItem<T>> Children { get; set; }
    }
}
