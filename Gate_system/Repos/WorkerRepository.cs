using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gate_system.Models;

namespace Gate_system.Repos
{
    public class WorkerRepository
    {

        public static List<Worker> workers = new List<Worker>
        {
            new Worker(1, "Lukas", "Suslavicius", AccessLevel.ResponsobilityHigh, new List<GateName>{GateName.Laborotory}),
            new Worker(2, "Archibald", "Barnes", AccessLevel.ResponsobilityLow, new List<GateName>{GateName.Maintenance}),
            new Worker(3, "Sulayman", "Slayeter", AccessLevel.Management, new List<GateName>{}),
            new Worker(4, "Matteo", "Stevenson", AccessLevel.Admin, new List<GateName>{GateName.Toolshop, GateName.Maintenance}),
            new Worker(5, "Keanu", "Silva", AccessLevel.SuperAdmin, new List<GateName>{GateName.Laborotory, GateName.TrainingRoom}),
            new Worker(6, "Dawud", "Alexander", AccessLevel.ResponsobilityHigh, new List<GateName>{}),
            new Worker(7, "Hasan", "Kent", AccessLevel.ResponsobilityHigh, new List<GateName>{GateName.Laborotory, GateName.TrainingRoom}),
            new Worker(8, "Gabriella", "Escobar", AccessLevel.ResponsobilityHigh, new List<GateName>{GateName.IT, GateName.Laborotory}),
            new Worker(9, "Annabel", "Oconnor", AccessLevel.ResponsobilityLow, new List<GateName>{}),
            new Worker(10, "Ameer", "Meadows", AccessLevel.ResponsobilityLow, new List<GateName>{GateName.Maintenance}),
        };

        public static List<Worker> Retrieve() { return workers; }

        public static Worker Retrieve(int id)
        {
            foreach (Worker worker in workers)
            {
                if (worker.Id == id)
                {
                    return worker;
                }
            }
            return null;
        }

    }
}
