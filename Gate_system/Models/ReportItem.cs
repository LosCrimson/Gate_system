using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gate_system.Models
{
    public class ReportItem
    {

        private int id;
        private string firstName;
        private string lastName;
        private DateTime date;
        private Boolean wasGateEntered;
        private GateFunction whatWasDone;

        public int Id { get { return id; } }

        public string FirstName { get { return firstName;} }

        public string LastName { get { return lastName;} }

        public DateTime Date { get { return date; } }

        public Boolean WasGateEntered { get { return wasGateEntered; } }

        public GateFunction WhatWasDone { get { return whatWasDone; } }

        public ReportItem(int id, string firstName, string lastName, DateTime date, Boolean wasGateEntered, GateFunction whatWasDone)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.date = date;
            this.wasGateEntered = wasGateEntered;
            this.whatWasDone = whatWasDone;
        }
    }
}
