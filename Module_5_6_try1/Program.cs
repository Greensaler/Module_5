using System;

namespace Module_5_6_try1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            NumberManipulator jopa = new NumberManipulator();

            result = jopa.FindMax(30, 20);
            Console.WriteLine(result);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
