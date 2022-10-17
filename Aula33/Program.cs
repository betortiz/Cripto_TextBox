using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Jogador j1 = new Jogador("Alberto");

        j1.setEnergia(-30);

        Console.WriteLine("Nome .......: {0}", j1.getNome());
        Console.WriteLine("Energia ....: {0}", j1.getEnergia());
    }
}