using System;

namespace ProjetoIntegrador_OB
{
    public class Pessoas
    {
        private int idade { get; set; }
        private string nome { get; set; }

        /*-----------------------------------------*/

        public Pessoas(int Idade , string Nome)
        {

            nome =  Nome;

            idade = Idade;
        }

        public int GetIdade()
        {
            return idade;
        }

        public string SetNome()
        {
            return nome;
        }

        public override string ToString()
        {
            return "O aluno " +
                SetNome() +
                " possui " +
                GetIdade() +
                " de idade.";
        }

    }
}
