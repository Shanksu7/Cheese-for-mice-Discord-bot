using System;
using System.Collections.Generic;
using System.Text;

namespace API_Library.Classes
{
    public class Tribe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<SearchMember> Members { get; set; }

        public Tribe()
        {

        }
    }
}
