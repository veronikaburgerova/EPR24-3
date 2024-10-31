try
{
    int a = int.Parse(Console.ReadLine());
    int b = 5 / a;
}
catch (FormatException)
{
    Console.WriteLine("Spatny format. Zadej cislo.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("nemuzes zadat nulu");
}
