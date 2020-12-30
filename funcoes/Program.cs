using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ContaCorrente contaDoBruno = new ContaCorrente();

            // contaDoBruno.titular.nome = "Bruno";

            // System.Console.WriteLine(contaDoBruno.saldo);

            // bool resultadoSaque = contaDoBruno.Sacar(500);

            // System.Console.WriteLine(contaDoBruno.saldo);
            // System.Console.WriteLine(resultadoSaque);

            // contaDoBruno.Depositar(500);
            // System.Console.WriteLine(contaDoBruno.saldo);

            // ContaCorrente contaDaGabriela = new ContaCorrente();

            // contaDaGabriela.titular.nome = "Gabriela";

            // System.Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            // System.Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            // bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);
            // System.Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            // System.Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            // System.Console.WriteLine("Resultado da Transferencia: " + resultadoTransferencia);

            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Dev C#";
            gabriela.cpf = "452.751.723.18";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            System.Console.WriteLine(gabriela.nome);
            System.Console.WriteLine(conta.titular.nome);

        }
    }
}
