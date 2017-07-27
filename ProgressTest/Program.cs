using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UpdateProgress;

namespace ProgressTest {
    class Program {
        static void Main(string[] args) {
            UpdatableLine line = new UpdatableLine();
            Console.WriteLine("First line");
            line.Display("Hello, World");
            Console.WriteLine("Third line");
            line.Update("Updated!");
            Console.WriteLine("Fourth Line");
            int i = 1;
            while (i < 100) {
                System.Threading.Thread.Sleep(300);
                line.Update(i++ + "%");
            }
        }
    }
}
