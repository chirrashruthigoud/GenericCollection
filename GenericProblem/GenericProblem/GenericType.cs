using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    public class GenericType<T>
    {
        //variable type T(any datatype)
        public T data;
        //this my generic contructor.
        public GenericType(T data)
        {
            this.data = data;
            Console.WriteLine("Data :" +this.data);
        }

        public void Genericdemo(T data)
        {
            Console.WriteLine("Data :" + data);

        }
        public void GenericDemo<T>(T data)
        {
            Console.WriteLine("Data :" + data);

        }
    }
}
