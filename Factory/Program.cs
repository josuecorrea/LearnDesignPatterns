using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaDeProduto[] produtos = new FabricaDeProduto[2];
            produtos[0] = new FabricarProdutoA();
            produtos[1] = new FabricarProdutoB();

            foreach (var produto in produtos)
            {
                Produto _produto = produto.MetodoFabrica();
                Console.WriteLine($"Produto Criado: {_produto.GetType().Name}");

            }

            Console.ReadKey();


        }
    }
}
