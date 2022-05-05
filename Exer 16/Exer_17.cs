using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
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

        static void Main(string[] args)
        {
            tp_no topo = null;
            bool stop = true;

            while(stop != false)
            {
                Console.WriteLine("\n| === Menu === |");
                Console.WriteLine("[1] Inserir valor\n[2] Excluir valor\n[3] Finalizar\n");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("\n>> Digite um número: ");
                        int n = int.Parse(Console.ReadLine());
                        Insere(ref topo, n);

                        break;

                    case "2":
                        tp_no no = Remove(ref topo);
                        Console.WriteLine("\n>> Valor excluido " + no.valor);
                        break;

                    case "3":
                        stop = false;
                        break;
                }  
            }

            Console.ReadKey();
        }
    }
}
