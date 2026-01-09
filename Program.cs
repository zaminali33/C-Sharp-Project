using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== UNIVERSITY CARD SYSTEM ===");
        
        // Get student information
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your ID: ");
        string id = Console.ReadLine();
        
        // Select status
        Console.WriteLine("\nSelect your status:");
        Console.WriteLine("1. Student");
        Console.WriteLine("2. Faculty");
        Console.WriteLine("3. Ex-Student");
        Console.Write("Enter choice (1-3): ");
        string statusChoice = Console.ReadLine();
        
        string status = "";
        
        if (statusChoice == "1")
        {
            status = "Student";
        }
        else if (statusChoice == "2")
        {
            status = "Faculty";
        }
        else if (statusChoice == "3")
        {
            status = "Ex-Student";
        }
        else
        {
            Console.WriteLine("Invalid choice. Setting as Student.");
            status = "Student";
        }
        
        // Select card type
        Console.WriteLine("\nSelect card type:");
        Console.WriteLine("1. ID Card");
        Console.WriteLine("2. Library Card");
        Console.WriteLine("3. Access Card");
        Console.Write("Enter choice (1-3): ");
        string cardChoice = Console.ReadLine();
        
        string cardType = "";
        int fee = 0;
        
        if (cardChoice == "1")
        {
            cardType = "ID Card";
        }
        else if (cardChoice == "2")
        {
            cardType = "Library Card";
        }
        else if (cardChoice == "3")
        {
            cardType = "Access Card";
        }
        else
        {
            Console.WriteLine("Invalid choice. Setting as ID Card.");
            cardType = "ID Card";
        }
        
        // Calculate fee
        if (status == "Student" || status == "Faculty")
        {
            if (cardType == "ID Card")
            {
                fee = 0;
            }
            else if (cardType == "Library Card")
            {
                fee = 5;
            }
            else if (cardType == "Access Card")
            {
                fee = 10;
            }
        }
        else if (status == "Ex-Student")
        {
            if (cardType == "ID Card")
            {
                fee = 20;
            }
            else if (cardType == "Library Card")
            {
                fee = 30;
            }
            else if (cardType == "Access Card")
            {
                fee = 50;
            }
        }
        
        // Display summary
        Console.WriteLine("\n=== CARD REQUEST SUMMARY ===");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Status: " + status);
        Console.WriteLine("Card Type: " + cardType);
        
        if (fee == 0)
        {
            Console.WriteLine("Fee: FREE");
        }
        else
        {
            Console.WriteLine("Fee: $" + fee);
            
            // Payment method
            Console.WriteLine("\nSelect payment:");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Card");
            Console.Write("Enter choice (1-2): ");
            string payChoice = Console.ReadLine();
            
            if (payChoice == "1")
            {
                Console.WriteLine("Pay at cash counter.");
            }
            else if (payChoice == "2")
            {
                Console.WriteLine("Card payment accepted.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Pay at office.");
            }
        }
        
        Console.WriteLine("\nThank you! Your request is processed.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
