using System;
using System.Globalization;
using Gerenciamento_Conta_Bancaria.Entitites;
using Gerenciamento_Conta_Bancaria.Entitites.Exceptions;

namespace Gerenciamento_Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.WriteLine("Entre com os dados da Conta");
            Console.Write("Número da conta : ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular da conta : ");
            string titular = Console.ReadLine();
            Console.Write("Digite o deposito inicial : ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(deposito);
            Console.Write("Limite máximo de saque : ");
            double limite_Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta = new Conta(numero, titular, limite_Saque, deposito);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Entre com o valor que deseja sacar : ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                conta.Sacar(saque);
                Console.WriteLine(conta);
            }
            catch (Domain_Exception e)
            {
                Console.WriteLine("Erro no saque : "+e.Message);
            }







        }
    }
}
