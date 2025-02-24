using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    //1. Create a static class and name it
    public static class TempConverter
    {
        
        //Notice, there is no empty static constructor used at this point, because it is not needed.  The Class only contains methods.
        //NOT NEEDED:  "static class TempConverter(){}" - statement not needed in this class, but some classes with fields and properties contain it. Not those only using methods.

        //Creating 2 methods needed to calculate tempurature conversions (lsited below)

        //Ensure 'static' is used in Method's signature because all members of a static class must be static
        //The method's parameter lists the type of variable and the variable name. That variable is created in the Program file's Main Program method
        //The method's calculation's result is stored into a new variable 'celsius Answer'
        //A "return" statement is used in the Method, as all method's require.
        //The Method's value is returned to a variable. The same variable in the Main Program file that is equal to the Call of the Method
        public static double ConvertFahrenToCel(double userFahren)
        {
            //Note, the use of '0.555555556' reflects the decimal version of '5/9'
            /*Because we have listed the 'double" as input and output for the method,
            C# reads a fraction as two integers, so it won't compute the formula without you first converting the fraction into a decimal*/
            //Original conversion formula is: ((fahrenheit temprature - 32) * 5/9)


            var celsiusAnswer = (((userFahren) - 32) * 0.55555555556);
            return celsiusAnswer;
            

        }

        public static double ConvertCelsiusToFahren(double userCelsius)
        {
            
            var fahrenAnswer = (((userCelsius) * 1.8) + 32);

            return fahrenAnswer;

            
        }
       
    }
}
