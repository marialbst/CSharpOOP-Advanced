using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CollectionHierarchy
{
    using Interfaces;
    using Models;
    using Core;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Engine eng = new Engine();
            eng.Run();
        }
    }
}
