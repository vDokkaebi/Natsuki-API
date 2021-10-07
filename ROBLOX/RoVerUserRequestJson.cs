using Newtonsoft.Json;

namespace Natsuki.API.ROBLOX
{
    internal struct RoVerUserRequestJson
    {
        public class Root
        {
            public string Status { get; set; }
            public string RobloxUsername { get; set; }
            public int RobloxId { get; set; }
        }
    }
}
