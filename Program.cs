using RollerKolcsonzo;
using System.Globalization;
List<RollerUtazas> utazasok = new List<RollerUtazas>();
string[] sorok = File.ReadAllLines("rollerek.txt");
foreach(string sor in sorok)
{
    utazasok.Add(new RollerUtazas(sor));

}
Console.WriteLine("Utazások részletei:");

foreach(RollerUtazas aktualis in utazasok)
{
    Console.WriteLine(aktualis);
    

}
Console.WriteLine("Statisztika:");
int teljes = utazasok.Sum(x=>x.FizetendoDij());
Console.WriteLine($"Kölcsönző teljes napi bevétele: {teljes} Ft");
RollerUtazas leg = utazasok.MaxBy(x => x.UtazasiIdoPerc);
Console.WriteLine($"Leghosszabb utazás: {leg.FelhasznaloNev} ({leg.UtazasiIdoPerc} perc)");
