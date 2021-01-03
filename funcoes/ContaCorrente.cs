using System;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;
    }

    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            else
            {
                this.saldo = saldo;
            }
        }

        public double ObterSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}