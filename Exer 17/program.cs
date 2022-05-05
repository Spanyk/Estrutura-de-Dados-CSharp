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
            public string nome;
            public int idade;
            public string sexo;
            public tp_no prox;
        }

        static void Insere(ref tp_no t, string n)
        {
            tp_no no = new tp_no();
            no.nome = n;
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
            string opcao;

            Console.WriteLine("\n|=========== Menu ==========|");
            Console.WriteLine("\n[1] Inserir\n[2] Excluir\n[3] Exibir\n[4] Encerar\n");
            opcao = Console.ReadLine();
            while(stop != false)
            {
                if (opcao == "1")
                {

                }

                else if (opcao == "2")
                {

                }

                else if (opcao == "3")
                {

                }

                else if (opcao == "4")
                {
                    Console.WriteLine("\n\n:)");
                    stop = false; 
                }
            }
            
        }
    }
}
