using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayClass;

namespace _01._02hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Play p = new Play("Name", "Genre", "Author")) { }
            Play _p = new Play("Name", "Genre", "Author");
        }
    }
}
