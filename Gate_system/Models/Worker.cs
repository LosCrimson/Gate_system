using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gate_system.Models
{
    public class Worker
    {

        private int id;
        private string firstName;
        private string lastName;
        private AccessLevel workerAccessLevel;
        private List<GateName> gateNames;

        public int Id { get { return id; } }

        public string FirstName { get { return firstName;} }

        public string LastName { get { return lastName;} }

        public AccessLevel WorkerAccessLevel { get { return workerAccessLevel; } }

        public List<GateName> GateNames { get { return gateNames; } }

        public Worker(int id, string firstName, string lastName, AccessLevel workerAccessLevel, List<GateName> gateNames)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.workerAccessLevel = workerAccessLevel;
            this.gateNames = gateNames;
        }

    }
}
