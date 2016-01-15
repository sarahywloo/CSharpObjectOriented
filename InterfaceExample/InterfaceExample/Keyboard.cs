using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample {

    //Use interfaces if you 2 things need to perform a similar task but will do it differently

    class Keyboard : IKeyboard {

        public void PushButton(string buttonToPush) {
            Console.WriteLine(buttonToPush);
        }
    }

    class VirtualKeyboard : IKeyboard {

        public void PushButton(string buttonToPush) {
            foreach (var letter in buttonToPush) {
                Console.WriteLine(letter);
            }
            Console.WriteLine();
        }
    }
}
