using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> minhaLista = new List<int>(); //variavel do tipo int
            //Para adicionar  ==> Add
            minhaLista.Add(90);
            minhaLista.Add(20);
            minhaLista.Add(60);
            minhaLista.Add(10);
            minhaLista.Add(70);
            minhaLista.Add(30);

            // List<int> outraLista = new List<int>();
            // outraLista.Add(15);
            // outraLista.Add(25);
            // outraLista.Add(35);
            
            //System.Console.WriteLine(minhaLista.Capacity); //Capacidade alocada em memoria
            //System.Console.WriteLine(minhaLista.Count); //realizar a contagem de quanto itens tem na lista

            // foreach (int item in minhaLista)
            // {
            //     System.Console.WriteLine(item); 
            // }
           
            //  (inicializacao;TesteLogico;incremento)
            // for (int i=0; i<minhaLista.Count; i++)
            // {
            //     System.Console.WriteLine(minhaLista[i]);
            // }

            // minhaLista.AddRange(outraLista); //Adicionando um lista dentro de outra lista.

            // if(minhaLista.Contains(11))
            // {
            //     System.Console.WriteLine("Está na lista");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não está na lista");
            // }

            // minhaLista.Clear();  //Metodo para limpar uma lista.

            // minhaLista.Insert(2, 25); //Insere um item a lista no indice de exemplo "2".

            // minhaLista.InsertRange(2, outraLista); // Insere uma outra lista a parti do indice definido "2"

            // if(minhaLista.Remove(20))
            //     System.Console.WriteLine("Removido com sucesso");  //Remove um item especifico da lista
            // else
            //     System.Console.WriteLine("Não encontrado");

            // minhaLista.RemoveAt(3); //Remove o item do indice especificado "3"

            // minhaLista.Sort(); // Ordena a lista de forma crescente.

            foreach (int item in minhaLista)
            {
                System.Console.WriteLine(item); 
            }

            Console.ReadKey();
        }
    }
}
