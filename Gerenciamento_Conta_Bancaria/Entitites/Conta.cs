using System;
using System.Collections.Generic;
using System.Text;
using Gerenciamento_Conta_Bancaria.Entitites.Exceptions;

namespace Gerenciamento_Conta_Bancaria.Entitites
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Limite_Saque { get; set; }

        public Conta()
        {

        }

        public Conta(int numero, string titular, double limite_Saque, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Limite_Saque = limite_Saque;
            Saldo = saldo;
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque)
        {
            
                if(saque <= Saldo && saque <= Limite_Saque)
                {
                    Saldo -= saque;
                }
            
                else if(saque > Saldo)
                {
                    throw new Domain_Exception("Valor de saque excedi o valor em saldo. ");
                }
            
           
                else if (saque > Limite_Saque)
                {
                    throw new Domain_Exception("Valor de saque excedi o valor de limite de saque. ");
                }
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Novo Saldo : R$ " + Saldo);

            return sb.ToString();
        }


    }
}
