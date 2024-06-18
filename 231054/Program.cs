using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _231054
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string s = "sim";
            double de;
            double deposito = 0;
            double total = 0;
            do
            {


                Console.WriteLine("Qual a opição você deseja realizar ");
                Console.WriteLine("Digite (1) para Depósitar");
                Console.WriteLine("Digite (2) para Saque");
                Console.WriteLine("Digite (3) para Pagamento");
                Console.WriteLine("Digite (4) para consultar Saldo");
                int tipo = int.Parse(Console.ReadLine());
                switch (tipo)
                {
                    case 1:
                        Console.WriteLine("Quanto você deseja depositar");
                       de= double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Seu saldo disponivel e " + dep(total, de,deposito));
                       
                        break;

                    case 2:


                        Console.WriteLine("Quanto você deseja sacar");
                        double sacar = double.Parse(Console.ReadLine());

                        if (sacar > total)
                        {
                            Console.WriteLine("Você nao ten saldo disponivel");

                        }
                        else
                        {
                            Console.WriteLine("Seu saldo disponivel e " + sac(total, sacar, deposito));
                        }
                            ;
                            break;


                }

                Console.WriteLine("Se deseja continuar digite (sim)");
                 s = Console.ReadLine().ToLower();
            } while (s == "sim");
 Console.ReadKey();

        }

         static double Dep(int tipo ,double total, double de,double deposito,double sacar) 
        {
            
            if (tipo == 1) { 
            total = deposito;
             total = de + deposito;
            return total;
             }
           else  if (tipo == 2){ 
                total = deposito;
            total = deposito - sacar;
            return total;
            }
        }
        static double sac(double total, ,double deposito) 
        {
            total = deposito;
            total =  deposito - sacar;
            return total;

        }
    }
}
