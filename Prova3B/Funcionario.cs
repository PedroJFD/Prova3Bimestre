using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3B
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Salario = salario;
        }

        public virtual void AdicionarSalario(double valor)
        {
            if(valor > 0)
            {
                Salario = valor;
            }
            else
            {
                Console.WriteLine("Valor Invalido!");
            }
        }
    }
}
