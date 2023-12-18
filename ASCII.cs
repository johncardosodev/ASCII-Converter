using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    internal class ASCII
    {
        //Esta classe será para converter strings em ASCII
        //Converte uma string ASCII para Hexadecimal
        public string StringToHexadecimal(string str,string delimitador)
        {
            //Instanciando a classe StringBuilder
            StringBuilder sb = new StringBuilder();

            //Convertendo a string para um array de char
            char[] array = str.ToCharArray();

            //Percorrendo o array de char
            foreach (char c in array)
            {
                //find last iteration in foreach loop
                if (c == array.Last())
                {
                    sb.Append(String.Format("{0:X}", Convert.ToInt32(c)));

                }
                else
                {
                    //Convertendo o char para hexadecimal
                    sb.Append(String.Format("{0:X}{1}", Convert.ToInt32(c), delimitador));
                }
            }

            //Retornando o valor hexadecimal
            return sb.ToString();
        }

        //funcao para converter string ASCII para Binario
        public string StringToBinary(string str, string delimitador)
        {
            //Instanciando a classe StringBuilder
            StringBuilder sb = new StringBuilder();

            //Convertendo a string para um array de char
            char[] array = str.ToCharArray();

            //Percorrendo o array de char
            foreach (char c in array)
            {
                //find last iteration in foreach loop
                if (c == array.Last())
                {
                    sb.Append(Convert.ToString(c, 2));

                }
                else
                {
                    //Convertendo o char para binario
                    sb.Append(Convert.ToString(c, 2) + delimitador);
                }
            }

            //Retornando o valor binario
            return sb.ToString();
        }

        //funcao para converter string ASCII para decimal
        public string StringToDecimal(string str, string delimitador)
        {
            //Instanciando a classe StringBuilder
            StringBuilder sb = new StringBuilder();

            //Convertendo a string para um array de char
            char[] array = str.ToCharArray();

            //Percorrendo o array de char
            foreach (char c in array)
            {
                //find last iteration in foreach loop
                if (c == array.Last())
                {
                    sb.Append(Convert.ToInt32(c));

                }
                else
                {
                    //Convertendo o char para decimal
                    sb.Append(Convert.ToInt32(c) + delimitador);
                }
            }

            //Retornando o valor decimal
            return sb.ToString();
        }
    }
}
