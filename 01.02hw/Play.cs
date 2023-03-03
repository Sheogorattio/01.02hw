using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayClass
{ 
    public class Play : IDisposable
    {
        public string Name { set; get; }
        public string Genre { set; get; }
        public string Author { set; get; }
        public int Year { set; get; }
        public Play(string name, string genre, string author)
        {
            Name = name;
            Genre = genre;
            Author = author;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Disposable was called");
        }
        ~Play()
        {
            Console.WriteLine("Destuctor was called");
        }
    }
}
