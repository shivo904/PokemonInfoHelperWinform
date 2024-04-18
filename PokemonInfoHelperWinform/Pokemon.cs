using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInfoHelperWinform
{
    internal class Pokemon
    {
        internal string Name { get; set; }
        internal string Type1 { get; set; }
        internal string Type2 { get; set; }
        internal string NationalID { get; set; }
        internal Pokemon()
        {
            Name = "";
            Type1 = "";
            Type2 = "";
            NationalID = "";
        }
    }
}
