using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gate_system.Models;

namespace Gate_system.Repos
{
    public class GateRepository
    {

        public static List<Gate> gates = new List<Gate>
        {
            new Gate(1, GateName.MainEnterance, GateFunction.EnterExit, AccessLevel.ResponsobilityLow),
            new Gate(2, GateName.MainEnterance, GateFunction.CheckInCheckOut, AccessLevel.ResponsobilityLow),
            new Gate(3, GateName.WarehouseEnterance, GateFunction.EnterExit, AccessLevel.ResponsobilityLow),
            new Gate(4, GateName.Laborotory, GateFunction.Enter, AccessLevel.Admin),
            new Gate(5, GateName.IT, GateFunction.Enter, AccessLevel.SuperAdmin),
            new Gate(6, GateName.Toolshop, GateFunction.Enter, AccessLevel.ResponsobilityHigh),
            new Gate(7, GateName.Maintenance, GateFunction.EnterExit, AccessLevel.ResponsobilityHigh),
            new Gate(8, GateName.TrainingRoom, GateFunction.EnterExit, AccessLevel.Management),
        };

        public static List<Gate> Retrieve() { return gates; }

        public static Gate Retrieve(int id)
        {
            foreach (Gate gate in gates)
            {
                if (gate.Id == id)
                {
                    return gate;
                }
            }
            return null;
        }

    }
}
