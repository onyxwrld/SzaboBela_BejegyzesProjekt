using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzaboBela_BejegyzesProjekt
{
    internal class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public string Szerzo { get => szerzo;}
        public string Tartalom { get => tartalom; set => tartalom = value; }
        public int Likeok { get => likeok;}
        public DateTime Letrejott { get => letrejott;}
        public DateTime Szerkesztve { get => szerkesztve;}

        public Bejegyzes(string szerzo, string tartalom)
        {

        }

        public Bejegyzes(string szerzo, string tartalom, int likeok, DateTime letrejott, DateTime szerkesztve)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = DateTime.Now;
            this.szerkesztve = DateTime.Now;
        }

        public void Like()
        {
            this.likeok++;
        }
        public override string ToString()
        {
            string szerkesztveSzoveg = this.Szerkesztve == this.Letrejott ? "" : $"Szerkeszve: {this.Szerkesztve}";
            return $"{this.Szerzo} - {this.Likeok} - {this.Letrejott} {szerkesztveSzoveg}: {this.Tartalom}";
        }
    }
}
