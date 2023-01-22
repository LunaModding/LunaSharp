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
        private static readonly Chainloader _instance = new Chainloader();

        static Chainloader()
        {
        }

        private Chainloader()
        {
        }

        public static Chainloader Instance
        {
            get => _instance;
        }

        public static string AddonsDirectoryPath
        {
            get => Path.Combine(Environment.CurrentDirectory, "Luna", "Addons");
        }
    }
}
