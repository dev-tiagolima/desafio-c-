using System;


namespace Projetos
{

    class Program
    {
        public static int Main(string[] args)
        {
            int n, nota, quociente, resto, n100 = 0, n50 = 0, n20 = 0, n10 = 0, n5 = 0, n2 = 0, n1 = 1;
           

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            nota = 100;
            quociente = resto / 100;
            resto = resto % 100;

        n100 = n / 100;
        n %= 100;
        n50 = n / 50;
        n %= 50;
        n20 = n / 20;
        n %= 20;
        n10 = n / 10;
        n %= 10;
        n5 = n / 5;
        n %= 5;
        n2 = n / 2;
        n %= 2;
        n1 = n;

        Console.WriteLine(resto);
        Console.WriteLine($"{n100} nota(s) de R$ 100,00");
        Console.WriteLine($"{n50} nota(s) de R$ 50,00");
        Console.WriteLine($"{n20} nota(s) de R$ 20,00");
        Console.WriteLine($"{n10} nota(s) de R$ 10,00");
        Console.WriteLine($"{n5} nota(s) de R$ 5,00");
        Console.WriteLine($"{n2} nota(s) de R$ 2,00");
        Console.WriteLine($"{n1} nota(s) de R$ 1,00");

return 0;
         

    }                                       
        }
    }
      
  
