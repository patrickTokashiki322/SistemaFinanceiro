using SistemaFinanceiro.Classes.Despesas;
using SistemaFinanceiro.Classes.Formulario;
using SistemaFinanceiro.Tela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Classes.ContaBancaria
{
    public class GerenciadorBancario
    {
        DespesasRepositorio repositorio = new DespesasRepositorio();
        FormulariosDespesas formularioDespesa = new FormulariosDespesas();
        Tela.Tela tela = new Tela.Tela();

        public void AtualizarStatusDespesas()
        {
            var despesas = repositorio.ConsultarDespesas();
            foreach (var despesa in despesas)
            {
                if (despesa.EstaAtrasado())
                {
                    despesa.status = "Atrasado";
                }
            }
        }

        public void AdicionarValorSaldo(ContaBancaria contaBancaria)
        {
            double valor = formularioDespesa.SolicitarDeposito();

            contaBancaria.Depositar(contaBancaria, valor);

            tela.Continuar();
        }

        public void DescontarValorSaldo(ContaBancaria contaBancaria)
        {
            double valor = formularioDespesa.SolicitarSaque();

            contaBancaria.Saque(contaBancaria, valor);

            tela.Continuar();
        }

        public void AdicionarDespesa()
        {
            var formularioNovaDespesa = new FormulariosDespesas();

            var despesa = formularioNovaDespesa.SolicitarNovaDespesa(repositorio);

            if (repositorio.ExisteDespesa(despesa.id))
            {
                Console.WriteLine("Despesa existente!");
                return;
            }

            repositorio.GravarDespesa(despesa);

            formularioNovaDespesa.ImprimirDespesa(despesa);

            tela.Continuar();
        }

        public void ListarDespesas()
        {
            repositorio.ListarDespesas();

            tela.Continuar();
        }

        public void PagarDespesa(ContaBancaria contaBancaria)
        {
            int idDespesa = formularioDespesa.SolicitarDespesa();

            bool despesaExistente = repositorio.ExisteDespesa(idDespesa);

            if (despesaExistente != true)
            {
                Console.WriteLine("Despesa inexistente");
            }
            else
            {
                Console.WriteLine("Despesa encontrada!");

                var despesa = repositorio.ConsultarDespesas().FirstOrDefault(T => T.id == idDespesa);

                formularioDespesa.MetodoPagamento(despesa, contaBancaria);
            }

            tela.Continuar();

            // emitir comprovante
            // Comprovante.comprovante();
        }
    }
}
