using System;
using System.Text;

public static class Algoritmos
{

    public static string inverte(string s)
    {
        Pilha p = new Pilha(s.Length);
        foreach (char c in s) p.empilha(c);
        StringBuilder sb = new StringBuilder();
        while (!p.vazia()) sb.Append((char)p.desempilha());
        return sb.ToString();
    }

  
    public static bool balanceado(string expr)
    {
        Pilha p = new Pilha(expr.Length);
        foreach (char c in expr)
        {
            if (c == '(' || c == '[' || c == '{')
                p.empilha(c);
            else if (c == ')' || c == ']' || c == '}')
            {
                if (p.vazia()) return false;        
                char a = (char)p.desempilha();
                if (!((a == '(' && c == ')') ||
                      (a == '[' && c == ']') ||
                      (a == '{' && c == '}'))) return false;
            }
        }
        return p.vazia();                             
    }

    public static int[] bubblePilhas(int[] v, out int comparacoes)
    {
        int n = v.Length;
        comparacoes = 0;
        Pilha A = new Pilha(n), B = new Pilha(n), R = new Pilha(n);

        foreach (int x in v) A.empilha(x);

        for (int restantes = n; restantes >= 1; restantes--)
        {
            int carry = A.desempilha();
            for (int i = 0; i < restantes - 1; i++)
            {
                int x = A.desempilha();
                comparacoes++;
                if (carry > x) B.empilha(x);
                else { B.empilha(carry); carry = x; }
            }
            R.empilha(carry);
            Pilha t = A; A = B; B = t;   
        }

        int[] res = new int[n];
        for (int i = 0; i < n; i++) res[i] = R.desempilha(); 
        return res;
    }

  
    public static Pilha ordenaPilha(Pilha p)
    {
        Pilha aux = new Pilha(p.tamanho());
        while (!p.vazia())
        {
            int t = p.desempilha();
            while (!aux.vazia() && aux.consultaTopo() > t)
                p.empilha(aux.desempilha());
            aux.empilha(t);
        }
        return aux;
    }
}
