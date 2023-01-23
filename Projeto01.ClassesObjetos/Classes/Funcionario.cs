using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.ClassesObjetos.Classes
{
    internal class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        private double _salario;
        public double Salario 
        { 
            get => _salario; 
            set
            {
                _salario = value;
                Irpf = _salario * 0.1;
            }
        }
        public double Irpf { get; private set; }

    }
}
