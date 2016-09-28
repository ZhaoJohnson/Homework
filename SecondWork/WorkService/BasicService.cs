using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WorkModel;
using WorkService.IService;

namespace WorkService
{
    public class BasicService<TModel>:IBasicService
        where TModel : BasicShow,new()
    {
        public static void Print()
        {
            TModel model=new TModel();
            foreach (PropertyInfo itemInfo in model.GetType().GetProperties())
            {
                Console.WriteLine(itemInfo.Name);
            }
        }
        public void Dispose()
        {
        }
    }
}
