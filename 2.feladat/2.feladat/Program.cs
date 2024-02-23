using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.feladat;

List<Telepules> Telepulesek = new List<Telepules>();
StreamReader sr = new StreamReader("telepules.txt");
while (!sr.EndOfStream)
{
    string[] sor = sr.ReadLine().Split(" ");
    Telepulesek.Add(new Telepules(int.Parse(sor[0]), sor[1], double.Parse(sor[3].Replace('.', ',')), double.Parse(sor[2].Replace('.', ',')), double.Parse(sor[4].Replace('.', ',')), double.Parse(sor[5].Replace('.', ',')), sor[6], int.Parse(sor[7]), int.Parse(sor[8])));
}
sr.Close();


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






//2.b
/*
var SzelessegAlapjanRendezett = Telepulesek.OrderByDescending(x => x.Hosszusagi).ToList();
Console.WriteLine(SzelessegAlapjanRendezett[0].TelepulesNeve);
*/
//2.b Valasz:  Uszka
//2.b Valasz forditott: Tornanadaska





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
*/
//2.d Valasz: Karczag-Berekfurdo-350,06





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
//2.e Valasz forditott: Budakeszi
*/




//2.f

int aetszam = 0;
List<Telepules> aetatet = new List<Telepules>();


foreach (var telepules in Telepulesek)
{
    List<char> aetKarakterek = new List<char>();
    foreach (char karakter in telepules.TelepulesNeve.ToLower())
    {
        if (karakter == 'a')
            aetKarakterek.Add(karakter);
        else if (karakter == 'e')
            aetKarakterek.Add(karakter);
        else if (karakter == 't')
            aetKarakterek.Add(karakter);
    }
    if (aetKarakterek.Count >= 3)
    {
        int a = -1;
        int e = -1;
        int t = -1;
        bool aUtanT = false;
        int aUtanTaIndex = -2;
        List<int> EbetukIndexei = new List<int>();
        for (int i = 0; i < aetKarakterek.Count(); i++)
        {
            if (aetKarakterek[i] == 'a')
                a = i;
            else if (aetKarakterek[i] == 'e')
            {
                e = i;
                EbetukIndexei.Add(i);
            }           
            else if (aetKarakterek[i] == 't')
                t = i;

            if (a != -1 && e != -1 && t != -1)
            {
                if (a < t && t < e)
                {
                    aUtanT = true;
                    aUtanTaIndex = a;
                }

                if (aUtanT && a == aUtanTaIndex)
                {
                    continue;
                }
                else
                {
                    if(a < e && e < t)
                    {
                        int hanyE = 0;
                        for (int j = a; j < t; j++)
                        {
                            if (aetKarakterek[j] == 'e')
                                hanyE++;
                        }
                        if (hanyE == 1)
                        {
                            aetszam++;
                            aetatet.Add(telepules);
                            break;
                        }                       
                    }
                }              
            }
        }
    }
}
//2.f Valasz: 116


Console.WriteLine(aetszam);

foreach (var item in aetatet)
{
    Console.WriteLine(item.TelepulesNeve);
}

Console.WriteLine(aetatet.Count());
