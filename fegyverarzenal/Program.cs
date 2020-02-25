using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyverarzenal
{
    class Program
    {
        enum fegyverek {apaökle, uzi, lángszóró, kézigránát};
        static void Main(string[] args)
        {
            fegyverek kezemben = fegyverek.kézigránát;
            List<fegyverek> fegyvertár = new List<fegyverek>();
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.lángszóró);
            foreach (fegyverek fegyver in fegyvertár)
            {
                Console.WriteLine(fegyver);
            }
            Console.ReadKey();
        }
    }
}
