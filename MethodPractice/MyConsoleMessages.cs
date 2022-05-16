namespace MethodPractice
{
    public static class MyConsoleMessages
    {


        public static string GetFirstName()
        {
            Console.Write("Enter your First Name: ");
            var firstName = Console.ReadLine();

            while (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine(":::horrified whisper::: There's nobody here. \n!?! Hello...\n");
                Console.Write("First Name can't be empty! Enter your First Name: ");
                firstName = Console.ReadLine();
            }

            return firstName;
        }

        public static string GetLastName()
        {
            Console.Write("Enter your last name: ");
            var lastName = Console.ReadLine();

            while (string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine(":::horrified whisper::: There's nobody here. \n!?! Hello...\n");
                Console.Write("Last Name can't be empty! Enter your Last Name: ");
                lastName = Console.ReadLine();
            }

            return lastName;
        }

        public static double GetX()
        {
            string? textX = "";
            bool isValid = false;
            double X = 0;

            while (isValid == false || string.IsNullOrEmpty(textX))
            {
                Console.Write("Enter a Number: ");
                textX = Console.ReadLine();
                isValid = double.TryParse(textX, out  X);
            }

            return X;
        }

        public static double GetY()
        {
            string? textY = "";
            bool isValid = false;
            double Y = 0;

            while (isValid == false || string.IsNullOrEmpty(textY))
            {
                Console.Write("Enter a Number: ");
                textY = Console.ReadLine();
                isValid = double.TryParse(textY, out Y);
            }

            return Y;
        }
    }
}
