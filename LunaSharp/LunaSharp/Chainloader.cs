using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaSharp
{
    public class Chainloader
    {
        private static readonly Chainloader s_instance = new Chainloader();

        private Dictionary<string, AddonCollection> _entrypoints = new Dictionary<string, AddonCollection>();

        static Chainloader()
        {
        }

        private Chainloader()
        {
        }

        public static Chainloader Instance
        {
            get => s_instance;
        }

        public static string AddonsDirectoryPath
        {
            get => Path.Combine(Environment.CurrentDirectory, "Luna", "Addons");
        }

        public void CreateEntrypoint(string function)
        {
            _entrypoints.Add(function, new AddonCollection());
        }

        public void InvokeEntrypoint(string function)
        {
            AddonCollection addons = _entrypoints[function];

        }

        public Addon LoadAddon(string id)
        {

        }

        public Addon LoadUncompiledAddon(string path)
        {

        }

        public Addon LoadCompiledAddon(string path)
        {

        }
    }
}
