using System;
using System.Text.RegularExpressions;

namespace RegExAteHwGoodson
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {

                GetName();
                GetEmail();
                GetNum();
                GetDate();
                GetHtml();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

 



        }

        //use regexr.com or regex 101 to help
        static bool ValidateUserName(string userName)
        {

            Regex pattern = new Regex(@"^[A-Z]{1}[a-z]{0,29}$");

            return pattern.IsMatch(userName);
        }

        static bool ValidateEmails(string userEmail)
        {

            Regex pattern = new Regex(@"^\w{5,30}@\w{5,10}.\w{2,3}$");

            return pattern.IsMatch(userEmail);
        }

        static bool ValidatePhoneNum(string userNum)
        {

            Regex pattern = new Regex(@"^\d{3}-\d{3}-\d{4}$");

            return pattern.IsMatch(userNum);
        }

        static bool ValidateDate(string someDate)
        {

            Regex pattern = new Regex(@"^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/\d{4}$");

            return pattern.IsMatch(someDate);
        }

        static bool ValidateHTML(string htmlCode)
        {
          
            Regex pattern = new Regex(@"^<(\w+)>\s<\/\1>$");

            return pattern.IsMatch(htmlCode);
        }

        static void GetName()
        {
            do
            {
                Console.WriteLine("Please enter a valid name:");

                string userName = Console.ReadLine();

                if (ValidateUserName(userName))
                {
                    Console.WriteLine("\nName is valid!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nSorry, name is not valid!");
                }
            } while (true);

        }

        static void GetEmail()
        {
            do
            {
                Console.WriteLine("\nPlease enter a valid email:");

                string userEmail = Console.ReadLine();

                if (ValidateEmails(userEmail))
                {
                    Console.WriteLine("\nEmail is valid!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nSorry, email is not valid!"); 
                }
            } while (true);
        }

        static void GetNum()
        {

            do
            {
                Console.WriteLine("\nPlease enter a valid phone number in the following format: ###-###-#### ");

                string userNum = Console.ReadLine();


                if (ValidatePhoneNum(userNum))
                {
                    Console.WriteLine("\nPhone number is valid!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nSorry, phone number is not valid!");
                }
            } while (true);
        }

        static void GetDate()
        {
            do
            {
                Console.WriteLine("\nPlease enter a valid date in the following format: dd/mm/yyyy");

                string someDate = Console.ReadLine();

                if (ValidateDate(someDate))
                {
                    Console.WriteLine("\nDate is valid!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nSorry, Date is not valid!");
                }
            } while (true);
        }

        static void GetHtml()
        {
            do
            {
                Console.WriteLine("\nPlease enter a valid HTML code");

                string htmlCode = Console.ReadLine();

                if (ValidateHTML(htmlCode))
                {
                    Console.WriteLine("\nHTML code is valid!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nSorry, the entered HTML code is not valid!");
                }
            } while (true);
        }

   
    }
}
