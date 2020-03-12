using API_Library.Classes;
using API_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API_Library.Manager
{
    public class MouseManager : Web
    {
        public static async Task<Mouse> GetMouse(string username) => await GetAsync<Mouse>($"mouse/@{username}");

        public static async Task<List<SearchMember>> SearchMice(string username) => await GetAsync<List<SearchMember>>($"mouse/search?query={username}");

        public static async Task<RankFilter> FilterRank(RankFilterEnum filter) => await GetAsync<RankFilter>($"mouse/rank?query={(int)filter}");
        
    }
}
