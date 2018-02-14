using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectLeadProgram
{
    class Program
    {
        static List<int> inv = new List<int>();
        static int qtdItens, qtdMaiores, pos;
        static float media, soma;
        static List<float> resultado = new List<float>();

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Console.WriteLine("--- Lista ---");
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("a) Recursivo que imprima a média dos elementos de uma lista de inteiros e o número de elementos maiores do que a média.");
            Console.WriteLine();

            qtdItens = list.Count();
            pos = 0;
            List<float> mediaElementos = mediaQtdElementosMaiores(list, qtdItens, pos);

            Console.WriteLine("Número de elementos maiores que a média: " + mediaElementos[1]);
            Console.WriteLine("Média dos elementos: " + mediaElementos[0]);
            Console.WriteLine();

            Console.WriteLine("b) Recursivo que retorne uma lista de forma invertida");
            Console.WriteLine();
            List<int> listaInvertida = inverterLista(list);
            foreach (var item in listaInvertida)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }

        static List<int> inverterLista(List<int> list)
        {
            if (list.Count() > 0)
            {
                inv.Add(list[list.Count() - 1]);
                list.RemoveAt(list.Count() - 1);
                inverterLista(list);
            }
            return inv;
        }

        static List<float> mediaQtdElementosMaiores(List<int> list, int qtdItens, int pos)
        {
            media = mediaElementos(list, qtdItens, pos);
            resultado.Add(media);
            resultado.Add(elementosMaiores(list, qtdItens, pos, media));
            return resultado;
        }

        static float mediaElementos(List<int> list, int qtdItens, int pos)
        {
            if (pos < qtdItens)
            {
                soma = soma + list[pos];
                pos++;
                mediaElementos(list, qtdItens, pos);
            }
            media = soma / qtdItens;
            return media;
        }

        static int elementosMaiores(List<int> list, int qtdItens, int pos, float med)
        {
            if (pos < qtdItens)
            {
                if (list[pos] > med)
                {
                    qtdMaiores++;
                }
                pos++;
                elementosMaiores(list, qtdItens, pos, med);
            }
            return qtdMaiores;
        }
    }
}
