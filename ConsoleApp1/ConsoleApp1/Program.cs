using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero para ver se e par pou impar");
            int NyNum = Convert.ToInt32(Console.ReadLine());
            int nynum = NyNum / 2;
            if (nynum == 0)
            {
                Console.WriteLine("par");
            }
            else 
            {
            
            Console.WriteLine("impar");
            
            }

        }
    }
}

