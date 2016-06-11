using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public interface IData<T>
    {
       T First {get;} 

       void Add(T element);
       T Get(int iter);
       T Get(T element)
       void Remove();
       void Remove(int inter);
       Void Remove(T element);
       void Count();
       void Join();
       void Print();

    }
}
