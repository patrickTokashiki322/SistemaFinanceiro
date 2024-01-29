using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Classes.ContaBancaria
{
    public class ContaBancaria
    {
        public double saldo { get; set; } = 5000.00;

        public List<Despesas.Despesa> despesasContaBancaria = new List<Despesas.Despesa>();

        public void Depositar(ContaBancaria contaBancaria, double valor)
        {
            contaBancaria.saldo += valor;

            Console.WriteLine($"Depósito realizado com sucesso!");
            Console.WriteLine($"Saldo: {contaBancaria.saldo}\n");
        }

        public void Saque(ContaBancaria contaBancaria, double valor)
        {
            contaBancaria.saldo -= valor;

            Console.WriteLine($"Saque realizado com sucesso!");
            Console.WriteLine($"Saldo: {contaBancaria.saldo}\n");
        }
    }

}
