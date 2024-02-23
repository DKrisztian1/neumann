using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


List<double> szamok = new List<double>();
StreamReader sr = new StreamReader("szamok.txt");
while (!sr.EndOfStream)
{
    szamok.Add(Convert.ToDouble(sr.ReadLine()));
}
sr.Close();

List<string> stringSzamok = new List<string>();
stringSzamok = File.ReadAllLines("szamok.txt").ToList();



//1.a
/*
long x = 1310438493;
int hany = 0;
long FindGCD(long a, long b)
{
    a = Math.Abs(a);
    b = Math.Abs(b);

    while (b != 0)
    {
        long temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}

foreach (long szam in szamok)
{
    if (FindGCD(x, szam) ==1)
        hany++;
}
Console.WriteLine(hany);
*/





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
        azvolt = true;
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
//1.b Valasz: 28
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