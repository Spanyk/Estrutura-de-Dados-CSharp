using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer15
{
    class Program
    {
        const int MAX = 20;

        static void Insere(int[] q, ref int f, int v)
        {
            q[f] = v;
            f = f + 1;
        }

        static int Remove(int[] q, ref int i)
        {
            return (q[i++]);
        }

        static bool EstaVazia(int i, int f)
        {
            if (i == f)
                return true;
            else
                return false;
        }

        static bool EstaCheia(int f)
        {
            if (f == MAX)
                return true;
            else
                return false;
        }
        static int QtdAvioes(int f, int i)
        {
            return f - i;
        }

        static void Main(string[] args)
        {
            int[] fila = new int[MAX];
            int inicio = 0, fim = 0;
            string op ="0";

            while(op != "6")
            {
                Console.WriteLine("\nMenu\n");
                Console.WriteLine("1 - Adiciona na fila\n" +
                    "2 - Consulta a quantidade de avioes\n" +
                    "3 - Autoriza a Decolagem\n" + 
                    "4 - Lista os avioes\n" +
                    "5 - consilte o primeiro da fila\n");
                Console.Write(">> Digite a opção desejada: ");
                op = Console.ReadLine();

                if(op == "1")
                {
                    Console.Write(">> Número do Avião: ");
                    int aviao;

                    aviao = int.Parse(Console.ReadLine());
                    fila[fim] = aviao;
                    Insere(fila, ref fim, aviao); // add o avião ao ultimo item da fila, no caso 0
                    if (EstaCheia(fim) == false)
                        Insere(fila, ref fim, aviao);
                    else
                        Console.WriteLine(">> Fila Cheia!");
                }
                else if(op == "2")
                {
                    int qtd = QtdAvioes(fim, inicio);
                    Console.WriteLine(">> Quantidade de aviões: " + qtd);
                }
                else if(op == "3")
                {
                    int aviao;
                    aviao = Remove(fila, ref inicio);
                    Console.WriteLine("\nAvião que decolou: " + aviao);
                }

            }
        }
    }
}
