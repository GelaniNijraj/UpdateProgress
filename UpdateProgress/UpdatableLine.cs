using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateProgress {
    public class UpdatableLine {
        public int Top;
        
        public void Display(string message) {
            Top = Console.CursorTop;
            Console.WriteLine(message);
        }

        public void Update(string message) {
            int backToTop = Console.CursorTop,
                backToLeft = Console.CursorLeft ;
            Console.CursorTop = Top;
            Console.CursorLeft = 0;
            for (int i = 0; i < Console.WindowWidth; Console.Write(" "), i++) ;
            Console.CursorLeft = 0;
            Console.CursorTop = Top;
            Console.Write(message);
            Console.CursorTop = backToTop;
            Console.CursorLeft = backToLeft;
        }
    }
}
