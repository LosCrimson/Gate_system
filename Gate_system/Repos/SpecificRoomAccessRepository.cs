using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gate_system.Models;

namespace Gate_system.Repos
{
    public class SpecificRoomAccessRepository
    {

        public List<GateName> accessLevels= new List<GateName>();

        public List<GateName> Retrieve() { return accessLevels; }

        public GateName Retrieve(int id)
        {
            foreach (GateName accessLevel in accessLevels)
            {
                if ((int)accessLevel == id)
                {
                    return accessLevel;
                }
            }
            return GateName.MainEnterance;
        }
    }
}
