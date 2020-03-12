using API_Library.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Library.Classes
{
    public class MouseFilter
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public List<RankFilterEnum> Normalized { get; set; }

        public MouseFilter()
        {

        }
    }
}
