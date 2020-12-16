using System;
using ListaObjetos.Classe;
using System.Collections.Generic;
namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<produto> produtos = new List<produto>();
        
            produto[] arrayProdutos = {};

            produtos.Add(new produto(10,"Galaxy pocket", 155.14f));
            produtos.Add(new produto(25,"Redmi airdots", 205.54f));
            produtos.Add(new produto(98,"Samsung airbuds", 115.88f));
            produtos.Add(new produto(106,"Xiaomi Mi Note 5", 865.62f));


            produto p1 = new produto();
            p1.Codigo = 67;
            p1.Nome = "Iponei 27";
            p1.Preco = 9235.65f;

            produtos.Add(p1);

            foreach (produto Elementos  in produtos)
            {
                Console.WriteLine(Elementos.Nome);
            }

            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine();
            }
            
            foreach (produto item in produtos)
            {
               Console.WriteLine(item.Nome); 
            }

            produtos.RemoveAt(3);

            Console.WriteLine("\nRemoção Feita\n");
        }
    }
}
