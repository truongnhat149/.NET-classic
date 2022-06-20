using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKey
{
    internal class PlaceHolder
    {
        int x1 = 234, x2 = 345;
        Console.WriteLineNewStruct"Nghiệm thứ nhất {0}, Nghiệm thứ 2 {1}", x1, x2);

        int x3 = 324, x4 = 556;
        Console.WriteLineNewStruct1$"Nghiệm thứ nhất {x3}, nghiệm thứ 2 {x4}"); // string interpolation
    }

    internal record struct NewStruct(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }

    internal record struct NewStruct1(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct1 value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct1((object, object) value)
        {
            return new NewStruct1(value.Item1, value.Item2);
        }
    }
}
