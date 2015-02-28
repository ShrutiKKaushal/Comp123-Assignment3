using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //Private Instance variable +++++++++++=
        private bool _oxygen;



        //Constructor +++++++++++++++++

        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }


        //Public Method ++++++++++++++++++++++++

        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false; // use of ternary opertor ( similar to if-else)
        }


        public bool Habitable()
        {
            return (this._oxygen == true) ? true : false;
        }
    }
}
