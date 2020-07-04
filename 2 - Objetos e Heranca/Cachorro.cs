using System;

namespace EnsinandoPrograma.ObjetosEHeranca
{
    class Cachorro : Quadrupede
    {
        public String raca { get; set; }

        public Cachorro(String tipo, String racaDog) : base(tipo)
        {
            raca = racaDog;
        }

        public override void whatDoesTheFoxSay()
        {
            Console.WriteLine("Au Au");
        }
    }
}
