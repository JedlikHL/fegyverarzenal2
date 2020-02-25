using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyverarzenal
{
    class Program
    {
        enum fegyverek {apaökle, uzi, lángszóró, kézigránát, revolver, gépágyú, shotgun};
        static void Main(string[] args)
        {
            List<fegyverek> fegyvertár = new List<fegyverek>();
            //egy fegyver csak egy példányban szerepel
            Felpakol(fegyvertár); //Összes fegyót berakja a tárba
            Listázó(fegyvertár);
            Console.WriteLine(FegyverSzám(fegyvertár));
            Kivesz(fegyvertár,fegyverek.gépágyú); //Konkrét vegyvert kivesz
            Listázó(fegyvertár);
            Felvesz(fegyvertár, fegyverek.gépágyú); //Egy fegyvert betesz a tárba a végére
            Listázó(fegyvertár);
            Felvesz(fegyvertár); //Meghatározott helyre rak be
            Listázó(fegyvertár);
            
            Listázó(fegyvertár);
            int db = FegyverSzám(fegyvertár);
            
            
            Console.ReadKey();
        }

        static int FegyverSzám(List<fegyverek> fegyvertár)
        {
            int dbszám = 0;
            for (int i = 0; i < fegyvertár.Count; i++)
            {
                
                dbszám++;
            }
            return dbszám;
        }

        static void Felvesz(List<fegyverek> fegyvertár)
        {
            if (!fegyvertár.Contains(fegyverek.uzi))
            {
                fegyvertár.RemoveAt(2);
                fegyvertár.Insert(2, fegyverek.uzi);
            }
            else Console.WriteLine("Tele van!");
            
            
        }

        static void Felvesz(List<fegyverek> fegyvertár, fegyverek gépágyú)
        {
            fegyvertár.Add(fegyverek.gépágyú);
        }

        static void Kivesz(List<fegyverek> fegyvertár, fegyverek gépágyú)
        {
            fegyvertár.Remove(fegyverek.gépágyú);
        }

        static void Listázó(List<fegyverek> fegyvertár)
        {
            foreach (fegyverek kézben in fegyvertár)
            {
                Console.WriteLine(kézben);
            }
        }


        static void Felpakol(List<fegyverek> fegyvertár)
        {
            fegyvertár.Add(fegyverek.apaökle);
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.lángszóró);
            fegyvertár.Add(fegyverek.kézigránát);
            fegyvertár.Add(fegyverek.revolver);
            fegyvertár.Add(fegyverek.gépágyú);
            fegyvertár.Add(fegyverek.shotgun);
        }
    }
}
