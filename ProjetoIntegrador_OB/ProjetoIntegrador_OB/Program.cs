using System;


namespace ProjetoIntegrador_OB
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas Aluno1;
            Console.Write("Digite a idade do aluno: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            
            Aluno1 = new Pessoas(idade , nome);

            Console.WriteLine(Aluno1);


        }
    }
}