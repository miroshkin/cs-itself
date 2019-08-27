using System;

namespace Cs.Itself.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleExample sex = new SimpleExample();
            int a = 3;
            int b = 4;
            sex.ExampleFunction(new int[] {1}, 2, ref a, out b);

            Console.WriteLine($"a = {a},\nb = {b}");
        }
    }

    class SimpleExample
    {
        public static int staticMember;
        private int memberVariable;

        public void ExampleFunction(int[] arrayOfIntsParam, int simpleParam, ref int refParam, out int outParam)
        {
            int tempVariable = 1;

            if (arrayOfIntsParam != null)
            {
                outParam = simpleParam + refParam + arrayOfIntsParam.Length;
            }
            else
            {
                outParam = simpleParam + refParam;
            }
            
        }
    }


}
