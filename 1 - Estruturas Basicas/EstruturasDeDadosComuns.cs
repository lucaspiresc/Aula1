using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EnsinandoPrograma.EstruturasBasicas
{
    static class EstruturasDeDadosComuns
    {
        public static void estruturasDeDados()
        {
            lista();
            dicionario();
            hash();
            matriz();
        }

        private static void lista()
        {
            List<String> listaNomes = new List<String>()
            {
                "Pires",
                "Cubano",
                "Pedro",
                "Jesus"
            };

            listaNomes = listaNomes.OrderBy(nome => nome).ToList();

            listaNomes.Add("Cleiton");
            listaNomes.RemoveAt(4);

            listaNomes.Add("Cleiton");
            listaNomes.Remove("Cleiton");

            listaNomes.RemoveRange(0, 2);

            String primeiroDaLista = listaNomes.ElementAt(0);
            String primeiroDaListaOutraOpcao = listaNomes[0];

            int inidicePedro = listaNomes.IndexOf("Pedro");
        }

        private static void dicionario()
        {
            Dictionary<String, int> dicionario = new Dictionary<string, int>()
            {
                { "Pires", 10 },
                { "Cubano", 1 },
                { "Pedro", 0 },
                { "Jesus", -1 }
            };
            dicionario.Add("Cleiton", 666);
            dicionario.Remove("Cleiton");

            int valorJesus = dicionario["Jesus"];

            int valorPires;
            bool piresTemValor = dicionario.TryGetValue("Pires", out valorPires);
        }

        private static void hash()
        {
            Hashtable tabelaHash = new Hashtable();
            tabelaHash.Add("Pires", 10);
            tabelaHash.Add('C', 1.12);
            tabelaHash.Add(80, "El Pedro");
            tabelaHash.Add(false, new List<String>() { "Jesus", "eh", "gay" });

            var valorHashPires = tabelaHash["Pires"];
            var valorHashCubano = tabelaHash['C'];
            var valorHashPedro = tabelaHash[80];
            var valorHashJesus = tabelaHash[false];

            tabelaHash.Remove(80);
        }

        private static void matriz()
        {
            int[,] matriz = new int[3,3]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            int somaDiagonalPrincipal = 0;
            for(int coluna = 0; coluna < matriz.GetLength(0); coluna++)
            {
                for(int linha = 0; linha < matriz.GetLength(1); linha++)
                {
                    Console.Write(matriz[coluna,linha] + "  ");
                    if(coluna == linha)
                    {
                        somaDiagonalPrincipal += matriz[coluna, linha];
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("A soma da diagiona principal eh : " + somaDiagonalPrincipal);
        }
    }
}
