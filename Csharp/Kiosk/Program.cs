using System;

namespace BCHSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("      BCH ENTERPRISE VISITOR KIOSK      ");
            Console.WriteLine("========================================");

            // Capture user inputs
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your organization: ");
            string org = Console.ReadLine();

            Console.Write("Enter your email: ");
            string Email = Console.ReadLine();

            Console.Write("Enter your access level: ");
            string access = Console.ReadLine();

            Console.Write("Enter issuer: ");
            string issuer = Console.ReadLine();

            // Calculate maximum line length for consistent formatting
            int lineWidth = 40; // total width including borders

            // Helper method to create a line with padding
            string CreateLine(string label, string value)
            {
                string content = $"{label}: {value}";
                return $"| {content.PadRight(lineWidth - 3)}|";
            }

            // Print the badge
            Console.WriteLine(new string('=', lineWidth + 2));
            Console.WriteLine(CreateLine("Attendee", name));
            Console.WriteLine(CreateLine("Organization", org));
            Console.WriteLine(CreateLine("Email", Email));
            Console.WriteLine(CreateLine("Access", access));
            Console.WriteLine(CreateLine("Issuer", issuer));
            Console.WriteLine(new string('=', lineWidth + 2));
        }
    }
}
