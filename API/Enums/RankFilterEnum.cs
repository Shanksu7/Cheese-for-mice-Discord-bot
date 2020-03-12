using System;
using System.Collections.Generic;
using System.Text;

namespace API_Library.Enums
{
    public enum RankFilterEnum
    {
        ADMINISTRATOR    = 1,
        MODERATOR        = 2,
        SENTINEL         = 4,
        MAPCREW          = 8,
        MODULE_TEAM      = 16,
        FUNCORP          = 32,
        FASHION_SQUAD    = 64
    }
}
