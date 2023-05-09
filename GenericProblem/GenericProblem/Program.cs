using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class Program
    {//generic means the general form it does not contain any data type
        //it means not a specific or particular data type.
        //we are using angle bracket<> with type name
        //TypeName<T> T is type(any datatype) parameter.
        //generic allow us to create single class or method that can be used with different data type.
        //advantage : we can reuse our code
        static void Main(string[] args)
        {
            GenericType <string> genericType = new GenericType <string>("sunny");
            GenericType<int> generic = new GenericType<int>(5);
            GenericType<double> generics = new GenericType<double>(5.2);
            generic.Genericdemo(6);
            generics.Genericdemo(6.5);
            genericType.Genericdemo("siri");

            generic.GenericDemo<int>(9);
            generics.GenericDemo<double>(4.9);
            Console.ReadKey();
        }
    }
}
