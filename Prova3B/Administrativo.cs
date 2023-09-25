using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3B
{
    internal class Administrativo:Funcionario
    {
        public Administrativo() { }
        public Administrativo(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario)
            : base(nome, cpf, matricula, dataNascimento, sexo, salario) { }

        public override void AdicionarSalario(double valor)
        {
            if (valor > 0)
            {
                Salario = 150 + (valor / 100 * 15) + valor; 
            }
            else
            {
                Console.WriteLine("Valor Invalido!");
            }
        }
    }
}
