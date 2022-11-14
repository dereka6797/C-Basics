using static System.Console;

namespace Practice {
    class GetSetProp {
        static void Main() {
            Month newMonth = new();
            newMonth.MonthVerify = 3;
            WriteLine(newMonth.MonthVerify);

            newMonth.MonthVerify = 20;
            WriteLine(newMonth.MonthVerify);
        }
        public class Month {
            private int theMonth;

            private int MonthVerify {
                get {
                    if((theMonth > 12) || (theMonth < 0)) { //If number is greater than 12 or less than 0 the value is set to zero.
                        theMonth = 0;
                    }
                    return theMonth;
                }
                set {
                    theMonth = value;
                }
            }
        }
    }
}