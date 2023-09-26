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
        public int Likeok { get => likeok; set => likeok = value; }
        public DateTime Letrejott { get => letrejott; set => letrejott = value; }
        public DateTime Szerkesztve { get => szerkesztve; set => szerkesztve = value; }
    }
}
