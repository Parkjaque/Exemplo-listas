using System;
using System.Collections.Generic;

namespace Exemplo_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a nova lista
            List<string> list = new List<string>();
            //Adicionando elementos dentro da lista
            list.Add("Viper");
            list.Add("Reyna");
            list.Add("Jett");
            list.Add("Skye");
            list.Add("Astra");
            //Adicionando um elemento em uma posição especifica
            list.Insert(2, "Sage");
            //Removendo um elemento da lista
            list.Remove("Syke");
            //Loop para ler os elementos da lista
            foreach (string obj in list)
            {
                //Exibir no console a quantidade de elementos na lista
                Console.WriteLine("Qnt de elementos na Lista: " + list.Count);
                //Encontrar um elemento especifico que comece com a letra A
                string s1 = list.Find(x => x[0] == 'A');
                Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
                //Encontrar o ultimo elemento com a letra R
                string s2 = list.FindLast(x => x.StartsWith("R"));
                Console.WriteLine("O ultimo elemento da lista é: " + s2);
                //Encontrar um elemento de uma parte especifica da lista que começa com a letra J
                Console.WriteLine("O index com a letra J começa em: " + list.FindIndex(1, list.Count, (x => x.StartsWith("J"))));
                //Encontrar todos os elementos que comecem com a letra V
                Console.WriteLine("Todos os elementos que começam com a letra V " + list.FindAll(x => x.StartsWith("V")));
                
            }
        }

        }

    }
