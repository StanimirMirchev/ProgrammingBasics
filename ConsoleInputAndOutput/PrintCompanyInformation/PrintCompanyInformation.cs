using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{

    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string telephoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();


            Console.WriteLine("Company name: {0}", companyName);
            Console.WriteLine("Company Address: {0}", companyAddress);
            Console.WriteLine("Telephone number: {0}", telephoneNumber);
            Console.WriteLine("Fax number: {0}", faxNumber);
            Console.WriteLine("Website: {0}", webSite);
            Console.WriteLine("Manager first name: {0}", managerFirstName);
            Console.WriteLine("Manager last name: {0}", managerLastName);
            Console.WriteLine("Manager age: {0}", managerAge);
            Console.WriteLine("Manager's phone: {0}", managerPhone);
        }
    }
}
