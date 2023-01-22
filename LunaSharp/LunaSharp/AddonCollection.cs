using System.Collections.Generic;

namespace LunaSharp
{
    public class AddonCollection : Dictionary<string, Addon>
    {
        public static AddonCollection operator +(AddonCollection addons, Addon addon)
        {
            addons.Add(addon.Id, addon);
            return addons;
        }
    }
}
