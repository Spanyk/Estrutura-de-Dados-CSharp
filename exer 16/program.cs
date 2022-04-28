/ Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;
using System.Text;

public class HelloWorld
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
        
        for(int i = 0; i < 5; i++)
        {
            Console.Write("n°: ");
            int num = int.Parse(Console.ReadLine());
            Insere(ref tp_no topo, num);
        }
        
        Console.ReadKey();
    }
}
