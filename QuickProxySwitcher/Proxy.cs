using System;

namespace QuickProxySwitcher
{
    [Serializable]
    public class Proxy
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string GetData => $"{Name} -> {Address}";
    }
}
