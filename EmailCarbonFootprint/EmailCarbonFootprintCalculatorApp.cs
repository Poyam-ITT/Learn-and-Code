namespace EmailCarbonFootprint
{
    internal class EmailCarbonFootprintCalculatorApp
    {
        internal static void Main()
        {
            Console.WriteLine("This is the Program for calculating the Email Carbon Footprint");
            EmailInfo emailInfo = GetUserInput();
            CarbonFootprintCalculator calculator = new CarbonFootprintCalculator(emailInfo);
            CarbonFootprintResponse response = calculator.CalculateCarbonFootprint();
            PrintResponse(response);
        }

        private static EmailInfo GetUserInput()
        {
            string email;
            int inbox, spam, sent;

            while (true)
            {
                Console.WriteLine("Enter your email id:");
                email = Console.ReadLine();

                Console.WriteLine("Enter the number of emails present in your inbox:");
                if (!TryParseIntInput("inbox", out inbox))
                {
                    continue;
                }

                Console.WriteLine("Enter the number of emails present in your spam/junk folder:");
                if (!TryParseIntInput("spam", out spam))
                {
                    continue;
                }

                Console.WriteLine("Enter the number of emails present in your sent folder:");
                if (!TryParseIntInput("sent", out sent))
                {
                    continue;
                }
                break;
            }

            return new EmailInfo(email, inbox, spam, sent);
        }

        private static bool TryParseIntInput(string inputName, out int result)
        {
            if (int.TryParse(Console.ReadLine(), out result))
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Invalid input for {inputName}. Please enter a valid integer.");
                return false;
            }
        }

        private static void PrintResponse(CarbonFootprintResponse response)
        {
            Console.WriteLine("\nYour Current Email Carbon Footprint Response is:");
            Console.WriteLine("emailId : " + response._email);
            Console.WriteLine("source : " + response._source);
            Console.WriteLine("inbox : " + response._inboxCarbonFootPrint + "g");
            Console.WriteLine("sent : " + response._sentCarbonFootPrint + "g");
            Console.WriteLine("spam : " + response._spamCarbonFootPrint + "g");
        }
    }
}