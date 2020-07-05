using System;
using System.Collections.Generic;
using System.Text;

namespace EnsinandoPrograma.EstruturasBasicas
{
    static class VariaveisPrimitivas
    {
        public static void variaveis()
        {
            int inteiro = 2147483647;
            long inteiroMaior = 9223372036854775807;

            float valorDecimal = 1.37F;
            double decimalMaior = 123.31;

            char[] nomeComoVetor = new char[] { 'S', 'm', 'i', 't', 'h' };
            String nomeComoString = "Smith";

            char charAsciiCode = (char)65;
            int valorAsciiCode = (int)'C';

            bool jesusEhGay = true;

            //Nao precisa declarar o tipo necessariamente!
            var quemSouEu = "#1 na terra da danca";

            //Tipo dinamico pode mudar!
            dynamic metamorfo = 1;
            metamorfo = "Cleiton";
            metamorfo = 0;
            metamorfo = new List<String>(){ "Lista", "de", "Nomes" };
        }
    }
}
