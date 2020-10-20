using System;
using System.Text.RegularExpressions;

namespace RegExAteHwGoodson
{
    class Program
    {

        //use regexr.com or regex 101 to help
        static bool ValidateUserName(string userName)
        {
            //start with capital letters
            //max length of 30
            //can only have alphabets

            Regex pattern = new Regex(@"^[A-Z]{1}[a-z]{0,29}");

            return pattern.IsMatch(userName);
        }

        static bool ValidateEmails(string userEmail)
        {
            //alphanumeric characters, length between 5 and 30
            //no special characters then @ alphanumeric chars between 5 and 10
            //then no special characters . domain (combo of alphanumeric chars
            //length of two or three

            Regex pattern = new Regex(@"^\w{5,30}@\w{5,10}.\w{2,3}");

            return pattern.IsMatch(userEmail);
        }

        static bool ValidatePhoneNum(string userNum)
        {
            //3 digits - 3 digits - 4 digits

            Regex pattern = new Regex(@"^\d{3}-\d{3}-\d{4}");

            return pattern.IsMatch(userNum);
        }

        static bool ValidateDate(string someDate)
        {
            //use format of dd/mm/yyyy

            Regex pattern = new Regex(@"^\d{2}\/\d{2}\/\d{4}");

            return pattern.IsMatch(someDate);
        }

        static bool ValidateHTML(string htmlCode)
        {
            //make sure HTML code has correct open/close elements
            //ignore self contained items like </br>

            Regex pattern = new Regex(@"^<(\w+)>\s<\/\1>");

            return pattern.IsMatch(htmlCode);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a valid name:");

            string userName = Console.ReadLine();

            if (ValidateUserName(userName))
            {
                Console.WriteLine("\nName is valid!");
            } else
            {
                Console.WriteLine("\nSorry, name is not valid!");
            }

            Console.WriteLine("\nPlease enter a valid email:");

            string userEmail = Console.ReadLine();

            if (ValidateEmails(userEmail))
            {
                Console.WriteLine("\nEmail is valid!");
            }
            else
            {
                Console.WriteLine("\nSorry, email is not valid!");
            }

            Console.WriteLine("\nPlease enter a valid phone number in the following format: ###-###-#### ");

            string userNum = Console.ReadLine();


            if (ValidatePhoneNum(userNum))
            {
                Console.WriteLine("\nPhone number is valid!");
            }
            else
            {
                Console.WriteLine("\nSorry, phone number is not valid!");
            }

            Console.WriteLine("\nPlease enter a valid date in the following format: dd/mm/yyyy");

            string someDate = Console.ReadLine();

            if (ValidateDate(someDate))
            {
                Console.WriteLine("\nDate is valid!");
            }
            else
            {
                Console.WriteLine("\nSorry, Date is not valid!");
            }

            Console.WriteLine("\nPlease enter a valid HTML code");

            string htmlCode = Console.ReadLine();

            if (ValidateHTML(htmlCode))
            {
                Console.WriteLine("\nHTML code is valid!");
            }
            else
            {
                Console.WriteLine("\nSorry, the entered HTML code is not valid!");
            }

        }
    }
}
