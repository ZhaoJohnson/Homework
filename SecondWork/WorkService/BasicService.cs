using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WorkModel;
using WorkModel.Interface;
using WorkService.IService;

namespace WorkService
{
    public class BasicService:IBasicService
        
    {
        public static void Print<Tvalue>(Tvalue tValue)
            where Tvalue:BasicShow,IPay
        {
            foreach (PropertyInfo itemInfo in tValue.GetType().GetProperties())
            {
                Console.WriteLine(itemInfo.Name);
            }
        }
        public void Dispose()
        {
        }
    }
}
