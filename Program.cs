using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal resto = 0;
            decimal qtd_notas_100;
            decimal qtd_notas_50;
            decimal qtd_notas_20;
            decimal qtd_notas_10;

            Console.WriteLine("Digite o valor da nota\n");
            decimal notas = Convert.ToDecimal(Console.ReadLine());
            decimal soma = 0;


            if ((notas % 10) != 0 || notas < 0)
            {
                Console.WriteLine("Erro de valor inválido\n");
            }

            {
                if (notas % 10 == 0 && notas != 20 && notas != 50 && notas != 100)
                {
                    soma += 10;
                    notas = notas - 10;
                }
                else if (notas % 20 == 0 && notas != 0)
                {

                }

                qtd_notas_100 = Math.Truncate(notas / 100);
                resto = resto % 100;


                qtd_notas_50 = Math.Truncate(notas / 50);
                resto = resto % 50;


                qtd_notas_20 = Math.Truncate(notas / 20);
                resto = resto % 20;

                qtd_notas_10 = Math.Truncate(notas / 10);
                resto = resto % 10;
            }

            Console.WriteLine("Notas de 100:" + qtd_notas_100);
            Console.WriteLine("Notas de 50:" + qtd_notas_50);
            Console.WriteLine("Notas de 20:" + qtd_notas_20);
            Console.WriteLine("Notas de 10:" + qtd_notas_10);

            Console.ReadLine();
        }
        
        
    }
}

            

      
       
           
  

