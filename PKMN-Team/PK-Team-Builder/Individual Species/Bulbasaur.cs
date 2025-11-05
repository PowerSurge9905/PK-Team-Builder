using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Pokemon_Classes
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur() { }

        public Bulbasaur(int hpIV, int atkIV, int defIV, int spAtkIV, int spDefIV, int speedIV)
        {
            this.hpIV = hpIV;
            this.atkIV = atkIV;
            this.defIV = defIV;
            this.spAtkIV = spAtkIV;
            this.spDefIV = spDefIV;
            this.speedIV = speedIV;
        }
    }
}
