using System;
using System.Collections.Generic;
using System.Text;

namespace EnsinandoPrograma.ObjetosEHeranca
{
    class Quadrupede
    {
        public String felinoOuCanino { get; set; }

        public Quadrupede(String tipo)
        {
            this.felinoOuCanino = tipo;
        }

        public virtual void whatDoesTheFoxSay()
        {
            Console.WriteLine("Ring-ding-ding-ding-dingeringeding");
        }
    }
}
