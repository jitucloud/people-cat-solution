using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleCAT.API.Online.Model
{
    /// <summary>
    /// Pet class
    /// </summary>
    public class Pet
    {
        public string Name { get; set; }
        public AnimalType Type { get; set; }
    }
}