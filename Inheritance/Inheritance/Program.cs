using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    class Program {
        static void Main(string[] args) {

            FullTimeEmployee bill = new FullTimeEmployee {
                FirstName = "Bill",
                LastName = "Gates",
                YearsEmployed = 5
            };

            Debug.Assert(bill.ShowFullName() == "Bill Gates", "Employee's name is Bill Gates");
            Debug.Assert(bill.YearsEmployed == 5, "Employee has been working for 5 years!");

            ContractEmployee steve = new ContractEmployee {
                FirstName = "Steve",
                LastName = "Jobs",
                MonthsEmployed = 2
            };

            Debug.Assert(steve.ShowFullName() == "Steve Jobs", "Employee's name is Steve Jobs");
            Debug.Assert(steve.MonthsEmployed == 2, "Employee has been working for 2 months!");

            Console.ReadLine();
        }
    }
}
