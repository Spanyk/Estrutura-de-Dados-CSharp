using System;
using System.Text;
using System.Threading.Tasks;

namespace Exer_28
{
    internal class Program
    {
        const int N = 5;
        const int S = 0;

        class Tp_no
        {
            public int idade;
            public string nome, sexo;
        }

        static int hash(int c) // C -> Chave
        {
            return (c % N) + 1;
        }

        static void criaNos(Tp_no[] V) // V -> vetor
        {
            int i;
            for (i = 0; i < N; i++)
            {
                V[i] = new Tp_no();
            }
        }
        static void Insere(Tp_no[] v, int age, string nm, string sex)
        {
            int pos = hash(age);

            v[pos].idade = age;
            v[pos].nome = nm;
            v[pos].sexo = sex;
        }
        static void InserirLinear(Tp_no[] v, int age, string nm, string sex)
        {
            int pos = hash(age);
            while (v[pos].idade != 0)
            {
                pos++;
                pos = pos % N;
            }
            v[pos].idade = age;
            v[pos].nome = nm;
            v[pos].sexo = sex;
        }
        static int RecuperarLinear(Tp_no[] v, int nt)
        {
            int pos = hash(nt);
            int cont = 0;

            while (v[pos].idade != nt && cont <= N)
            {
                pos++;
                pos = pos % N;
                cont++;
            }
            if (cont <= N)
            {
                return pos;
            }
            else
            {
                return -1;
            }
        }

        static int funcionalidades() // main 2
        {
            int op = 0;

            Console.WriteLine("\nEscolha uma opção:");
            Console.Write(
                "[1] Inserir\n" +
                "[2] Consultar\n" +
                "[3] Alterar\n" +
                "[4] Relatar\n" +
                "[5] Voltar\n" +
                "\n>>  "
                );

            return op = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Tp_no[] Vetor = new Tp_no[N];
            criaNos(Vetor);
            int op = 0, idade = 0;
            string nome = "", sexo = "";

            while (op != 4)
            {
                Console.WriteLine("Escolha um opção");
                Console.Write(
                "[1] Sem tratamento de colisão\n" +
                "[2] Tratamento de colisão Linear\n" +
                "[3] Tratamento de colisão com lista linear encadeada\n" +
                "[4] Sair\n" +
                "\n>> "
                );

                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Opção escolhida Sem tratamento <<");
                    Console.ResetColor();
                    SemColisao(Vetor, nome, sexo, idade);

                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Opção escolhida Com tratamento <<");
                    Console.ResetColor();
                    ColisaoLinear(Vetor, nome, sexo, idade);

                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Opção escolhida Colisão linear encadeada <<");
                    Console.ResetColor();
                    ColisaoLinearEncadeada(Vetor, nome, sexo, idade);
                }
            }

        }

        static void SemColisao(Tp_no[] V, string nm, string sx, int age)
        {
            int fun = funcionalidades();
            if(fun == 5)
            {
                Console.Clear();
            }
           
            while (fun != 5)
            {
                if (fun == 1)
                {
                    Console.WriteLine("\n>> Prencha os campos");
                    Console.Write("Nome: ");
                    nm = Console.ReadLine();
                    Console.Write("Idade: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sexo: ");
                    sx = Console.ReadLine();
                    Insere(V, age, nm, sx);
                }
            }
            
                
        } 
        
        static void ColisaoLinear(Tp_no[] V, string nm, string sx, int age)
        {
            int fun = funcionalidades();
            if (fun == 5)
            {
                Console.Clear();
            }
            while (fun != 5)
            {
                if (fun == 1)
                {
                    Console.WriteLine("\n>> Prencha os campos");
                    Console.Write("Nome: ");
                    nm = Console.ReadLine();
                    Console.Write("Idade: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sexo: ");
                    sx = Console.ReadLine();

                    InserirLinear(V, age, nm, sx);
                }
            }
        }

        static void ColisaoLinearEncadeada(Tp_no[] V, string nm, string sx, int age)
        {
            int fun = funcionalidades();
            if (fun == 5)
            {
                Console.Clear();
            }
            while (fun != 5)
            {
                if (fun == 1)
                {
                    Console.WriteLine("\n>> Prencha os campos");
                    Console.Write("Nome: ");
                    nm = Console.ReadLine();
                    Console.Write("Idade: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sexo: ");
                    sx = Console.ReadLine();

                    /* InserirLinear(V, age, nm, sx); */
                    // Implementar função de lista encadeada e aplicar colisão
                }
            }
        }
    }
}
