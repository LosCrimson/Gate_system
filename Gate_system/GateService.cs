using Gate_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gate_system
{
    public class GateService
    {
        public static Boolean entered = false;
        public Boolean Entered { get { return entered; } private set { entered = value; } }
      
        public DateTime EnteredGate() 
        { return DateTime.Now; }

        public DateTime ExitedGate()
        { return DateTime.Now; }

        public DateTime TryGate(Worker worker, Gate gate)
        { 
            if(worker.WorkerAccessLevel == gate.AccessLevel) 
            {
                if(entered == false)
                {
                    entered = true;
                    return EnteredGate();
                }
                else
                {
                    entered = false;
                    return ExitedGate();
                }
            }
            else
            {
                return DateTime.Now;
            }
        }
    }
}
