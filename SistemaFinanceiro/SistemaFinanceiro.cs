using SistemaFinanceiro.Classes;
using SistemaFinanceiro.Classes.ContaBancaria;

namespace SistemaFinanceiro
{
    internal class SistemaFinanceiro
    {
        static void Main(string[] args)
        {
            GerenciadorBancario gerenciadorBancario = new GerenciadorBancario();
            ContaBancaria contaBancaria = new ContaBancaria();

            gerenciadorBancario.AtualizarStatusDespesas();

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
                Console.WriteLine($"Saldo: {contaBancaria.saldo}\n");

                Console.WriteLine("Selecione a operação desejada:");
                Console.WriteLine("1 - Depositar valores");
                Console.WriteLine("2 - Sacar valores");
                Console.WriteLine("3 - Adicionar conta a pagar");
                Console.WriteLine("4 - Listar contas pendentes");
                Console.WriteLine("5 - Pagar conta");
                Console.WriteLine("Insira qualquer outro número para sair");

                int operacao = Convert.ToInt16(Console.ReadLine());

                Console.Clear();

                switch (operacao)
                {
                    case 1:
                        gerenciadorBancario.AdicionarValorSaldo(contaBancaria);
                        break;

                    case 2:
                        gerenciadorBancario.DescontarValorSaldo(contaBancaria);
                        break;

                    case 3:
                        gerenciadorBancario.AdicionarDespesa();
                        break;

                    case 4:
                        gerenciadorBancario.ListarDespesas();
                        break;

                    case 5:
                        gerenciadorBancario.PagarDespesa(contaBancaria);
                        break;

                    default:
                        Console.WriteLine("Até logo!");
                        return;
                }
            }           
        }
    }
}