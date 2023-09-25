using System;
using System.Collections.Generic;
using System.Linq;
using ProgramDetails.DTO;
//using ApplicationForm.DTO;

namespace ProgramDetails.DTO
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing ProgramDTO
            var programInput = new ProgramDTO();

            Console.WriteLine("Enter program title: ");
            programInput.Title = Console.ReadLine();

            Console.WriteLine("Summary of the Program: ");
            programInput.Summary = Console.ReadLine();

            Console.WriteLine("Program Description: ");
            programInput.Description = Console.ReadLine();

            Console.WriteLine("Key skills: ");
            programInput.Skills = Console.ReadLine();

            Console.WriteLine("Program Benefits: ");
            programInput.Benefits = Console.ReadLine();

            Console.WriteLine("Application Criteria: ");
            programInput.AppliCriteria = Console.ReadLine();

            //test
            Console.WriteLine($"Welcome to Capital Placement.\nYour program title is {programInput.Title}");
            Console.WriteLine($"Prog summary {programInput.Summary}");
            Console.WriteLine($"Prog description {programInput.Description}");
            Console.WriteLine($"Prog skills are {programInput.Skills}");
            Console.WriteLine($"Prog Benefits {programInput.Benefits}");
            Console.WriteLine($"Prog Criteria {programInput.AppliCriteria}");

            //program start
            Console.Write("Program commences: (yyyy/mm/dd)");
            if(DateTime.TryParse(Console.ReadLine(), out DateTime startProg))
            {
                programInput.StartDate = startProg;
                Console.WriteLine($"Start date: {programInput.StartDate}");
            }
            else{Console.Write("Input valid date");}

            //application open
            Console.Write("Application Open: (yyyy/mm/dd)");
            if(DateTime.TryParse(Console.ReadLine(), out DateTime openDate))
            {
                programInput.ApplicationOpenDate = openDate;
                Console.WriteLine($"Open date: {programInput.ApplicationOpenDate}");
            }
            else{Console.Write("Input valid date");}

            //application close
            Console.Write("Application closes: (yyyy/mm/dd)");
            if(DateTime.TryParse(Console.ReadLine(), out DateTime closeDate))
            {
                programInput.ApplicationCloseDate = closeDate;
                Console.WriteLine($"Close date: {programInput.ApplicationCloseDate}");
            }
            else{Console.Write("Input valid date");}

            Console.WriteLine("Application Duration: ");
            programInput.Duration = Console.WriteLine("6 Months");
            Console.WriteLine("Application Location: ");
            programInput.Location = Console.Write(London, UK);


            //number of application
            programInput.MaxNoApplication = Console.WriteLine("20,000");

        }
    }
}

namespace ApplicationForm.DTO
{
    class App
    {
        static void Main(string[] args)
        {
            //initialize ApplicationForm.DTO
            var inputApplication = new ApplicationForm.DTO();

            //cov img upload
            string fileName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(fileName)) //this method  checks if filename is provided
            {
                inputApplication.FileName = fileName;
                Console.WriteLine($"Image '{inputApplication.FileName}' provided");
            }
            else{Console.WriteLine("Upload image")};

            //personal informartion
            inputApplication.firstName = Console.ReadLine();
            inputApplication.lastName = Console.ReadLine();
            inputApplication.email = Console.ReadLine();

        }
    }
}