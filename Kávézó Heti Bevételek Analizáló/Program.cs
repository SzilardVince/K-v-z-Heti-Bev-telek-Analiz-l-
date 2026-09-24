List<int> szl = new List<int>();
Console.WriteLine("=== Kávézó Heti Bevételek Rögzítése ===");
for (int i=0;i<5;i++)
{
    Console.Write($"{i+1}. nap bevétele (Ft): ");
    int napi = int.Parse(Console.ReadLine());
    szl.Add(napi);
}
int osszeg = 0;
for (int i = 0; i < 5; i++)
{
    osszeg += szl[i];
}
double atlag = osszeg / 5.0;
Console.WriteLine($"Összesített bevétel: {osszeg} Ft");
Console.WriteLine($"Napi átlagbevétel: {atlag:F2} Ft");