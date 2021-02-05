using System;
using System.Collections.Generic;
using Listas.classes;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criamos a lista 
            List<Produto> produtos = new List<Produto>();
            //Adicionamos produtos através de instâncias com construtores 

            //Adicionamos produtos através de instâncias com construtores
            produtos.Add(new Produto(1, "Maça", 20f));
            produtos.Add(new Produto(2, "Manga", 30f));
            produtos.Add(new Produto(3, "Abacate", 40f));
            produtos.Add(new Produto(4, "Açai", 50f));
            produtos.Add(new Produto(5, "Acerola", 60f));
            

            //Ou através de instâncias básicas 
            Produto maça = new Produto();
            maça.Codigo = 6;
            maça.Nome = "Maça";
            maça.Preco = 20f;

            produtos.Add(maça);

            //Podemos mostrar os produtos com foreach
            foreach(Produto p in produtos){
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
                
            }

            //Podemos remover itens através de seu indice array:
            // Linha removida na posição 3 do array: Produto:(4, "Amora", 20f);
            produtos.RemoveAt(2);

            //Também podemos remover um produto da linha usando exprressão lambada e o método removeAll:
            produtos.RemoveAll( x => x.Nome == "Açai");

            Console.WriteLine("\nLista alterada: ");

            //Checamos se foi realmente removido
            foreach(Produto p in produtos){
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
                
            }

            
        }
    }
}
