using EnsinandoPrograma.EstruturasBasicas;
using EnsinandoPrograma.ObjetosEHeranca;
using EnsinandoPrograma.TrabalhandoOsDados;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EnsinandoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            estruturasBasicas();

            objetosHeranca();

            operacoesComuns();
        }
        
        private static void estruturasBasicas()
        {
            VariaveisPrimitivas.variaveis();
            EstruturasDeDadosComuns.estruturasDeDados();
        }

        private static void objetosHeranca()
        {
            Quadrupede raposa = new Quadrupede("Canino");
            raposa.whatDoesTheFoxSay();

            Cachorro doguinho = new Cachorro("Canino", "Shiba Inu");
            doguinho.whatDoesTheFoxSay();

            Gato gatinho = new Gato("Preto");
            gatinho.whatDoesTheFoxSay();

            Quadrupede metamorfo = new Cachorro("Canino", "Akita");
            metamorfo.whatDoesTheFoxSay();

            metamorfo = new Gato("Branco");
            metamorfo.whatDoesTheFoxSay();
        }

        private static void operacoesComuns()
        {
            List<String> valores = new List<String>()
            {
                "Pires",
                "Cubano",
                "Pedro",
                "Jesus"
            };
            String elemento;
            elemento = OperacoesComuns.pegarElementoListaVersao1(valores, "Pires");
            elemento = OperacoesComuns.pegarElementoListaVersao1(valores, "Cleiton");

            elemento = OperacoesComuns.pegarElementoListaVersao2(valores, "Pedro");
            elemento = OperacoesComuns.pegarElementoListaVersao2(valores, "Cleiton");

            elemento = OperacoesComuns.pegarElementoListaVersao3(null, "Pedro");

            OperacoesComuns.deletarElementosDiferentesLista(valores, "Pires");

            Quadrupede bixo = new Cachorro("Canino", "Labrador");
            OperacoesComuns.verificarTipoAnimalVersao1(bixo);
            bixo = new Gato("Preto");
            OperacoesComuns.verificarTipoAnimalVersao2(bixo);

            OperacoesComuns.switchCaseMuitoLoco();

            OperacoesComuns.enquantoFaca();
            OperacoesComuns.facaEnquanto();

            Dictionary<String, int> dicionario = new Dictionary<string, int>()
            {
                { "Pires", 10 },
                { "Cubano", 1 },
                { "Pedro", 0 },
                { "Jesus", -1 }
            };
            OperacoesComuns.iterarDicionario(dicionario);

            Hashtable tabelaHash = new Hashtable();
            tabelaHash.Add("Pires", 10);
            tabelaHash.Add('C', 1.12);
            tabelaHash.Add(80, "El Pedro");
            tabelaHash.Add(false, new List<String>() { "Jesus", "eh", "gay" });
            OperacoesComuns.iterarHash(tabelaHash);
        }
    }
}
