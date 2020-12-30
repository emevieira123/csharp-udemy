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

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            System.Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            System.Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);
            System.Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            System.Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            System.Console.WriteLine("Resultado da Transferencia: " + resultadoTransferencia);
        }
    }
}
