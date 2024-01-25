using SistemaFinanceiro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Classes
{
    public class Despesas : IDespesas
    {
        public int id { get; set; }
        public double valor { get; set; }
        public DateOnly dataDePagamento { get; set; }
        public DateOnly dataDeVencimento { get; set; }
        public string status { get; set; }
        public string descricao { get; set; }

        public static void adicionarConta()
        {
            // formulário
            Console.WriteLine("Informe o id da conta:");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Informe o valor da conta a pagar:");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine($"Informe a data de vencimento dd-mm-aaaa");
            DateOnly dataDeVencimento = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine($"A data de vencimento será no dia: {dataDeVencimento}\n");

            Console.WriteLine("Informe a descrição da conta:");
            string descricao = Console.ReadLine();
            Console.WriteLine("");

            var despesa = ContaBancaria.despesas.FirstOrDefault(i => i.id == id);

            if (despesa.id == id)
            {
                Console.WriteLine("Despesa existente!");
            }
            else
            {
                // operação
                ContaBancaria.despesas.Add(new Despesas() { id = id, valor = valor, dataDeVencimento = dataDeVencimento, status = "Pendente", descricao = descricao });

                // relatório
                Console.WriteLine("Conta adicionada com sucesso!");
                Console.WriteLine("--------------------");
                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Descrição: {descricao}");
                Console.WriteLine($"Valor: {valor}");
                Console.WriteLine($"Data de vencimento: {dataDeVencimento}");
                Console.WriteLine($"Status: Pendente");
                Console.WriteLine("--------------------\n");
            }

            Console.WriteLine("Precione qualquer tecla para continuar.");
            Console.ReadKey();

            Console.Clear();
        }

        public static void listarContas()
        {
            // relatório
            Console.WriteLine("Segue abaixo sua lista de contas pendentes:\n");
            Console.WriteLine("--------------------");

            foreach (var despesa in ContaBancaria.despesas)
            {
                Console.WriteLine($"ID: {despesa.id}");
                Console.WriteLine($"Descrição: {despesa.descricao}");
                Console.WriteLine($"Valor: {despesa.valor}");
                Console.WriteLine($"Data de vencimento: {despesa.dataDeVencimento}");
                Console.WriteLine($"Status: {despesa.status}");
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("");
            Console.WriteLine("Precione qualquer tecla para continuar.");
            Console.ReadKey();

            Console.Clear();
        }

        public static void pagarConta()
        {
            // formulário
            Console.WriteLine("Informe o ID da conta a pagar:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            bool despesaExistente = ContaBancaria.despesas.Exists(T => T.id == id);

            if (despesaExistente != true)
            {
                Console.WriteLine("Despesa inexistente");
            }
            else
            {
                Console.WriteLine("Despesa encontrada!");

                var despesa = ContaBancaria.despesas.FirstOrDefault(T => T.id == id);

                Console.WriteLine("Qual o método de pagamento?");
                Console.WriteLine("1 - Débito");
                Console.WriteLine("2 - Crédito");
                int operacao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (operacao)
                {
                    case 1:

                        if (ContaBancaria.saldo < despesa.valor)
                        {
                            Console.WriteLine("Saldo insulficiente!");
                        }
                        else {
                            ContaBancaria.saldo -= despesa.valor;

                            despesa.status = "Pago";

                            Console.WriteLine("Pagamento efetuado com sucesso!");
                        }

                        break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Precione qualquer tecla para continuar.");
            Console.ReadKey();

            Console.Clear();

            // emitir comprovante
            // Comprovante.comprovante();
        }
    }
}
