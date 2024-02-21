using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

List<double> szamok= new List<double>();
StreamReader sr = new StreamReader("szamok.txt");
while (!sr.EndOfStream)
{
    szamok.Add(Convert.ToDouble(sr.ReadLine()));
}
sr.Close();


int hanyDarab = 0;

foreach (var szam in szamok)
{
    if (szam % 3 != 0 && szam % 7 != 0 && szam % 9 != 0 && szam % 13 != 0 )
        hanyDarab++;
}
Console.WriteLine(hanyDarab);



/*
double x = 1310438493;

foreach (double y in szamok)
{
    double b = y;
    while (x != b)
    {
        if (x > b)
            x = x - b;
        else
            b = b - x;
    }
    if (x == 1)
    {
        hanyDarab++;
    }
}
Console.WriteLine(hanyDarab);
*/






/*
Dictionary<int, int> SzamokElofordulasa = new Dictionary<int, int>();
foreach (var szam in szamok)
{
    int szam1 = Convert.ToInt32(Convert.ToString(szam).Substring(0, 2));
    if (!SzamokElofordulasa.ContainsKey(szam1))
        SzamokElofordulasa.Add(szam1, 1);
    else
        SzamokElofordulasa[szam1] += 1;

    int szam2 = Convert.ToInt32(Convert.ToString(szam).Substring(2, 2));
    if (!SzamokElofordulasa.ContainsKey(szam2))
        SzamokElofordulasa.Add(szam2, 1);
    else
        SzamokElofordulasa[szam2] += 1;

    int szam3 = Convert.ToInt32(Convert.ToString(szam).Substring(4, 2));
    if (!SzamokElofordulasa.ContainsKey(szam3))
        SzamokElofordulasa.Add(szam3, 1);
    else
        SzamokElofordulasa[szam3] += 1;

    int szam4 = Convert.ToInt32(Convert.ToString(szam).Substring(6, 2));
    if (!SzamokElofordulasa.ContainsKey(szam4))
        SzamokElofordulasa.Add(szam4, 1);
    else
        SzamokElofordulasa[szam4] += 1;

    int szam5 = Convert.ToInt32(Convert.ToString(szam).Substring(8, 2));
    if (!SzamokElofordulasa.ContainsKey(szam5))
        SzamokElofordulasa.Add(szam5, 1);
    else
        SzamokElofordulasa[szam5] += 1;
}

var RendezettSzamok = SzamokElofordulasa.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
Console.WriteLine(RendezettSzamok.First().Key);



1/c   válasz:21

*/


/*
List<Telepules> Telepulesek = new List<Telepules>();
StreamReader sr2 = new StreamReader("telepules.txt");
while (!sr2.EndOfStream)
{
    string[] sor = sr2.ReadLine().Split(" ");
    Telepulesek.Add(new Telepules(int.Parse(sor[0]), sor[1], double.Parse(sor[2]), double.Parse(sor[3]), double.Parse(sor[4]), double.Parse(sor[5]), sor[6], int.Parse(sor[7]), int.Parse(sor[8]) ));
}
sr2.Close();

Dictionary<string, double> MegyekLakossaga = new Dictionary<string, double>();
foreach (var telepules in Telepulesek)
{
    if (!MegyekLakossaga.ContainsKey(telepules.MegyeAzon))
        MegyekLakossaga.Add(telepules.MegyeAzon, telepules.LakosokSzama);
    else
        MegyekLakossaga[telepules.MegyeAzon] += telepules.LakosokSzama;
}

var LakossagAlapjanRendezett = MegyekLakossaga.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
Console.WriteLine($"{LakossagAlapjanRendezett.First().Key} - { LakossagAlapjanRendezett.First().Value}");
*/