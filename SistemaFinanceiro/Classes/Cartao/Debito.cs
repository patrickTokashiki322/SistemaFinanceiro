using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Classes.Cartao
{
    internal class Debito
    {

        public Debito(Despesas.Despesa despesa, ContaBancaria.ContaBancaria contaBancaria)
        {
            contaBancaria.saldo -= despesa.valor;

            despesa.status = "Pago";

            Console.WriteLine("Pagamento efetuado com sucesso!");
            Console.WriteLine("");
        }
    }
}
