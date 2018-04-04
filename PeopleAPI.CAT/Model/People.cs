using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleCAT.API.Online.Model
{
    /// <summary>
    /// People class
    /// </summary>
    public class People
    {
        public string name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public List<Pet> Pets { get; set; }
        public People()
        {
            Pets = new List<Pet>();
        }
    }
}