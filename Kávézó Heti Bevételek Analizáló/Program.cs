List<int> szl = new List<int>();
Console.WriteLine("=== Kávézó Heti Bevételek Rögzítése ===");
for (int i=0;i<5;i++)
{
    Console.Write($"{i+1}. nap bevétele (Ft): ");
    int napi = int.Parse(Console.ReadLine());
    szl.Add(napi);
}