namespace ReviewConcepts;

public class Program
{
    static void Main(string[] args)
    {
        var idade = 10;
        Console.WriteLine(idade);

        int idade2 = 20;
        Console.WriteLine(idade2);

        string name = "lucas";
        Console.WriteLine(name);

        const int IDADE_MINIMA = 18;
        Console.WriteLine(IDADE_MINIMA);    

        //const var IDADE_MAXIMA = 60; // constantes não podem ser de tipo implícito.
        
        
        // ---- converções de tipos ----

        float valor;
        int outro = 25;

        valor = outro;
        Console.WriteLine($"conversão: {valor}");

        int inteiro = 100;
        uint inteiroSemSinal = (uint)inteiro;
        Console.WriteLine($"Conversão explícita: {inteiroSemSinal}");

        float numero = 25.8f;
        int outroNumero = (int)numero; // Pode ocorrer perca de dados.
        Console.WriteLine($"Conversão explícita: {outroNumero}");
    }
}