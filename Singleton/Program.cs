using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Singleton é um padrão de projeto de software (do inglês Design Pattern). Este padrão garante a existência de
    //apenas uma instância de uma classe, mantendo um ponto global de acesso ao seu objeto
    //Esse padrão é muito utilizado quando o algoritmo trabalha com instâncias de classes que não alteram seus estados
    //ou quando há necessidade de utilizar algum método especifico da classe, várias vezes.Algo que seria um problema 
    //sem o Singleton.Muitas instâncias seriam criadas somente para utilizar alguns métodos, esse sendo independentes do estado do objeto.
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }
    }
}
