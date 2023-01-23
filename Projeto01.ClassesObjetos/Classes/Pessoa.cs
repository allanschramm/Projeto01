using Projeto01.ClassesObjetos.Enumeracoes;
using Projeto01.ClassesObjetos.Estruturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.ClassesObjetos.Classes
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        private int _idade;
        
        // Property Expression
        public int Idade
        {
            get => _idade;
            set => _idade = value >= 0 ? value : throw new ArgumentException("Idade inválida");
        }

        public Sexos Sexo { get; set; }
        public Endereco EnderecoInfo { get; set; }

        // método para retornar os dados da Pessoa
        public string GetPessoa()
        {
            return $"Nome: {Nome}\nIdade: {Idade}\nSexo: {Sexo}\n" +
                $"\nDados do Endereço: \n{EnderecoInfo.GetEndereco()}";
        }
    }
}
