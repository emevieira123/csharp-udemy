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

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            System.Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta)); 

            int idade = 27;
            int idadeMaisUmaVez = 27;
            System.Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));       

            contaDaGabriela = contaDaGabrielaCosta;
            System.Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;
            System.Console.WriteLine(contaDaGabriela.saldo);
            System.Console.WriteLine(contaDaGabrielaCosta.saldo);
            
        }
    }
}
