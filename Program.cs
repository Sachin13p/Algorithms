using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            RatInTheMaze rt = new RatInTheMaze();
            rt.main();
            MultisourceTreasureIsland ms = new MultisourceTreasureIsland();
            ms.Main(new string[] { });

        }
    }
}
