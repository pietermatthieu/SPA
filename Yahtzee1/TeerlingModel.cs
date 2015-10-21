using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee1
{
    public class TeerlingModel
    {

        private int _aantalOgen;

        public TeerlingModel()
        {
            
        }

        public int AantalOgen
        {
            get
            {
                return _aantalOgen;
            }

            set
            {
                _aantalOgen = value;
            }
        }

    }
}
