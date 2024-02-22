using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7;

List<double> szamok = new List<double>();
StreamReader sr = new StreamReader("szamok.txt");
while (!sr.EndOfStream)
{
    szamok.Add(Convert.ToDouble(sr.ReadLine()));
}
sr.Close();



List<Telepules> Telepulesek = new List<Telepules>();
StreamReader sr2 = new StreamReader("telepules.txt");
while (!sr2.EndOfStream)
{
    string[] sor = sr2.ReadLine().Split(" ");
    Telepulesek.Add(new Telepules(int.Parse(sor[0]), sor[1], double.Parse(sor[2].Replace('.', ',')), double.Parse(sor[3].Replace('.', ',')), double.Parse(sor[4].Replace('.', ',')), double.Parse(sor[5].Replace('.', ',')), sor[6], int.Parse(sor[7]), int.Parse(sor[8])));
}
sr2.Close();




/*
int hanyDarab = 0;

foreach (var szam in szamok)
{
    if (szam % 3 != 0 && szam % 7 != 0 && szam % 9 != 0 && szam % 13 != 0)
        hanyDarab++;
}
Console.WriteLine(hanyDarab);
*/


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
//1.b

List<char> MegadottSzamSzamjegyei = new List<char>();
foreach (var jegy in "2354211341")
    MegadottSzamSzamjegyei.Add(jegy);
List<char> MasolatMegadottSzamSzamjegyei = new List<char>();

int hanyAnaize = 0;

List<char> JelenlegiSzamSzamjegyei = new List<char>();

foreach (var szam in szamok)
{
    JelenlegiSzamSzamjegyei.Clear();
    MasolatMegadottSzamSzamjegyei.Clear();
    MasolatMegadottSzamSzamjegyei = MegadottSzamSzamjegyei;

    foreach (char szamJegy in Convert.ToString(szam))
    {
        JelenlegiSzamSzamjegyei.Add(szamJegy);
    }
    


    for (int i = 0; i < 9; i++)
    {
        if (MasolatMegadottSzamSzamjegyei.Contains(JelenlegiSzamSzamjegyei[i]))
        {
            JelenlegiSzamSzamjegyei.Remove(JelenlegiSzamSzamjegyei[i]);
            MasolatMegadottSzamSzamjegyei.Remove(JelenlegiSzamSzamjegyei[i]);
        }
    }
    

    Console.Write(JelenlegiSzamSzamjegyei.Count() + ",");
    Console.WriteLine(MegadottSzamSzamjegyei.Count());

    
   
}
Console.WriteLine(hanyAnaize);
*/



/*
 //1.c
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



//1.c  Válasz:   21
*/





/*
//2.a
Dictionary<string, double> MegyekLakossaga = new Dictionary<string, double>();
foreach (var telepules in Telepulesek)
{
    if (!MegyekLakossaga.ContainsKey(telepules.MegyeAzon))
        MegyekLakossaga.Add(telepules.MegyeAzon, telepules.LakosokSzama);
    else
        MegyekLakossaga[telepules.MegyeAzon] += telepules.LakosokSzama;
}

var LakossagAlapjanRendezett = MegyekLakossaga.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
Console.WriteLine($"{LakossagAlapjanRendezett.ElementAt(1).Key} - { LakossagAlapjanRendezett.ElementAt(1).Value}");
//2.a  Valasz:    PE - 1212055
*/




/*
//2.b

var SzelessegAlapjanRendezett = Telepulesek.OrderByDescending(x => x.Hosszusagi).ToList();
Console.WriteLine(SzelessegAlapjanRendezett[0].TelepulesNeve);
//2.b Valasz:  Uszka
*/




//2.c
/*
int hanyKecskemetSzegedKorzet = 0;
foreach (Telepules telepules in Telepulesek)
{
    if(telepules.TavolsagKecskemettol <= 50 && telepules.TavolsagSzegedtol <= 50)
        hanyKecskemetSzegedKorzet++;
}
Console.WriteLine(hanyKecskemetSzegedKorzet);
//2.c Valasz: 24
*/




//2.e
/*
List<Telepules> BudaTelepulesek = new List<Telepules>();
foreach (Telepules telepules in Telepulesek)
{
    if (telepules.TelepulesNeve.Contains("Buda") || telepules.TelepulesNeve.Contains("buda"))
        BudaTelepulesek.Add(telepules);
}

var amiKell = BudaTelepulesek.OrderBy(x => x.Szelessegi).ToList().Take(3).Last();
Console.WriteLine(amiKell.TelepulesNeve);
//2.e Valasz: Budaors
*/




//2.f
/*
int amiIgen = 0;
bool voltA, voltE, voltT;
List<Telepules> AET = new List<Telepules>();

void Reset()
{
    voltA = false; voltE = false; voltT = false;
}

foreach (Telepules telepules in Telepulesek)
{
    Reset();
    foreach (char betu in telepules.TelepulesNeve)
    {
        if (betu == 'a' || betu == 'A')
            voltA = true;

        if ((betu == 't' || betu == 'T') && !voltE)
            Reset();
        else if ((betu == 'e' || betu == 'E') && voltA)
            voltE = true;


        else if ((betu == 't' || betu == 'T') && voltA && voltE)
            voltT = true;
    }
    if (voltA && voltE && voltT)
        amiIgen++;
}
Console.WriteLine(amiIgen);
//2.f Valasz: 139
*/