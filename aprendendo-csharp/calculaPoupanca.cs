using System;

double valorInvestido = 1000;
double valorInvestidoFor = 1000;
int contadorMes = 1;

System.Console.WriteLine("==================While==================");

while (contadorMes <= 12)
{    
    valorInvestido = valorInvestido + valorInvestido * 0.0036;
    System.Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

//    contadorMes = contadorMes + 1;
//    contadorMes += 1;
contadorMes++;
}
System.Console.WriteLine("");
System.Console.WriteLine("==================For==================");

for (int contaMes = 1; contaMes <= 12; contaMes++)
{
    valorInvestidoFor *= 1.0036;
    System.Console.WriteLine("Após " + contaMes + " meses, você terá R$" + valorInvestidoFor);
}

//0.36% = 0.0036
// valorInvestido = valorInvestido + valorInvestido * 0.0036;
// System.Console.WriteLine("Após 1 mês, você terá R$" + valorInvestido);

// valorInvestido = valorInvestido + valorInvestido * 0.0036;
// System.Console.WriteLine("Após 2 meses, você terá R$" + valorInvestido);

        
    

