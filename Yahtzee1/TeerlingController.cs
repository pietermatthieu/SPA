using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee1
{
    public class TeerlingController
    {
        public TeerlingView view;
        public TeerlingModel model;

        public TeerlingController()
        {
            view = new TeerlingView( this );
            model = new TeerlingModel();
        }

        public TeerlingView GetView()
        {
            return view;
        }

        public void Werp()
        { 
            //update aantal ogen
            Random random = new Random();

            int aantalOgen = random.Next(1,7);

            model.AantalOgen = aantalOgen;
            //Console.WriteLine(aantalOgen);
        }

    }
}
