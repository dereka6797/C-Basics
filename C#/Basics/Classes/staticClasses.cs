using static System.Console;

namespace Practice {
    class StaticClass {
        static void Main() {
            Apartment.Rooms = 3;
            Apartment.Bathrooms = 1;

            Apartment.DisplayApartment();
        }

    //Holds attributes for apartment class
    static class Apartment {
        public static int Rooms {get; set;}
        public static int Bathrooms {get; set;}
        public static string WallColor {get; set;} = "Blue";

        public static void DisplayApartment() {
            WriteLine($"The apartment has {Rooms} rooms and {Bathrooms} bathrooms as well as a nice {WallColor} color added to the walls.");
        }
    }
    }
}