using System;
using System.Collections.Generic;
using System.Text;

namespace API_Library.Classes
{
    public class SearchMember
    {
        public string Name { get; set; }

        public SearchMember()
        {

        }

        public override string ToString() => Name;
    }
}
