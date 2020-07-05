using EnsinandoPrograma.ObjetosEHeranca;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EnsinandoPrograma.TrabalhandoOsDados
{
    static class OperacoesComuns
    {
        public static String pegarElementoListaVersao1(List<String> lista, String valor)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Equals(valor))
                {
                    return valor;
                }
            }
            return null;
        }

        public static String pegarElementoListaVersao2(List<String> lista, String valor)
        {
            return lista.FirstOrDefault(elemento => elemento.Equals(valor));
        }

        public static String pegarElementoListaVersao3(List<String> lista, String valor)
        {
            try
            {
                return lista.FirstOrDefault(elemento => elemento.Equals(valor));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void deletarElementosDiferentesLista(List<String> lista, String valor)
        {
            lista.RemoveAll(elemento => !elemento.Equals(valor));
        }

        public static void verificarTipoAnimalVersao1(Quadrupede animal)
        {
            if (animal is Cachorro)
            {
                Console.WriteLine("Eh um doguinho!");
            }
            else if (animal is Gato)
            {
                Console.WriteLine("Eh um gatinho!");
            }
            else
            {
                Console.WriteLine("Que porra eh essa?!");
            }
        }

        public static void verificarTipoAnimalVersao2(Quadrupede animal)
        {
            String tipo = animal.GetType().Name;
            switch (tipo)
            {
                case "Cachorro":
                    Console.WriteLine("Eh um doguinho!");
                    break;
                case "Gato":
                    Console.WriteLine("Eh um gatinho!");
                    break;
                default:
                    Console.WriteLine("Que porra eh essa?!");
                    break;
            }
        }

        public static void verificarAlcanceNumeroSwitch()
        {
            Random rnd = new Random();
            int valor = rnd.Next(1, 10);
            switch (valor)
            {
                case 10:
                    break;
                case 9:
                case 8:
                case 7:
                case 6:
                    Console.WriteLine("Entre 10 e 6");
                    break;
                case 5:
                case 4:
                    Console.WriteLine("Entre 5 e 4");
                    break;
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("Entre 3 e 1");
                    break;
            }
        }

        public static void verificarAlcanceNumeroElseIf()
        {
            Random rnd = new Random();
            int valor = rnd.Next(1, 10);
            if(valor <= 10 && valor >= 6)
            {
                Console.WriteLine("Entre 10 e 6");
            }
            else if (valor <= 5 && valor >= 4)
            {
                Console.WriteLine("Entre 5 e 4");
            }
            else
            {
                Console.WriteLine("Entre 3 e 1");
            }
        }

        public static void enquantoFaca()
        {
            Random rnd = new Random();
            int valor = rnd.Next(1, 100);

            while (valor != 32)
            {
                Console.WriteLine(valor);
                valor = rnd.Next(1, 100);
            }
        }

        public static void facaEnquanto()
        {
            Random rnd = new Random();
            int valor;
            do
            {
                valor = rnd.Next(1, 100);
                Console.WriteLine(valor);
            } while (valor != 32);
        }

        public static void iterarDicionario(Dictionary<String, int> dicionario)
        {
            foreach (KeyValuePair<String, int> par in dicionario)
            {
                Console.WriteLine("Chave: {0} - Valor: {1}", par.Key, par.Value);
            }
        }

        public static void iterarHash(Hashtable hash)
        {
            foreach (DictionaryEntry par in hash)
            {
                Console.WriteLine("Chave: {0} - Valor: {1}", par.Key, par.Value);
            }
        }
    }
}
