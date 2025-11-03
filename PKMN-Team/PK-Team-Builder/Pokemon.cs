using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Team_Builder
{
    internal abstract class Pokemon
    {
        protected Pokemon()
        {
        }

        // Individual Values (IVs)
        protected int hpIV;
        protected int atkIV;
        protected int defIV;
        protected int spAtkIV;
        protected int spDefIV;
        protected int speedIV;

        // Effort Values (EVs)
        protected int hpEV;
        protected int atkEV;
        protected int defEV;
        protected int spAtkEV;
        protected int spDefEV;
        protected int speedEV;

        // Species and Base Stats
        protected Species species;
        protected int baseHP;
        protected int baseAtk;
        protected int baseDef;
        protected int baseSpAtk;
        protected int baseSpDef;
        protected int baseSpeed;

        protected Natures nature;

        // TODO: Determine whether to declare moveset here or in each species' class
    }
}
