using API_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Library.Classes
{
    public class RankFilter
    {
        public List<RankFilterEnum> Filter { get; set; }
        public List<MouseFilter> Result { get; set; }

        public RankFilter()
        {
                
        }
    }
}
