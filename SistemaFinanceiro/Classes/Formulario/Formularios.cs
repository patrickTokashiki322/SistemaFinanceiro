using SistemaFinanceiro.Classes.Cartao;
using SistemaFinanceiro.Classes.ContaBancaria;
using SistemaFinanceiro.Classes.Despesas;
using SistemaFinanceiro.Tela;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Classes.Formulario
{
    internal class Formularios
    {

        public Despesa SolicitarNovaDespesa()
        {
            Console.WriteLine("Informe o id da conta:");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Informe o valor da conta a pagar:");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine($"Informe a data de vencimento dd-mm-aaaa");
            DateTime dataDeVencimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"A data de vencimento será no dia: {dataDeVencimento}\n");

            Console.WriteLine("Informe a descrição da conta:");
            string descricao = Console.ReadLine();
            Console.WriteLine("");

            return new Despesa(id, valor, dataDeVencimento, descricao);
        }

        public int SolicitarDespesaExistente()
        {
            Console.WriteLine("Informe o ID da conta a pagar:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            return id;
        }

        public void ImprimirDespesa(Despesa despesa)
        {
            Console.WriteLine("Conta adicionada com sucesso!");
            Console.WriteLine("--------------------");
            Console.WriteLine($"ID: {despesa.id}");
            Console.WriteLine($"Descrição: {despesa.descricao}");
            Console.WriteLine($"Valor: {despesa.valor}");
            Console.WriteLine($"Data de vencimento: {despesa.dataDeVencimento}");
            Console.WriteLine($"Status: Pendente");
            Console.WriteLine("--------------------\n");
        }

        public void MetodoPagamento(Despesa despesa, ContaBancaria.ContaBancaria contaBancaria)
        {
            Console.WriteLine("Qual o método de pagamento?");
            Console.WriteLine("1 - Débito");
            Console.WriteLine("2 - Crédito");
            int operacao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (operacao)
            {
                case 1:

                    if (contaBancaria.saldo < despesa.valor)
                    {
                        Console.WriteLine("Saldo insulficiente!");
                    }
                    else
                    {
                        Debito debito = new Debito(despesa, contaBancaria);
                    }

                    break;

                case 2:

                    Console.WriteLine("Em breve!!!");
                    break;
            }
        }

        public double SolicitarDeposito()
        {
            Console.WriteLine("Por favor, informe o valor a ser depositado:");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            return valor;
        }

        public double SolicitarSaque()
        {
            Console.WriteLine("Por favor, informe o valor a ser sacado:");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            return valor;
        }
    }
}
