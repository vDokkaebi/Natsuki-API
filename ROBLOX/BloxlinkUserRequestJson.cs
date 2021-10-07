using Newtonsoft.Json;

namespace Natsuki.API.ROBLOX
{
    internal struct BloxlinkUserRequestJson
    {
        public class Root
        {
            public string Status;
            public string PrimaryAccount;
            public object? MatchingAccount;
        }

    }
}
