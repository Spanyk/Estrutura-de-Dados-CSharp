using System;
using System.Text;
using System.Threading.Tasks;

namespace Exer_28
{
    internal class Program
    {
        const int N = 5;

        class Tp_no
        {
            public int nota;
            public string nome, email;
        }
        
        static int hash(int c)
        {
            return (c % N) + 1;
        }

        static void criaNos(Tp_no[] V)
        {
            int i;
            for(i =0; i < N; i++)
            {
                V[i] = new Tp_no();
            }
        }
        static void InserirLinear(Tp_no[] v, int nt, string nm, string em, ref int q)
        {
            int pos = hash(nt);
            while(v[pos].nota != 0)
            {
                pos++;
                pos = pos % N;
                q += q;
            }
            v[pos].nota = nt;
            v[pos].nome = nm;
            v[pos].email = em;
        }
        static int RecuperarLinear(Tp_no[] v, int nt)
        {
            int pos = hash(nt);
            int cont = 0;

            while(v[pos].nota != nt && cont <= N)
            {
                pos++;
                pos = pos % N;
                cont++;
            }
            if(cont <= N)
            {
                return pos;
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Tp_no[] Vetor = new Tp_no[N];
            criaNos(Vetor);
            int op = 0, nota = 0, qtde = 0;
            string nome, email;

            while(op != 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Menu");
                Console.WriteLine("1- Insere\n2- Recuperar\n3- Informar\n4- Sair\n");
                op = Convert.ToInt32(Console.ReadLine());
                
                if(op == 1)
                {
                    Console.Write(">> Nota: ");
                    nota = Convert.ToInt32(Console.ReadLine());
                    Console.Write(">> Nome: ");
                    nome = Console.ReadLine();
                    Console.Write(">> Email: ");
                    email = Console.ReadLine();

                    InserirLinear(Vetor, nota, nome, email, ref qtde);
                }
                else if (op == 2)
                {
                    Console.Write(">> Nota: ");
                    nota = Convert.ToInt32(Console.ReadLine());
                    int pos = RecuperarLinear(Vetor, nota);
                    
                    if(pos != -1)
                    {
                        Console.WriteLine(">> Nome: " + Vetor[pos].nome);
                        Console.WriteLine(">> Email: " + Vetor[pos].email);

                    }
                    else
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("<<< Não encontrado >>>");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;

                    }
                }

                else if(op == 3)
                {
                    Console.WriteLine(">> Quantidade de colisões: " + qtde);
                    Console.ReadKey();
                }
            }
        }
    }
}
