using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class FabricarProdutoA : FabricaDeProduto
    {
        public override Produto MetodoFabrica()
        {
            return  new ProdutoConcretoA();
        }
    }
}