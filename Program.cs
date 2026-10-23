using System;

public class Programa
{
    public static void Main()
    {
        Console.WriteLine("=== Parte 1 ===");
        Pilha p = new Pilha(5);
        p.empilha(1); p.empilha(3); p.empilha(5); p.empilha(7);
        p.mostra();
        Console.WriteLine(p.desempilha());
        Console.WriteLine(p.consultaTopo());
        p.empilha(8); p.empilha(9);
        p.mostra();
        Console.WriteLine(p.cheia());
        try { p.empilha(2); }
        catch (Exception e) { Console.WriteLine(e.Message); }

        Console.WriteLine("\n=== Parte 3 ===");
        Console.WriteLine(Algoritmos.inverte("PUCMINAS"));
        foreach (string s in new[] { "(a+b)*[c-d]", "{[()]}", "((a)", "a+b)", "([)]" })
            Console.WriteLine(s + " -> " + Algoritmos.balanceado(s));

        Console.WriteLine("\n=== Parte 4 ===");
        int comp;
        int[] r1 = Algoritmos.bubblePilhas(new[] { 5, 2, 9, 1, 7 }, out comp);
        Console.WriteLine(string.Join(", ", r1) + " | comparações: " + comp);
        int[] r2 = Algoritmos.bubblePilhas(new[] { 1, 2, 3, 4, 5 }, out comp);
        Console.WriteLine(string.Join(", ", r2) + " | comparações: " + comp);

        Console.WriteLine("\n=== Desafio ===");
        Pilha d = new Pilha(5);
        foreach (int x in new[] { 4, 1, 5, 2, 3 }) d.empilha(x);
        Algoritmos.ordenaPilha(d).mostra(); // [1, 2, 3, 4, 5]
    }
}
