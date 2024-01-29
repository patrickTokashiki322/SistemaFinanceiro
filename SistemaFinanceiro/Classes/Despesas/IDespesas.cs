using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Classes.Despesas
{
    interface IDespesas
    {
        public int id { get; set; }
        public double valor { get; set; }
        public DateTime dataDePagamento { get; set; }
        public DateTime dataDeVencimento { get; set; }
        public string status { get; set; }
        public string descricao { get; set; }
    }
}
