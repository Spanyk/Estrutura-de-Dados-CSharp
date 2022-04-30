using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_16
{
    internal class Program
    {
        class tp_no
        {
            public int valor;
            public tp_no prox;
        }

        static void Insere(ref tp_no t, int v)
        {
            tp_no no = new tp_no();
            no.valor = v;
            if (t != null)
                no.prox = t;
            t = no;
        }

        static tp_no Remove(ref tp_no t)
        {
            tp_no no = null;
            if (t != null)
            {
                no = t;
                t = t.prox;
                no.prox = null;
            }
            return no;
        }

        public static void Main(string[] args)
        {
            tp_no topo = null;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("n°: ");
                int num = int.Parse(Console.ReadLine());
                Insere(ref topo, num);
            }
            for(int i = 0; i < 5; i++)
            {
                var valor = Remove(ref topo);
                Console.WriteLine(valor);
            }

            Console.ReadKey();
        }
    }
}
