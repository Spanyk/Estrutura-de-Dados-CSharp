using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_exer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            while (op != 7)
            {
                Console.WriteLine("\n---------| Menu de Exercicios |---------");
                Console.Write(">> Exer 1\n>> Exer 2\n>> Exer 3\n>> Exer 4\n>> Exer 5\n>> Exer 6 \n>> 7 Sair\n");

                Console.WriteLine("\n[ ps: O menu funciona com base no número do exercicio] ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Exer_1();
                        break;

                    case 2:
                        Console.WriteLine(">> Número ao Quadrado <<\n");
                        Exer_2();
                        Console.WriteLine();
                        break;

                    case 3:

                        Console.WriteLine(">> Número elevado ao Cubo <<\n");
                        Exer_3();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine(">> Algoritmo de Euclides <<\n");
                        Exer_4();
                        break;

                    case 5:
                        Console.WriteLine(">> Algoritmo de fibonacci <<\n");
                        Exer_5();
                        break;

                    case 6:
                        Console.WriteLine(">> Conversor Binário <<\n");
                        Exer_6();
                        break;

                    default:
                        Console.WriteLine("N/D");
                        break;
                }
            }
        }
        // ------------------------ Exer 1 ------------------------
        static void Exer_1() // main do ex1 
        {
            int op = 0, ni, nf;

            while (op != 3)
            {
                Console.WriteLine("\n====================== | Menu | ======================");
                Console.WriteLine("\n[1] Funções sem vetor\n[2] Funções com vetor\n[3] Sair\n");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("[" + "Digite o número inicial: ");
                        ni = Convert.ToInt32(Console.ReadLine());
                        Console.Write("[" + "Digite o Número final: ");
                        nf = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("====================== | Submenu | ======================");
                        Console.WriteLine("[1] Ordem crescente\n[2] Ordem decrescente\n[3] Somatório\n[4] Impares\n");

                        op = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Clear();

                        switch (op)
                        {
                            case 1:
                                Crescente(ni, nf);
                                break;
                            case 2:
                                Descrescente(ni, nf);
                                break;
                            case 3:
                                Console.WriteLine(Somatorio(ni, nf));
                                break;
                            case 4:
                                Impares(ni, nf);
                                break;
                            default:
                                Console.WriteLine("N/D");
                                break;
                        }

                        break;

                    case 2:
                        List<Int32> vetor = new List<Int32>();
                        int index = 0;
                        string Continue = "";

                        while (Continue == "S" || Continue != "N")
                        {
                            Console.Write("\n[x]" + "Digite um número: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            vetor.Add(num);
                            index++;

                            if (index == 5)
                            {
                                Console.WriteLine("\n[" + "Deseja continuar?" + "]\n");
                                Continue = Console.ReadLine();
                                Continue = Continue.ToUpper();
                                index = 0;
                                if (Continue == "N")
                                {
                                    int soma = 0;
                                    int[] vet_num = vetor.ToArray();

                                    for (int cc = 0; cc < vet_num.Length; cc++)
                                    {
                                        soma += vet_num[cc];
                                    }

                                    Console.WriteLine("Soma total dos números digitados: " + soma);

                                }
                                else
                                {
                                    Console.WriteLine("\n=========================== | PROGRAMA ENCERRADO | ===========================");

                                }
                            }
                        }

                        break;
                }
            }
            void Crescente(int nii, int nff)
            {
                if (nii <= nff)
                {
                    Console.Write("|" + $"{nii}" + "|");
                    Crescente(nii + 1, nff);
                }
            }
            void Descrescente(int nii, int nff)
            {
                if (nff >= nii)
                {
                    Console.Write("|" + $"{nff}" + "|");
                    Descrescente(nii, nff - 1);
                }
            }
            int Somatorio(int nii, int nff)
            {
                if (nii <= nff)
                {
                    return Somatorio(nii + 1, nff) + nii;
                }
                else
                {
                    return nii;
                }
            }
            void Impares(int nii, int nff)
            {
                if (nii <= nff)
                {
                    if (nii % 2 != 0)
                    {
                        Console.Write("|" + $"{nii}" + "|");
                        Impares(nii + 1, nff);
                    }
                }
            }
        }
        // ------------------------ Exer 2 ------------------------
        static void Exer_2()
        {
            int x, y;
            Console.Write(">> Digite um número: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write(">> Digite o expoente: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("<< Resultado: " + potencia(x, y) + " >>\n");
        }
        static int potencia(int n, int expoente)
        {
            if (expoente == 0)
            {
                return 1;
            }
            else
            {
                return n * potencia(n, expoente - 1);
            }
        }
        // ------------------------ Exer 3 ------------------------
        static void Exer_3()
        {
            int x;
            int i = 1;

            Console.Write(">> Digite um número: ");
            x = Convert.ToInt32(Console.ReadLine());
            cubo(x, i);
        }
        static void cubo(int num, int cub)
        {
            int i = 0;
            if (cub == 0)
            {
                Console.WriteLine(">> Resultado: " + i * num);
            }
            else
            {
                i = num;
                cubo(num * num, cub - 1);
            }
        }
        // ------------------------ Exer 4 ------------------------
        static void Exer_4()
        {
            int num_1, num_2;
            Console.Write(">> Número x: ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(">> Número y: ");
            num_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("<< Resultado: " + mdc(num_1, num_2) + ">>\n");
        }

        static int mdc(int x, int y)
        {
            // forma simplificada com mesmo resultado
            if (y == 0)
            {
                return x;
            }
            else
            {
                return mdc(y, x % y);
            }

            // Feito pelo professor
            /*
                if (x == y)
                {
                    return x;
                }
                else if (x < y)
                {
                    return mdc(y, x);
                }
                else
                {
                    return mdc(x - y, y);
                }
            */
        }
        // ------------------------ Exer 5 ------------------------
        static void Exer_5()
        {
            int x, op;

            Console.Write(">> Digite um número: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(">> [1] Função Recursiva\n>> [2] Função Interativa\n");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                // recursiva
                case 1:
                    Console.WriteLine("<< Função Recursiva >>\n");
                    Console.WriteLine("<< Valor obtido: " + fib(x) + ">>");
                    break;
                case 2:
                    // Interativa
                    Console.WriteLine("<< Função Interativa >>\n");
                    Console.WriteLine("<< Valor obtido: " + fib_interativo(x) + ">>");
                    break;
            }
        }
        static int fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 1;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
        static int fib_interativo(int n)
        {
            int F = 0; // Atual
            int ant = 0; // Anterior

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    F = 1;
                    ant = 0;
                }
                else
                {
                    F += ant;
                    ant = F - ant;
                }
            }

            return F;
        }
        // ------------------------ Exer 6 ------------------------
        static void Exer_6()
        {
            int x;
            Console.Write(">> Digite o número a ser convertido: ");
            x = Convert.ToInt32(Console.ReadLine());

            Conversorbinario(x);
        }

        static void Conversorbinario(int n)
        {
            if (n / 2 != 0)
            {
                Conversorbinario(n / 2);
            }
            else
            {
                Console.Write(n % 2);
            }
        }

    }
}
