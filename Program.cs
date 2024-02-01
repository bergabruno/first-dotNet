using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            helloWorld();
            biggerSmaller();
        }

        public static void helloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        public static void biggerSmaller()
        {
            Random rnd = new Random();

            int[] numeros = new int[10];
            int bigger = int.MinValue;
            int smaller = int.MaxValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next();
                Console.WriteLine(numeros[i]);

                if (numeros[i] > bigger)
                {
                    bigger = numeros[i];
                }

                if (numeros[i] < smaller)
                {
                    smaller = numeros[i];
                }
            }

            Console.WriteLine(bigger);
            Console.WriteLine(smaller);
        }
    }
}