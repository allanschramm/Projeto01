using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.ClassesObjetos.Classes
{
    internal class Aluno: Pessoa
    {
        public int Matricula { get; set; }
        public Curso CursoInfo { get; set; }
    }
}
