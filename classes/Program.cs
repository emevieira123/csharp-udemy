using System;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ContaCorrente contaDaGabriela = new ContaCorrente();

            // contaDaGabriela.titular = "Gabriela";
            // contaDaGabriela.agencia = 863;
            // contaDaGabriela.numero = 863452;
            // contaDaGabriela.saldo = 100;

            // System.Console.WriteLine(contaDaGabriela.titular);
            // System.Console.WriteLine(contaDaGabriela.agencia);
            // System.Console.WriteLine(contaDaGabriela.numero);
            // System.Console.WriteLine(contaDaGabriela.saldo);

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";

            System.Console.WriteLine(conta.titular);
            System.Console.WriteLine(conta.saldo);

        }
    }
}
