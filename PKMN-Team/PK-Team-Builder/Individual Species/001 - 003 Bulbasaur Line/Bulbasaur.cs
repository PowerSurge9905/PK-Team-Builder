using PK_Team_Builder.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder.Individual_Species._001___003_Bulbasaur_Line
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur()
        {
            InitializePokemon(Species.Bulbasaur);
        }

        public Bulbasaur(int hpIV, int atkIV, int defIV, int spAtkIV, int spDefIV, int speedIV)
        {
            InitializePokemon(Species.Bulbasaur);
            this.hpIV = hpIV;
            this.atkIV = atkIV;
            this.defIV = defIV;
            this.spAtkIV = spAtkIV;
            this.spDefIV = spDefIV;
            this.speedIV = speedIV;
        }
    }
}
