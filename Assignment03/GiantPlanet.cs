using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class GiantPlanet: Planet, IHasMoons, IHasRings
    {

        //Private Instnce Variable ++++++++++++++++++
        private string _type;

        // Constructor Method ++++++++++++++++++++++++++++
        public GiantPlanet(string type, string nameG, double diameterG, double massG)
            : base (nameG, diameterG, massG)
        {
            this._type = type;
        }


        //Public Method ++++++++++++++++++++++++++++++++++

        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;
        }


        public bool HasRings()
        {
            return (RingCount > 0) ? true : false;
        }
    }
}
