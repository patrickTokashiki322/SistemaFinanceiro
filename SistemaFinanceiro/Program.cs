using SistemaFinanceiro.Classes;

namespace SistemaFinanceiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"
   _____ _     _                         ____                             _       
  / ____(_)   | |                       |  _ \                           (_)      
 | (___  _ ___| |_ ___ _ __ ___   __ _  | |_) | __ _ _ __   ___ __ _ _ __ _  ___  
  \___ \| / __| __/ _ | '_ ` _ \ / _` | |  _ < / _` | '_ \ / __/ _` | '__| |/ _ \ 
  ____) | \__ | ||  __| | | | | | (_| | | |_) | (_| | | | | (_| (_| | |  | | (_) |
 |_____/|_|___/\__\___|_| |_| |_|\__,_| |____/ \__,_|_| |_|\___\__,_|_|  |_|\___/ 
");

                Console.WriteLine("Olá Patrick!\n");
                Console.WriteLine($"Saldo: {ContaBancaria.saldo}\n");

                Console.WriteLine("Selecione a operação desejada:");
                Console.WriteLine("1 - Depositar valores");
                Console.WriteLine("2 - Sacar valores");
                Console.WriteLine("3 - Adicionar conta a pagar");
                Console.WriteLine("4 - Listar contas pendentes");
                Console.WriteLine("5 - Pagar conta");
                Console.WriteLine("Insira qualquer outro número para sair");

                int operacao = Convert.ToInt16(Console.ReadLine());

                Console.Clear();

                if (operacao == 1)
                {
                    Operacoes.adicionarValorSaldo();
                }
                else if (operacao == 2)
                {
                    Operacoes.descontarValorSaldo();
                }
                else if (operacao == 3)
                {
                    Despesas.adicionarConta();
                }
                else if (operacao == 4)
                {
                    Despesas.listarContas();
                }
                else if (operacao == 5)
                {
                    Despesas.pagarConta();
                }
                else
                {
                    Console.WriteLine("Até logo!");
                    break;
                }
            }           
        }
    }
}