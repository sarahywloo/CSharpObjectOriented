using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount {
    abstract class Car {

        //General rule: no more than 7 levels of inheritance
        public string VIN { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateTax() {
            return Price * 0.08m;
        }
    }

    //NewCar extends from Class Car
    class NewCar: Car {
    }

    class UsedCar: Car {
        public int Miles { get; set; }
    }

    class CertifiedUsedCar: UsedCar {
        public int WarrantyMonths { get; set; }

    }

}
