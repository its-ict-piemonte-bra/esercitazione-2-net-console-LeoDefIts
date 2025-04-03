using System;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            /* Write some code here...
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Il perimetro del quadrato è " + n * 4);
            Console.WriteLine("L'area del quadrato è " + n * n);*/
            es4();
        }
        private static void es1()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(a);
                a = a + 2;
            }
        }
        private static void es2()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                for (int i = a - 1; i > 0; i--)
                {
                    a = a * i;
                }
                    Console.WriteLine(a);
            }
            else if (a == 0)
                Console.WriteLine("1");
            else
                Console.WriteLine("il numero e' negativo");

        }
        private static void es3FattoDiverso()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int numN = 0;
            int ind = 0;
            int i = 0;
            int[] vet = new int[30];
            if (num < 0)
            {
                num = num - num * 2;
                numN = 1;
            }
            while (ind == 0)
            {
                if (num == 1 || num == -1)
                    ind = 1;
                if (num % 2 == 1)
                    vet[i] = 1;
                num = num / 2;
                i++;
            }
            if (numN == 1)
            {
                for (i = 0; i < 20; i++)
                {
                    if (vet[i] == 1)
                        vet[i] = 0;
                    else
                        vet[i] = 1;
                }
                i = 0;
                while (vet[i] == 1)
                {
                    if (vet[i] == 1)
                        vet[i] = 0;
                    i--;
                }
                vet[i] = 1;
            }

            for (i = 29; i >= 0; i--)
                Console.Write($"{vet[i]}");
        }
        private static void es4()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if(a > 0)
            {
                int num1 = 0;
                int num2 = 1;
                int num = 0;

                for (int i = 0; i <= a; i++)
                {
                
                    num = num1 + num2;
                    num2 = num1;
                    num1 = num;
                }
                Console.WriteLine(num);
            }
            else if(a == 0)
                Console.WriteLine("0");
            else
                Console.WriteLine("numero negativo");
        }
    }
}
  