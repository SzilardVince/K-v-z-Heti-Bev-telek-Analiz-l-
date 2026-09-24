List<int> szl = new List<int>();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=== kávézó Heti Bevételek Rögzítése ===");
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
Console.WriteLine("========================================");
Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"- {i}. nap: {szl[i]}Ft");
}
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("========================================");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Összesített bevétel: {osszeg} Ft");
Console.WriteLine($"Napi átlagbevétel: {atlag:F2} Ft");
string statusz;
if (atlag >= 80000) statusz = "kiemelkedö hét!!!";
else if (atlag >= 50000) statusz=  "átlagos hét!!!";
else statusz =  "Gyenge hét, felülvizsgálat szükséges!!!";
Console.WriteLine($"heti státusz: {statusz}");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("========================================");