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
            if(int.Parse(Console.ReadLine())>-1)
            {
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
            else
            {
                Console.WriteLine("Hibás érték!");
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
        static void feladat2d()
        {
            Random a = new Random();
            for (int i = 0; i < lista.Count * 20; i++)
            {
                int b = a.Next(0,lista.Count);
                lista[b].Like();
            }
        }
        static void feladat2e()
        {
            Console.WriteLine("Adjon meg egy szöveget amire a 2. Bejegyzés fog módosulni");
            string a = Console.ReadLine();
            lista[1].Tartalom = a;
            Console.WriteLine("A második elem változtatva lett");
        }
        static int feladat3a()
        {
            int legnagyobb = int.MinValue;
            foreach (var item in lista)
            {
                if (item.Likeok>legnagyobb)
                {
                    legnagyobb = item.Likeok;
                }
            }
            return legnagyobb;
        }
        static bool feladat3b()
        {
            bool vane35felett = false;
            foreach (var item in lista)
            {
                if (item.Likeok>35)
                {
                    vane35felett = true;
                }
            }
            return vane35felett;
        }
        static string feladat3c()
        {
            int a = 0;
            foreach (var item in lista)
            {
                if (item.Likeok<15)
                {
                    a++;
                }
            }
            string b = $"{a} db 15-nél kisebb szám van";
            return b;
        }
        static void feladat3d()
        {
            List<Bejegyzes> SortedList = lista.OrderByDescending(o => o.Likeok).ToList();
            StreamWriter sw = new StreamWriter("bejegyzesek_rendezett.txt");
            for (int i = 0; i < SortedList.Count; i++)
            {
                sw.WriteLine($"{SortedList[i].Szerzo},{SortedList[i].Tartalom},{SortedList[i].Letrejott},{SortedList[i].Szerkesztve},{SortedList[i].Likeok}");
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            Bejegyzes a1 = new Bejegyzes("geza","rajosan geza");
            Bejegyzes a2 = new Bejegyzes("agoston", "nyomjad geza");
            lista.Add(a1);
            lista.Add(a2);
            feladat2b();
            feladat2c("bejegyzesek.csv");
            feladat2d();
            feladat2e();
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Szerzo};{item.Tartalom};{item.Likeok}");
            }
            Console.WriteLine($"A like-ok száma {feladat3a()}");
            if (feladat3b())
            {
                Console.WriteLine("Van 35 felett like");
            }
            else
            {
                Console.WriteLine("Nincs 35 felett like");
            }
            feladat3c();
            feladat3d();
            Console.ReadKey();
        }
    }
}
