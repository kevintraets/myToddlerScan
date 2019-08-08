using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwpSide.Extensions
{
    public static class ListExtensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> list)
        {
            var collection = new ObservableCollection<T>();
            foreach (var item in list)
            {
                collection.Add(item);
            }

            return collection;
        }
    }
}
