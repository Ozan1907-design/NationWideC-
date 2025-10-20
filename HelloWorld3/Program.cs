using System;

namespace HelloWorld2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Pete";
            int[] arr =  new int[5];
            for (int i = 0; i <name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                arr[i] = i + 1;
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Hello World, my name is " + name);
            
        }
    }
}

