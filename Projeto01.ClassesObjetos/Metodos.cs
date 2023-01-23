using Projeto01.ClassesObjetos.Classes;
using Projeto01.ClassesObjetos.Enumeracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.ClassesObjetos
{
    internal class Metodos
    {
        // método para gerar uma variável e uma instância da classe Pessoa
        public static void GetPessoa()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Gerson";
            p1.Idade = 30;
            //p1.Sexo = Sexos.Masculino;
            p1.Sexo = (Sexos)10;

            Console.WriteLine(p1.GetPessoa());
        }

        // método para gerar uma variável e uma instancia da classe Funcionario
        public static void GetFuncionario()
        {
            Funcionario p2 = new Funcionario()
            {
                Nome = "Gerson",
                Idade = 30,
                Sexo = Sexos.Masculino,
                Cargo = "Motoboy",
                Salario = 3000
            };

            Console.WriteLine(p2.GetPessoa());
        }

        // método que define uma variável do tipo Pessoa, referenciando
        // objetos de subclasses de Pessoa (Funcionario, Aluno)
        public static void GetMixPessoas()
        {
            // instanciando uma Pessoa
            Pessoa pessoa = new Pessoa()
            {
                Nome = "Adriana",
                Idade = 25,
                Sexo = Sexos.Feminino
            };

            Console.WriteLine(pessoa.GetPessoa());
            Console.WriteLine();

            pessoa = new Funcionario()
            {
                Nome = "Jeferson",
                Idade = 40,
                Sexo = Sexos.Masculino,
                Cargo = "Motorista",
                Salario = 4000
            };
            Console.WriteLine(pessoa.GetPessoa());




        }
    }
}
