using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.ClassesObjetos.Estruturas
{
    internal class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }

        // método para retornar os dados do endereço:
        public string GetEndereco()
        {
            return $"Logradouro: {Logradouro}\nNúmero: {Numero}\nCidade: {Cidade}";
        }
    }
}
