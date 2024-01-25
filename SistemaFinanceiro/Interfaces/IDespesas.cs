using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Interfaces
{
    interface IDespesas
    {
        public int id { get; set; }
        public double valor { get; set; }
        public DateOnly dataDePagamento { get; set; }
        public DateOnly dataDeVencimento { get; set; }
        public string status { get; set; }
        public string descricao { get; set; }
    }
}
