using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_26
{
    internal class Program
    {
        class tp_no
        {
            public tp_no esq; // ramificação esquerda
            public int valor;
            public tp_no dir; // ramificação direita
        }

        static void Insere(ref tp_no r, int x)
        {
            if (r == null)
            {
                r = new tp_no();
                r.valor = x;
            }
            else if (x < r.valor)
                Insere(ref r.esq, x);
            else
                Insere(ref r.dir, x);
        }

        static tp_no Busca(tp_no r, int x)
        {
            if (r == null)
                return null;
            else if (x == r.valor)
                return r;
            else if (x < r.valor)
                return Busca(r.esq, x);
            else
                return Busca(r.dir, x);
        }

        static tp_no RetornaMaior(ref tp_no r)
        {
            if (r.dir == null)
            {
                tp_no p = r;
                r = r.esq;
                return p;
            }
            else
                return RetornaMaior(ref r.dir);
        }

        static tp_no Remove(ref tp_no r, int x)
        {
            if (r == null)
                return null;
            else if (x == r.valor)
            {
                tp_no p = r;
                if (r.esq == null)        // nao tem filho esquerdo
                    r = r.dir;
                else if (r.dir == null)  // nao tem filho direito
                    r = r.esq;
                else                          // tem ambos os filhos
                {
                    p = RetornaMaior(ref r.esq);
                    r.valor = p.valor;
                }
                return p;
            }
            else if (x < r.valor)
                return Remove(ref r.esq, x);
            else
                return Remove(ref r.dir, x);
        }

        static void EmOrdem(tp_no r)
        {
            if (r != null)
            {
                EmOrdem(r.esq);
                Console.Write("[" + r.valor + "]");
                EmOrdem(r.dir);
            }
        }

        static void PreOrdem(tp_no r)
        {
            if (r != null)
            {
                Console.Write("[" + r.valor + "]");
                PreOrdem(r.esq);
                PreOrdem(r.dir);
            }
        }

        static void PosOrdem(tp_no r)
        {
            if (r != null)
            {
                PosOrdem(r.esq);
                PosOrdem(r.dir);
                Console.Write("[" + r.valor + "]");
            }
        }

        static void Main(string[] args)
        {
            tp_no raiz = null;
            int valor;
            bool cc = true;

            while (cc)
            {
                Console.WriteLine("\nEscolha uma opção:\n[1] Inserir\n[2] Pesquisar \n[3] Remover \n[4] Exibir\n");
                string op = Console.ReadLine();

                if(op == "1")
                {
                    
                    Console.Write("\n>> Informe a Quantidade de valores a serem inseridos: ");
                    int x = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n>> Digite os números");
                    for(int i = 0; i < x; i++)
                    {
                        int n = int.Parse(Console.ReadLine());
                        Insere(ref raiz, n);
                    }
                   
                }

                else if(op == "2")
                {
                    tp_no x = raiz;

                    Console.Write("\n>> Informe o valor a ser buscado na arvore: ");
                    valor = int.Parse(Console.ReadLine());
                    x = Busca(raiz, valor);

                    if( x == null)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n" + ">>> Valor não encontrado <<<\n");
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n" + ">>> Valor encontrado <<<\n");
                        Console.ResetColor();
                    }
                }

                else if (op == "3")
                {
                    tp_no x = raiz;

                    Console.Write("\n>> Digite o valor a ser removido: ");
                    valor = int.Parse(Console.ReadLine());

                    Remove(ref raiz, valor);

                    if(x.valor != valor)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n" + ">>> Valor não encontrado <<<\n");
                        Console.ResetColor();
                    }

                    else if( raiz != null)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n" + ">>> Removido com sucesso <<<\n");
                        Console.ResetColor();
                    }
                }

                else if (op == "4")
                {
                    Console.WriteLine("\n>> Valores digitados em Ordem\n");
                    EmOrdem(raiz);
                    Console.WriteLine(" ");
                    Console.WriteLine("\n>> Valores digitados em Préordem\n");
                    PreOrdem(raiz);
                    Console.WriteLine(" ");
                    Console.WriteLine("\n>> Valores digitados em Pós ordem\n");
                    PosOrdem(raiz);
                    Console.WriteLine(" ");
                }

                else if(op == "Sair" ||  op == "sair")
                {
                    Console.WriteLine("\n.\n.\n.\n.\n.\n.\n"+ "<< Adeus :D >>");
                    cc = false;
                }
            }
        }
    }
}
