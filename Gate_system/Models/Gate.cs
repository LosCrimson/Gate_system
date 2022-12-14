using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gate_system.Models
{
    public class Gate
    {

        private int id;
        private GateName gateName;
        private GateFunction gateFunction;
        private AccessLevel gateAccessLevel;

        public int Id { get { return id; } }

        public GateName GateName { get { return gateName; } }

        public GateFunction GateFunction { get { return gateFunction; } set { gateFunction = value; } }

        public AccessLevel AccessLevel { get { return gateAccessLevel; } set { gateAccessLevel = value;} }

        public Gate(int id, GateName gateName, GateFunction gateFunction, AccessLevel gateAccesslevel) 
        { 
            this.id = id;
            this.gateName = gateName;
            this.gateFunction = gateFunction;
            this.gateAccessLevel = AccessLevel.ResponsobilityLow;
        }
    }
}
