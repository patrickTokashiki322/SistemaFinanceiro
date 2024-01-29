using SistemaFinanceiro.Classes.Despesas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Classes
{
    public class DespesasRepositorio
    {
        private List<Despesas.Despesa> db = new List<Despesas.Despesa>();

        public DespesasRepositorio()
        {
            db.Add(new Despesas.Despesa(1, 100, DateTime.Parse("11-01-2023"), "Mudança de pendente para atrasado 1"));
            db.Add(new Despesas.Despesa(2, 1000, DateTime.Parse("11-02-2023"), "Mudança de pendente para atrasado 2"));
            db.Add(new Despesas.Despesa(3, 10000, DateTime.Parse("11-03-2023"), "Mudança de pendente para atrasado 3"));
        }

        public List<Despesas.Despesa> ConsultarDespesas()
        {
            return db;
        }

        public void GravarDespesa(Despesas.Despesa despesa)
        {
            db.Add(despesa);
        }

        public bool ExisteDespesa(int id)
        {
            return this.db.Any(T => T.id == id);
        }

        public void ListarDespesas()
        {
            Console.WriteLine("Segue abaixo sua lista de contas pendentes:\n");
            Console.WriteLine("--------------------");

            foreach (var despesa in this.ConsultarDespesas())
            {
                Console.WriteLine($"ID: {despesa.id}");
                Console.WriteLine($"Descrição: {despesa.descricao}");
                Console.WriteLine($"Valor: {despesa.valor}");
                Console.WriteLine($"Data de vencimento: {despesa.dataDeVencimento}");
                Console.WriteLine($"Status: {despesa.status}");
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("");
        }
    }
}
