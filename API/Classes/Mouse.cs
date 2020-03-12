using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Library.Classes
{
    [JsonObject]
    public class Mouse
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int? Experience { get; set; }
        public string Look { get; set; }
        public string Badges { get; set; }
        public string Dress_List { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Skills { get; set; }
        public int? Round_Played { get; set; }
        public int? Shaman_Cheese { get; set; }
        public int? Saved_Mice { get; set; }
        public int? Saved_Mice_Hard { get; set; }
        public int? Saved_Mice_Divine { get; set; }
        public int? Cheese_Gathered { get; set; }
        public int? First { get; set; }
        public int? Bootcamp { get; set; }
        public int? Survivor_Round_Played { get; set; }
        public int? Survivor_Mouse_Killed { get; set; }
        public int? Survivor_Shaman_Count { get; set; }
        public int? Survivor_Survivor_Count { get; set; }
        public int? Racing_Round_Played { get; set; }
        public int? Racing_Finished_Map { get; set; }
        public int? Racing_First { get; set; }
        public int? Racing_Podium { get; set; }
        public int? Id_Tribe { get; set; }
        public int? Id_Spouse { get; set; }
        public int? Id_Gender { get; set; }
        public int? Marriage_Date { get; set; }
        public string Tribe_Name { get; set; }
        public string Rank { get; set; }

        public Mouse()
        {

        }


    }
}
