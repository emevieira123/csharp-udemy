using System;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            System.Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            System.Console.WriteLine(contaDoBruno.saldo);
            System.Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            System.Console.WriteLine(contaDoBruno.saldo);
        }
    }
}
