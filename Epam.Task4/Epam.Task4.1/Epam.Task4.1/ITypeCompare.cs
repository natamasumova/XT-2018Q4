using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4._1
{
    public interface ITypeCompare<T>
    {
        void Compare(T item1, T item2);
    }
}
