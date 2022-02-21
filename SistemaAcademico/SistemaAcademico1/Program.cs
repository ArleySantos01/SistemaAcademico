using System;
using SistemaAcademico1.model;

namespace SistemaAcademico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objAluno = new Aluno(); //Metodo construtor 
            int x;
            objAluno.cpf = 123456789;
            objAluno.nome = "João";
            objAluno.DtNascimento = new DateTime(1998, 5, 9);
            Professor joao = new Professor();
            Console.WriteLine("Hello World!");
            Console.WriteLine(objAluno.cpf);
            Console.WriteLine(objAluno.nome);
            Console.WriteLine(objAluno.DtNascimento);

        }
    }
}
