using System;

namespace ProjetoIntegrador_OB
{
    public class Pessoas
    {
        public int idade { get; private set; }
        public string nome { get; private set; }

        /*-----------------------------------------*/

        public Pessoas(int Idade , string Nome)
        {
            nome = Nome;
            idade = Idade;
        }


    }
}
