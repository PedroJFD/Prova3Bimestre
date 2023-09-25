using Prova3B;
using System;

public class Program
{
    static void Main(string[] args)
    {
        try {
            List<Funcionario> list = new List<Funcionario>();
            while (true)
            {
                Console.WriteLine("\nQual tipo de funcionario deseja cadastrar?\n\n1 - Funcionario Comum\n2 - Funcionario Medico\n3 - Funcionario Administrativo\n4 - Sair Programa & Ver Funcionarios Cadastrados");
                Console.Write("\nEscolha: ");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    Funcionario funcio = new Funcionario();
                    Console.Write("\nNome: ");
                    funcio.Nome = Console.ReadLine();

                    Console.Write("\nCpf: ");
                    funcio.Cpf = Console.ReadLine();

                    Console.Write("\nMatricula: ");
                    funcio.Matricula = Console.ReadLine();

                    Console.Write("\nData Nascimento: ");
                    funcio.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("\nSexo: ");
                    funcio.Sexo = Console.ReadLine();

                    Console.Write("\nSalario: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    funcio.AdicionarSalario(valor);

                    list.Add(funcio);
                }
                else if (escolha == "2")
                {
                    Medico med = new Medico();
                    Console.Write("\nCRM: ");
                    med.CRM = Console.ReadLine();

                    Console.Write("\nValor Hora Extra: ");
                    med.ValorHoraExtra = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nEspecialidade: ");
                    med.Especialidade = Console.ReadLine();

                    Console.Write("\nNome: ");
                    med.Nome = Console.ReadLine();

                    Console.Write("\nCpf: ");
                    med.Cpf = Console.ReadLine();

                    Console.Write("\nMatricula: ");
                    med.Matricula = Console.ReadLine();

                    Console.Write("\nData Nascimento: ");
                    med.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("\nSexo: ");
                    med.Sexo = Console.ReadLine();

                    Console.Write("\nSalario: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    med.AdicionarSalario(valor);

                    list.Add(med);
                }
                else if (escolha == "3")
                {
                    Administrativo adm = new Administrativo();
                    Console.Write("\nNome: ");
                    adm.Nome = Console.ReadLine();

                    Console.Write("\nCpf: ");
                    adm.Cpf = Console.ReadLine();

                    Console.Write("\nMatricula: ");
                    adm.Matricula = Console.ReadLine();

                    Console.Write("\nData Nascimento: ");
                    adm.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("\nSexo: ");
                    adm.Sexo = Console.ReadLine();

                    Console.Write("\nSalario: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    adm.AdicionarSalario(valor);

                    list.Add(adm);
                }
                else if (escolha == "4")
                {
                    Console.WriteLine("\nFuncionarios Cadastrados: ");
                    foreach (var item in list)
                    {
                        Console.WriteLine($"\nNome: {item.Nome}, Salario: {item.Salario.ToString("C2")}");
                    }
                    Console.WriteLine("\nSaindo do programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("\nOpção invalida!");
                }
            }
        }
        catch(Exception ex) { Console.WriteLine(ex.Message); }
    }
}