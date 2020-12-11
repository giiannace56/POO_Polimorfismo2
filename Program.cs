using System;
using aula_11_12_presencial.classes;

namespace aula_11_12_presencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("paulo");
            fun.Mostrar(2);

        }
    }
}
