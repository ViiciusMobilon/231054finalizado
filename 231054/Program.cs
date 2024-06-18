using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _231054
{
    internal class Program
    {
        static void Total(double saldo)
        {
            Console.WriteLine("O saldo é igual a: " + saldo.ToString("C"));
        }
        static double Dep(double saldo)
        {
            double deposito = 0;
            Console.WriteLine("Valor a ser depositado:");
            deposito = double.Parse(Console.ReadLine());
            saldo += deposito;
            Console.WriteLine("Pronto");
            return saldo;
        }
        static double Saque(double saldo)
        {

            double saque = double.MinValue;
            Console.WriteLine("Valor a ser sacado:");
            saque = double.Parse(Console.ReadLine());
            if (saldo < saque)
            {
                Console.WriteLine("Pronto");
            }
            else
            {
                saldo -= saque;
                Console.WriteLine("Pronto");
            }
            return saldo;
        }
        static double Pag(double saldo)
        {
            double pagamento = double.MinValue;
            Console.WriteLine("Digite o número da conta");
            Console.ReadLine();
            Console.WriteLine("Valor do pagamento:");
            pagamento = double.Parse(Console.ReadLine());
            if (saldo < pagamento)
            {
                Console.WriteLine("Pronto");

            }
            else
            {
                saldo -= pagamento;
                Console.WriteLine("Pronto");
            }
            return saldo;
        }

        static void Main(string[] args)
        {
            double balance = 0;
            string op;
            while (true)
            {
                Console.WriteLine("###OPÇÕES### \n D-DEPOSITO \n S-SAQUE \n P-PAGAMENTO \n B-SALDO");
                op = Console.ReadLine().ToUpper();
                switch (op)
                {
                    case "D": balance = Dep(balance); Console.ReadKey(); Console.Clear(); break;
                    case "S": balance = Saque(balance); Console.ReadKey(); Console.Clear(); break;
                    case "P": balance = Pag(balance); Console.ReadKey(); Console.Clear(); break;
                    case "B": Total(balance); Console.ReadKey(); Console.Clear(); break;
                }

            }

        }
    }
}
