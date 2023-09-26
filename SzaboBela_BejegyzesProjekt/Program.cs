using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzaboBela_BejegyzesProjekt
{
    internal class Program
    {

        static List<Bejegyzes> lista = new List<Bejegyzes>();
        static void feladat2b()
        {
            //Ezt a feladatot így értelmeztem, nem vagyok biztos benne hogy ezt kérte tőlem a szerző.
            Console.WriteLine("Adjon meg darabszámot hogy hány bejegyzést szeretne hozzáadni:");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine("Adjon meg egy szerzőt és tartalmat");
                string szerzo = Console.ReadLine();
                string tartalom = Console.ReadLine();
                Bejegyzes a3 = new Bejegyzes(szerzo, tartalom);
                lista.Add(a3);
            }
        }
        static void feladat2c(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string a = sr.ReadLine();
                string[] s = a.Split(';');
                string szerzo = s[0];
                string tartalom = s[1];
                Bejegyzes a1 = new Bejegyzes(szerzo,tartalom);
                lista.Add(a1);
            }
            sr.Close();
        }
        static void Main(string[] args)
        {
            Bejegyzes a1 = new Bejegyzes("geza","rajosan geza");
            Bejegyzes a2 = new Bejegyzes("agoston", "nyomjad geza");
            lista.Add(a1);
            lista.Add(a2);
            feladat2b();
            Console.ReadKey();
        }
    }
}
