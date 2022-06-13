using System;
using System.Text;
using System.Threading.Tasks;

namespace Exer_29
{
    internal class Program
    {
        const int N = 5;

        class Tp_no
        {
            public int idade;
            public string nome, sexo;
            public Tp_no prox;
        }

        static int hash(int c) // C -> Chave
        {
            return (c % N);
        }
        static void Insere(Tp_no[] v, int age, string nm, string sex)
        {
            int pos = hash(age);

            v[pos].idade = age;
            v[pos].nome = nm;
            v[pos].sexo = sex;
        }
        static int Busca(int c)
        {
            int pos = hash(c);
            return pos;
        }
        static void criaNos(Tp_no[] V)
        {
            int i;
            for (i = 0; i < N; i++)
            {
                V[i] = new Tp_no();
            }
        }
        static void InserirLinear(Tp_no[] v, string nm, string sx, int age, ref int q)
        {
            int pos = hash(age);
            while (v[pos].idade != 0)
            {
                pos++;
                pos = pos % N;
                q += q;
            }
            v[pos].idade = age;
            v[pos].nome = nm;
            v[pos].sexo = sx;
        }
        static void InsereEncadeado(Tp_no[] v, int c, string nm, string sx)
        {
            Tp_no no = new Tp_no();
            no.idade = c;
            int pos = hash(c);
            if (v[pos] != null)
                no.prox = v[pos];
            v[pos] = no;
            v[pos].nome = nm;
            v[pos].sexo = sx;
        }

        static int RecuperarLinear(Tp_no[] v, int age)
        {
            int pos = hash(age);
            int cont = 0;

            while (v[pos].idade != age && cont <= N)
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
            Console.Clear();
 
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
            int op = 0;

            while (op != 4)
            {   
                Console.Clear();
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
                    SemColisao(op);

                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Opção escolhida Com tratamento <<");
                    Console.ResetColor();
                    ColisaoLinear(op);

                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Opção escolhida Colisão linear encadeada <<");
                    Console.ResetColor();
                    ColisaoLinearEncadeada(op);
                }
            }

        }

        static void SemColisao(int op)
        {
            Tp_no[] SemColisao = new Tp_no[N];
            criaNos(SemColisao);
            int idade = 0;
            string nome = "", sexo = "";

            bool cc = true;
            while(cc)
            {
                op = funcionalidades();

                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n>> Prencha os campos: ");
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sexo: ");
                    sexo = Console.ReadLine();
                    Insere(SemColisao, idade, nome, sexo);
                }
                else if (op == 2)
                {
                    Console.Write(">> Digite a idade: ");
                    idade = int.Parse(Console.ReadLine());
                    int chave = Busca(idade);

                    if (SemColisao[chave].idade == idade)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n>> Nome encontrado <<\n");
                        Console.ResetColor();
                        Console.WriteLine($"Nome: {SemColisao[chave].nome} || Sexo: {SemColisao[chave].sexo}");
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n>> Nome não encontrado <<");
                        Console.ResetColor();
                        Console.ReadKey();
                    }

                }
                else if (op == 3)
                {
                    Console.Write(">> Digite a idade: ");
                    idade = int.Parse(Console.ReadLine());
                    int chave = Busca(idade);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Digite os novos valores <<\n");
                    Console.ResetColor();
                    Console.Write("Nome: ");
                    SemColisao[chave].nome = Console.ReadLine();
                    Console.Write("Sexo: ");
                    SemColisao[chave].sexo = Console.ReadLine();
                }

                else if (op == 4)
                {
                    for (int chave = 0; chave < SemColisao.Length; chave++)
                    {
                        Console.WriteLine($"Nome:{SemColisao[chave].nome} " +
                            " | " + $"Idade: {SemColisao[chave].idade} " +
                            " | " + $"Sexo: {SemColisao[chave].sexo} ");
                    }
                    Console.ReadKey();
                }

                else if (op == 5)
                    cc = false;
            }
        }
        
        static void ColisaoLinear(int op)
        {
            Tp_no[] ColisaoLinear = new Tp_no[N];
            int idade = 0, qtde = 0;
            string nome = "", sexo = "";
            criaNos(ColisaoLinear);
            bool cc = true;

            while (cc)
            {
                op = funcionalidades();

                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n>> Prencha os campos: ");
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sexo: ");
                    sexo = Console.ReadLine();
                    InserirLinear(ColisaoLinear, nome, sexo, idade, ref qtde);
                }
                else if (op == 2)
                {
                    Console.Write(">> Digite a idade: ");
                    idade = int.Parse(Console.ReadLine());
                    int pos = RecuperarLinear(ColisaoLinear, idade);

                    if(pos != -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n>> Nome encontrado <<\n");
                        Console.ResetColor();
                        Console.WriteLine($"Nome: {ColisaoLinear[pos].nome} || Sexo: {ColisaoLinear[pos].sexo}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n>> Nome não encontrado <<");
                        Console.ResetColor();
                    }
                }
                else if (op == 3)
                {
                    Console.Write(">> Digite a idade: ");
                    idade = int.Parse(Console.ReadLine());
                    int chave = Busca(idade);

                    Console.WriteLine(">> Digite os novos valores <<\n");
                    Console.Write("Nome: ");
                    ColisaoLinear[chave].nome = Console.ReadLine();
                    Console.Write("Sexo: ");
                    ColisaoLinear[chave].sexo = Console.ReadLine();
                    
                }
                else if (op == 4)
                {
                    Console.Clear();
                    for (int chave = 0; chave < ColisaoLinear.Length; chave++)
                    {
                        Console.WriteLine($"Nome:{ColisaoLinear[chave].nome} " +
                            " | " + $"Idade: {ColisaoLinear[chave].idade} " +
                            " | " + $"Sexo: {ColisaoLinear[chave].sexo} ");
                    }
                    Console.ReadKey();

                }

                else if (op == 5)
                    cc = false;
            }
        }
    
        static void ColisaoLinearEncadeada(int op)
        {
            Tp_no[] ColisaoEncadeada = new Tp_no[N];
            int idade = 0;
            string nome = "", sexo = "";
            criaNos(ColisaoEncadeada);
            bool cc = true;

            while (cc)
            {
                op = funcionalidades();

                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n>> Prencha os campos: ");
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sexo: ");
                    sexo = Console.ReadLine();
                    InsereEncadeado(ColisaoEncadeada, idade, nome, sexo);
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.Write(">> Digite a idade: ");
                    idade = int.Parse(Console.ReadLine());
                    int chave = Busca(idade);
                    
                    if (ColisaoEncadeada[chave].idade == idade)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n>> Nome encontrado <<\n");
                        Console.ResetColor();
                        Console.WriteLine($"Nome: {ColisaoEncadeada[chave].nome} || Sexo: {ColisaoEncadeada[chave].sexo}");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n>> Nome não encontrado <<");
                        Console.ResetColor();
                    }

                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.Write(">> Digite a idade: ");
                    idade = int.Parse(Console.ReadLine());
                    int chave = Busca(idade);

                    while (chave <= ColisaoEncadeada.Length)
                    {
                        for(int i = 0; i < ColisaoEncadeada.Length; i++)
                        {
                            if(ColisaoEncadeada[i].idade == idade)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.WriteLine(">> Valor Encontrado <<");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n>> Valor não encontrado <<");
                                Console.ResetColor();
                            }
                        }
                    }
                }
                else if (op == 4)
                {
                    int c = 0;

                    while (c <= ColisaoEncadeada.Length)
                    {
                        for (int chave = 0; chave < ColisaoEncadeada.Length; chave++)
                        {
                            Console.WriteLine($"Nome:{ColisaoEncadeada[chave].nome} " +
                                " | " + $"Idade: {ColisaoEncadeada[chave].idade} " +
                                " | " + $"Sexo: {ColisaoEncadeada[chave].sexo} ");
                        }
                        c++;
                        Console.ReadKey();
                    }

                }
                else if( op == 5)
                    Console.Clear();
            }   
        }
    }
}
