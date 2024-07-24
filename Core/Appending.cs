using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charon_Hash_Detector.Core
{
    class Appending
    {
        public static void AppendToJerar(string key)
        {
            if (Config.algorithms.ContainsKey(key))
            {
                Config.jerar.Add(Config.algorithms[key]);
            }
        }
    }
}
