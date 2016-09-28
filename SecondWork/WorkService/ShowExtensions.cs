using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkService
{
    public static class ShowExtensions
    {
        public static TProperty GetPropertyValue<TObject, TProperty>(this TObject target,
            Expression<Func<TObject, TProperty>> memberLamda)
        {
            return (TProperty)target.GetPropertyValue(memberLamda);
        }
    }
}
