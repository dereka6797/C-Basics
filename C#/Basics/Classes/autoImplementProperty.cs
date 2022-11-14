using static System.Console;

namespace Practice {
    class AutoImplement {
        static void Main() {
            Vehicle brand = new();
            
            brand.Car = "Honda";
            WriteLine(brand.Car);
        }
        public class Vehicle {
            public string Car {get; set;}
        }
    }
}