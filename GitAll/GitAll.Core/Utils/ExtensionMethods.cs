using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAll.Core.Utils
{
    public static class ExtensionMethods
    {
        public static int IndexOf(this IEnumerable self, object obj)
        {
            int index = -1;

            var enumerator = self.GetEnumerator();
            enumerator.Reset();
            int i = 0;
            while (enumerator.MoveNext())
            {
                if (enumerator.Current == obj)
                {
                    index = i;
                    break;
                }

                i++;
            }

            return index;
        }

        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> elements)
        {
            foreach(var element in elements)
            {
                collection.Add(element);
            }
        }

        public static void AddRange<T>(this ObservableCollection<T> collection, List<T> elements)
        {
            foreach(var element in elements)
            {
                collection.Add(element);
            }
        }
    }
}
