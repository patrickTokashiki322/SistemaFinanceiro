using Microsoft.VisualBasic;
using SistemaFinanceiro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Classes
{
    internal class ContaBancaria
    {
        public static double saldo { get; set; } = 5000.00;

        public static List<Despesas> despesas = new List<Despesas>();

    }

    public class Operacoes
    {
        public static void adicionarValorSaldo()
        {
            // formulário
            Console.WriteLine("Por favor, informe o valor a ser depositado:");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            // operação
            ContaBancaria.saldo += valor;

            // relatório
            Console.WriteLine($"Depósito realizado com sucesso!");
            Console.WriteLine($"Saldo: {ContaBancaria.saldo}\n");

            Console.WriteLine("Precione qualquer tecla para continuar.");
            Console.ReadKey();

            Console.Clear();
        }

        public static void descontarValorSaldo()
        {
            // formulário
            Console.WriteLine("Por favor, informe o valor a ser sacado:");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            // operação
            ContaBancaria.saldo -= valor;

            // relatório
            Console.WriteLine($"Saque realizado com sucesso!");
            Console.WriteLine($"Saldo: {ContaBancaria.saldo}\n");

            Console.WriteLine("Precione qualquer tecla para continuar.");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
