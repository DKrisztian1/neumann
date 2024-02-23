using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Telepules
    {
        int iranyitoSzam;
        string megyeAzon;
        double szelessegi;
        double hosszusagi;
        double terulet;
        double lakosokSzama;
        string telepulesNeve;
        int tavolsagKecskemettol;
        int tavolsagSzegedtol;

        public Telepules(int iranyitoSzam, string megyeAzon, double szelessegi, double hosszusagi, double terulet, double lakosokSzama, string telepulesNeve, int tavolsagKecskemettol, int tavolsagSzegedtol)
        {
            this.iranyitoSzam = iranyitoSzam;
            this.megyeAzon = megyeAzon;
            this.szelessegi = szelessegi;
            this.hosszusagi = hosszusagi;
            this.terulet = terulet;
            this.lakosokSzama = lakosokSzama;
            this.telepulesNeve = telepulesNeve;
            this.tavolsagKecskemettol = tavolsagKecskemettol;
            this.tavolsagSzegedtol = tavolsagSzegedtol;
        }

        public int IranyitoSzam { get => iranyitoSzam; }
        public string MegyeAzon { get => megyeAzon; }
        public double Szelessegi { get => szelessegi; }
        public double Hosszusagi { get => hosszusagi; }
        public double Terulet { get => terulet; }
        public double LakosokSzama { get => lakosokSzama; }
        public string TelepulesNeve { get => telepulesNeve; }
        public int TavolsagKecskemettol { get => tavolsagKecskemettol; }
        public int TavolsagSzegedtol { get => tavolsagSzegedtol; }
    }
}
