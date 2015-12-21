using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragsgeneratorSTS2
{
    class Region
    {
        string regionName;
        int regionId;
        string regionAbkuerzung;

        public void anlegen (string name, int id, string abk)
        {
            this.regionName = name;
            this.regionId = id;
            this.regionAbkuerzung = abk;
        }
    }
}
