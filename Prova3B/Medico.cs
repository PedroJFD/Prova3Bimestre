using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3B
{
    internal class Medico:Funcionario
    {
        public string CRM { get; set; }
        public double ValorHoraExtra { get; set; }
        public string Especialidade { get; set; }
        
        public Medico() { }

        public Medico(string cRM, double valorHoraExtra, string especialidade, string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario)
            :base(nome, cpf, matricula, dataNascimento, sexo, salario)
        {
            CRM = cRM;
            ValorHoraExtra = valorHoraExtra;
            Especialidade = especialidade;
        }

        public override void AdicionarSalario(double valor)
        {
            if (valor > 0)
            {
                Salario = (valor / 100 * 20) + valor;
            }
            else
            {
                Console.WriteLine("Valor Invalido!");
            }
            
        }
    }
}
