using _01_HelloWorld.Model;
using System;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma pessoa fisica
            PessoaFisica pf = new PessoaFisica();

            //Setar um valor para o nome
            pf.Name = "Thiago";
            //Exibir o nome da pessoa
            Console.WriteLine(pf.Name);

            Console.WriteLine("Hello World!");
        }
    }
}
