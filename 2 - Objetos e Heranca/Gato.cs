using System;

namespace EnsinandoPrograma.ObjetosEHeranca
{
    class Gato : Quadrupede
    {
        public String corGato { get; set; }

        public Gato(String cor) : base("Felino")
        {
            corGato = cor;
        }

        public override void whatDoesTheFoxSay()
        {
            Console.WriteLine("Miau Miau");
        }
    }
}
