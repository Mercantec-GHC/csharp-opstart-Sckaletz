// See https://aka.ms/new-console-template for more information

using System;
using Microsoft.VisualBasic.CompilerServices;

internal class Program
{
    public static void Main(string[] args)
    {
        /*
        Console.WriteLine("a" == "a");
        Console.WriteLine("a" == "A");
        Console.WriteLine(1 == 2);

        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
        */

        /*
        Console.WriteLine("a" != "a");
        Console.WriteLine("a" != "A");
        Console.WriteLine(1 != 2);

        string myValue = "a";
        Console.WriteLine(myValue != "a");
        */

        /*
        Console.WriteLine(1 > 2);
        Console.WriteLine(1 < 2);
        Console.WriteLine(1 >= 1);
        Console.WriteLine(1 <= 1);
        */

        /*
        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));
        */

        /*
        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(!pangram.Contains("fox"));
        Console.WriteLine(!pangram.Contains("cow"));
        */

        /*
        int saleAmount = 1001;
        // int discount = saleAmount > 1000 ? 100 : 50;

        Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
        */

        /*
        Random coins = new Random();
        string headsOrTails = coins.Next(101) >= 50 ? "Heads" : "Tails";
        Console.WriteLine(headsOrTails);
        */

        /*
        string permission = "Admin|Manager";
        int level = 55;

        string isAdmin = permission.Contains("Admin") && level >= 55
            ? "Welcome, Super Admin user."
            : "Welcome, Admin user.";
        Console.WriteLine(isAdmin);
        */

        /*
        string permission = "Admin|Manager";
        int level = 53;

        if (permission.Contains("Admin"))
        {
            if (level > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else
            {
                Console.WriteLine("Welcome, Admin user.");
            }
        }
        else if (permission.Contains("Manager"))
        {
            if (level >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
        */

        /*
        bool flag = true;
        int value = 0;

        if (flag)
        {
            Console.WriteLine($"Inside the code block: {value}");
        }

        value = 10;
        Console.WriteLine($"Outside the code block: {value}");
        */

        /*
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;
        bool found = false;

        foreach (int number in numbers)
        {
            

            total += number;

            if (number == 42)
            {
                found = true;

            }
        }

        if (found)
        {
            Console.WriteLine("Set contains 42");

        }

        Console.WriteLine($"Total: {total}");
        */

        /*
        int employeeLevel = 100;
        string employeeName = "John Smith";

        string title = "";

        switch (employeeLevel)
        {
            case 100:
            case 200:
                title = "Senior Associate";
                break;
            case 300:
                title = "Manager";
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }

        Console.WriteLine($"{employeeName}, {title}");
        */

        /*
        // SKU = Stock Keeping Unit. 
        // SKU value format: <product #>-<2-letter color code>-<size code>
        string sku = "01-MN-L";

        string[] product = sku.Split('-');

        string type = "";
        string color = "";
        string size = "";

        switch (product[0])
        {
            case "01":
                type = "Sweat shirt";
                break;
            case "02":
                type = "T-Shirt";
                break;
            case "03":
                type = "Sweat pants";
                break;
            default:
                type = "Other";
                break;
        }

        switch (product[1])
        {
            case "BL":
                color = "Black";
                break;
            case "MN":
                color = "Maroon";
                break;
            default:
                color = "White";
                break;
        }

        switch (product[2])
        {
            case "S":
                size = "Small";
                break;
            case "M":
                size = "Medium";
                break;
            case "L":
                size = "Large";
                break;
            default:
                size = "One Size Fits All";
                break;
        }

        Console.WriteLine($"Product: {size} {color} {type}");
        */

        /*
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names.Length; i++)
            if (names[i] == "David") names[i] = "Sammy";

        foreach (var name in names) Console.WriteLine(name);
        */

        /*
        // FizBuzz
        for (int i = 1; i < 101; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
                Console.WriteLine($"{i} - FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} - Fizz");
            else if (i % 5 == 0)
                Console.WriteLine($"{i} - Buzz");
            else
                Console.WriteLine($"{i}");
        }
        */

        /*
        Random random = new Random();
        int current = 0;

        do
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);
        */

        /*
        Random random = new Random();
        int current = random.Next(1, 11);
        
        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");
        */

        /*
        Random random = new Random();
        int current = random.Next(1, 11);

        do
        {
            current = random.Next(1, 11);

            if (current >= 8) continue;

            Console.WriteLine(current);
        } while (current != 7);
        */

        /*
        int hero = 10;
        int monster = 10;

        Random dice = new Random();

        do
        {
            int roll = dice.Next(1, 11);
            monster -= roll;
            Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

            if (monster <= 0) continue;

            roll = dice.Next(1, 11);
            hero -= roll;
            Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

        } while (hero > 0 && monster > 0);

        Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
        */

        /*
        string? readResult;
        bool validEntry = false;
        Console.WriteLine("Enter a string containing at least three characters:");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                if (readResult.Length >= 3)
                {
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Your input is invalid, please try again.");
                }
            }
        } while (validEntry == false);
        */


        /*
        // CODE PROJECT 1
        int userInput;
        Console.WriteLine("Enter an integer value between 5 and 10:");

        do
        {
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out userInput))
            {
                if (userInput >= 5 && userInput <= 10)
                {
                    Console.WriteLine($"Your input value ({userInput}) has been accepted.");
                    break;
                }
                else
                {
                    Console.WriteLine("You entered " + userInput + ". Please enter a number between 5 and 10.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
            }

            Console.WriteLine("Enter an integer value between 5 and 10:");
        } while (true);
        */


        /*
        // CODE PROJECT 2
        string[] validRoles = { "administrator", "manager", "user" };
        string input;
        bool isValid = false;

        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

        do
        {
            input = Console.ReadLine().Trim().ToLower();

            foreach (string role in validRoles)
            {
                if (input == role)
                {
                    isValid = true;
                    break;
                }
            }

            if (!isValid)
            {
                Console.WriteLine($"The role name that you entered, \"{input}\", is not valid. Enter your role name (Administrator, Manager, or User)");
            }

        } while (!isValid);

        Console.WriteLine($"Your input value ({input}) has been accepted.");
        */


        // CODE PROJECT 3
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
    }
}
