﻿using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

List<double> szamok = new List<double>();
StreamReader sr = new StreamReader("szamok.txt");
while (!sr.EndOfStream)
{
    szamok.Add(Convert.ToDouble(sr.ReadLine()));
}
sr.Close();

List<string>stringSzamok = new List<string>();
stringSzamok = File.ReadAllLines("szamok.txt").ToList();



List<Telepules> Telepulesek = new List<Telepules>();
StreamReader sr2 = new StreamReader("telepules.txt");
while (!sr2.EndOfStream)
{
    string[] sor = sr2.ReadLine().Split(" ");
    Telepulesek.Add(new Telepules(int.Parse(sor[0]), sor[1], double.Parse(sor[2].Replace('.', ',')), double.Parse(sor[3].Replace('.', ',')), double.Parse(sor[4].Replace('.', ',')), double.Parse(sor[5].Replace('.', ',')), sor[6], int.Parse(sor[7]), int.Parse(sor[8])));
}
sr2.Close();


//1.a

double x = 1310438493;





//1.b
/*
string alapSzam = "2354211341";
int hanyAnaize = 0;
bool azvolt = false;

foreach (var szam in stringSzamok)
{
    char[] firstCharsArray = alapSzam.ToCharArray();
    char[] secondCharsArray = szam.ToCharArray();

    Array.Sort(firstCharsArray);
    Array.Sort(secondCharsArray);

    for (int i = 0; i < firstCharsArray.Length; i++)
    {
        if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
        {
            azvolt = false;
            break;
        }
    }
    if (azvolt)
        hanyAnaize++;

}
Console.WriteLine(hanyAnaize);
*/


//1.c
/*
List<string> ketjegyuek = new List<string>();
foreach (string szam in stringSzamok)
{
    for (int i = 0; i < 9; i++)
    {
        ketjegyuek.Add($"{szam[i]}{szam[i+1]}");
    }
}
string most = ketjegyuek.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
Console.WriteLine(most);
*/
//1.c  Válasz:   12





//2.a
/*
Dictionary<string, double> MegyekLakossaga = new Dictionary<string, double>();
foreach (var telepules in Telepulesek)
{
    if (!MegyekLakossaga.ContainsKey(telepules.MegyeAzon))
        MegyekLakossaga.Add(telepules.MegyeAzon, telepules.LakosokSzama);
    else
        MegyekLakossaga[telepules.MegyeAzon] += telepules.LakosokSzama;
}

var LakossagAlapjanRendezett = MegyekLakossaga.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
Console.WriteLine($"{LakossagAlapjanRendezett.ElementAt(1).Key} - { LakossagAlapjanRendezett.ElementAt(1).Value}");

//2.a  Valasz:    TO - 234847
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


//2.d
/*
List<Telepules> JoSzelessegiKorok = new List<Telepules>();
foreach (var telepules in Telepulesek)
{
    if (telepules.Szelessegi >= 47.3 && telepules.Szelessegi <= 47.4)
        JoSzelessegiKorok.Add(telepules);
}
double kulonbseg = 0;
string tele1 = "", tele2 = "";

for (int i = 1; i < JoSzelessegiKorok.Count(); i++)
{
    if (Math.Abs(JoSzelessegiKorok[i - 1].Terulet - JoSzelessegiKorok[i].Terulet) > kulonbseg)
    {
        tele1 = JoSzelessegiKorok[i - 1].TelepulesNeve;
        tele2 = JoSzelessegiKorok[i].TelepulesNeve;
        kulonbseg = Math.Round(Math.Abs(JoSzelessegiKorok[i - 1].Terulet - JoSzelessegiKorok[i].Terulet), 2);
    }
}
Console.WriteLine($"{tele1} - {tele2} = {kulonbseg}");
//2.d Valasz: Karczag-Berekfurdo-350,06
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