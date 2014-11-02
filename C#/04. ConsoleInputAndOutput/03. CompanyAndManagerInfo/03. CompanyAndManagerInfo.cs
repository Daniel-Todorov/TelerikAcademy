//A company has name, adress, phone number, fax number, web site and manager. The manager has first name, last name, age and phone number. 
//Write a program that reads the information about a company and its manager and prints them ont he console.

using System;

class CompanyAndManagerInfo
{
    static void Main()
    {
        string companyName;
        string companyAdress;
        ulong companyPhoneNumber;
        ulong companyFaxNumber;
        string companyWebSite;
        string companyManager;

        string managerFirstName;
        string managerLastName;
        ulong managerPhoneNumber;

        Console.WriteLine("Please, type the name of the company and press Enter:");
        companyName = Console.ReadLine();
        Console.WriteLine("Please, type the adress of the company and press Enter:");
        companyAdress = Console.ReadLine();
        Console.WriteLine("Please, type the phone number of the company and press Enter:");
        companyPhoneNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Please, type fax number of the company and press Enter:");
        companyFaxNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Please, type the web site of the company and press Enter:");
        companyWebSite = Console.ReadLine();
        Console.WriteLine("Please, type the name of manager of the company and press Enter:");
        companyManager = Console.ReadLine();

        Console.WriteLine("Please, type the first name of the manager and press Enter:");
        managerFirstName = Console.ReadLine();
        Console.WriteLine("Please, type the last name of the manager and press Enter:");
        managerLastName = Console.ReadLine();
        Console.WriteLine("Please, type the personal phone number of the manager and press Enter:");
        managerPhoneNumber = ulong.Parse(Console.ReadLine());

        Console.WriteLine("The company named {0} and is located at {1}", companyName, companyAdress);
        Console.WriteLine("You can contacts with the company's officials by phone: {0}, fax: {1} or call the manager - {2}", companyPhoneNumber, companyFaxNumber, companyManager);
        Console.WriteLine("You can also contacts with the manager of the company. His name is {0} {1} and his personal phone number is {2}", managerFirstName, managerLastName, managerPhoneNumber);
    }
}
