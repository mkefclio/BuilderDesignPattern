using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Toy
    {
        public string Type { get; set; }
        public List<string> Parts { get; private set; } = new();

        public void AddPart(string part)
        {
            Parts.Add(part);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Toy Type: {Type}");
            Console.WriteLine("Parts:");
            Parts.ForEach(part => Console.WriteLine($" - {part}"));
        }
    }
}
