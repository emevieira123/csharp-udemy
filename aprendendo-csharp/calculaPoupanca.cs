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

double investimento = 1000;
double fatorRandimento = 1.0036;

for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
{
    for(contadorMes = 1; contadorMes <=12; contadorMes++)
    {
        investimento *= fatorRandimento;
    }
    fatorRandimento += 0.0010;
   
}

System.Console.WriteLine("Ao termino de 5 anos do investimento você terá R$" + investimento);

//*
//**
//***
//****
//*****
//******
//*******
// Escrevendo asteriscos com o Break
for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
    {
        System.Console.Write("*");
        if (contadorColuna >= contadorLinha)
            break;
    }
    System.Console.WriteLine();
}

//Uma forma diferente de desenhar os asteriscos
for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for(int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
    {
        System.Console.Write("*");
    }
    System.Console.WriteLine();
}


//0.36% = 0.0036
// valorInvestido = valorInvestido + valorInvestido * 0.0036;
// System.Console.WriteLine("Após 1 mês, você terá R$" + valorInvestido);

// valorInvestido = valorInvestido + valorInvestido * 0.0036;
// System.Console.WriteLine("Após 2 meses, você terá R$" + valorInvestido);

        
    

