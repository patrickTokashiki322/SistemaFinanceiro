using SistemaFinanceiro.Classes.ContaBancaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Classes.Despesas
{
    public class Despesa : IDespesas
    {
        public int id { get; set; }
        public double valor { get; set; }
        public DateTime dataDePagamento { get; set; }
        public DateTime dataDeVencimento { get; set; }
        public string status { get; set; }
        public string descricao { get; set; }

        public Despesa(int id, double valor, DateTime dataDeVencimento, string descricao, string status = "Pendente")
        {
            this.id = id;
            this.valor = valor;
            this.dataDePagamento = dataDePagamento;
            this.dataDeVencimento = dataDeVencimento;
            this.status = status;
            this.descricao = descricao;
        }

        public bool EstaAtrasado()
        {
            return this.dataDeVencimento < DateTime.Now.Date && this.status != "Atrasado";
        }
    }
}
