using System;
using LuckySpin.Models;
using System.Collections.Generic;

namespace LuckySpin.Services
{
    public class RepositoryService
    {
        private List<Spin> spins = new List<Spin>();

        //Properties
        public IEnumerable<Spin> PlayerSpins {

            get { return spins; }
        }
        public Player Player { get; set; } /* NEW - include the Player in the data store */

        //Method to add spin to data store collection 
        public void AddSpin(Spin s)
        {
            spins.Add(s);
        }
    }
}
