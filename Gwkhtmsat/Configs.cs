using System.Collections.Generic;

namespace Gwkhtmsat
{
    public class Configs : Exiled.API.Interfaces.IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public List<string> Lines { get; set; } = new List<string>();
    }
}
