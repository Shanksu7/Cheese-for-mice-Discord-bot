using API_Library.Classes;
using API_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API_Library.Manager
{
    public class TribeManager : Web
    {
        public static async Task<Tribe> GetTribe(string tribename) => await GetAsync<Tribe>($"tribe/@{tribename}");

        public static async Task<Tribe> GetTribeByUser(string username) => await GetAsync<Tribe>($"tribe/:{username}");

        public static async Task<List<SearchMember>> SearchTribe(string tribename) => await GetAsync<List<SearchMember>>($"tribe/search?query={tribename}");
    }
}
