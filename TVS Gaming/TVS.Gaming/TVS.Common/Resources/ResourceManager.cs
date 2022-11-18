using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Common.Resources
{
    public static class ResourceManager
    {
        private static System.Resources.ResourceManager _rm = new System.Resources.ResourceManager("TVS.Common.Resources.TVSGamingResources", Assembly.GetExecutingAssembly());

        public static string GetResource(string key)
        {
            return _rm.GetString(key);
        }
    }
}
