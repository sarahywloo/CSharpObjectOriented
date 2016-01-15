using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample {
    class Program {
        static void Main(string[] args) {

            new Keyboard().PushButton("Space");
            new VirtualKeyboard().PushButton("Space");

            Console.ReadLine();
        }

        static void PushTheSpaceButton(IKeyboard keyboard) {
            keyboard.PushButton("Space");
        }
    }
}
