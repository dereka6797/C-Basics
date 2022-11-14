using static System.Console;

namespace Practice {
    class Constructors {

        static void Main() {
            Person person1 = new();
            WriteLine(person1.Name);

            Person person2 = new("Erin");
            WriteLine(person2.Name);
        }

        public class Person {
        public string Name {get; set;}
        //Constructor without parameter
        public Person() {
            Name = "Empty";
        }
        //Constructor with parameter 
        public Person(string firstName) {
            Name = firstName;
        }
        }
    }
}