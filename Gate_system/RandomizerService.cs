using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Gate_system.Models;
using Gate_system.Repos;

namespace Gate_system
{
    public class RandomizerService
    {
        public Worker RandomizeWorker()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 11);
            return WorkerRepository.Retrieve(i);
        }

        public Gate RandomizeGate()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 9);
            return GateRepository.Retrieve(i);
        }

        private static Random rndHour = new Random();
        public static double RandomizeHour()
        {
            return rndHour.NextDouble() * (481.0 - 1.0) + 1.0;
        }
    }
}
