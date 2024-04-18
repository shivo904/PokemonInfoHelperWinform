using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInfoHelperWinform
{
    internal class SWChart
    {
        internal Dictionary<string, double> SW { get; set; }
        internal SWChart()
        {
            SW = new Dictionary<string, double>();
        }
    }
}
