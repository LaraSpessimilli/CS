using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero: ");
            int MyNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro numero: ");
            int MyNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("o que deseja fazer com os valores?");
            Console.WriteLine("{1} somar");
            Console.WriteLine("{2} subitrair");
            Console.WriteLine("{3} multiplicar");
            Console.WriteLine("{4} dividir");
            int MyNum3 = Convert.ToInt32(Console.ReadLine());

            if (MyNum3 == 1)
            {
                int MyNum4 = MyNum1 + MyNum2;
                Console.WriteLine("A soma é: " + MyNum4);
            }
            if (MyNum3 == 2)
            {
                int MyNum4 = MyNum1 - MyNum2;
                Console.WriteLine("A subitracao é: " + MyNum4);
            }
            if (MyNum3 == 3)
            {
                int MyNum4 = MyNum1 * MyNum2;
                Console.WriteLine("A mutiplicaçao é: " + MyNum4);
            }
            if (MyNum3 == 4)
            {
                int MyNum4 = MyNum1 / MyNum2;
                Console.WriteLine("A divisao é: " + MyNum4);
            }
        }

    }
}

