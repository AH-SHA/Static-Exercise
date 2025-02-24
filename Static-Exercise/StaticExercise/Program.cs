namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Fahrenheit to Celsius conversion calculator
            //1. Get user input
            Console.WriteLine("");
            Console.WriteLine("*******Celsius Conversion*******");
            Console.WriteLine("Enter Fahrenheit temperature:");

            //2. Convert user's input from string into 'double' format, so it works as a parameter in the Method's calculations
            double userFahren = double.Parse(Console.ReadLine());

            //3. Call the static method created in the class,by using the "Class'sType.StaticProperty = value " syntax
            //The Method was created within a Class (static Class) in the Project File

            //4. Store the Method's result in a variable also used in the method.
            //The variable used in the Method's parameter, was created from the user's input. It also used in the Method's scope.
            var celsiusAnswer = TempConverter.ConvertFahrenToCel(userFahren);

            //5. Print the answer to the console
            Console.WriteLine($"{celsiusAnswer} degrees Celsius");


            //Calculator to convert Celsius to Fahrenheit. Same steps used below as above.
            Console.WriteLine("");
            Console.WriteLine("*******Fahrenheit Conversion******");
            Console.WriteLine("Enter Celsisus temperature:");
            double userCelsius = double.Parse(Console.ReadLine());

            var fahrenAnswer = TempConverter.ConvertCelsiusToFahren(userCelsius);

            Console.WriteLine($"{fahrenAnswer} degrees Fahrenheit");

        }

        

    }
}
