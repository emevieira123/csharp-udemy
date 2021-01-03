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

           // Cliente gabriela = new Cliente();

            // gabriela.nome = "Gabriela";
            // gabriela.profissao = "Dev C#";
            // gabriela.cpf = "452.751.723.18";            

            // conta.titular = gabriela;
            // conta.titular = new Cliente();
            // conta.titular.nome = "Gabriela Costa";
            // conta.titular.profissao = "Dev C#";
            // conta.titular.cpf = "452.751.723.18";

            // conta.saldo = 500;
            // conta.agencia = 563;
            // conta.numero = 5634527;

            // System.Console.WriteLine(gabriela.nome);
            // System.Console.WriteLine(conta.titular.nome);
            // System.Console.WriteLine(conta.titular.cpf);
            // System.Console.WriteLine(conta.titular.profissao);
            // Cliente cliente = new Cliente();

            // cliente.Nome = "Emerson";
            // cliente.CPF = "012.345.678-90";
            // cliente.Profissao = "Dev C#";

            // conta.Saldo = -10;
            // conta.Titular = cliente;

            // System.Console.WriteLine(conta.Titular.Nome);
            // System.Console.WriteLine(conta.Saldo);

            ContaCorrente conta = new ContaCorrente(867, 86712540);

            System.Console.WriteLine(conta.Agencia);
            System.Console.WriteLine(conta.Numero);




        }
    }
}
