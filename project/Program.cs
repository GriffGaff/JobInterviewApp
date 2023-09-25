using System;
using System.Collections.Generic;
//using Preview.DTO;
using ProgramDetails.DTO;

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
        
            //program type
            Console.WriteLine("Available Programs: ");
            foreach (string program in programInput.ProgOptions)
            {
                Console.WriteLine(program);
            }
            string inputProgram = Console.ReadLine(); //select a program
            if (programInput.ProgOptions.Contains(inputProgram))
            {
                programInput.SelectedProgType = inputProgram;
                Console.WriteLine($"Program: {programInput.ProgOptions}"); //storing value
            }
            else{Console.WriteLine("Select a program.")};

            Console.WriteLine("Select the start of your program: ");
            programInput.ProgStart = Console.ReadLine();
            Console.WriteLine("Application opens: ");
            programInput.AppliOpen = Console.ReadLine();
            Console.WriteLine("Application closes: ");
            programInput.AppliClose = Console.ReadLine();
            Console.WriteLine("Application Duration: ");
            programInput.Duration = Console.ReadLine();
            Console.WriteLine("Application Location: ");
            programInput.Location = Console.ReadLine();

            //selecting qualification
            Console.WriteLine("Available Programs: ");
            foreach (string qualify in programInput.QualifyOptions)
            {
                Console.WriteLine(qualify);
            }
            string inputQualify = Console.ReadLine(); //select a qualification
            if (programInput.QualifyOptions.Contains(inputQualify))
            {
                programInput.SelectedQualification = inputQualify;
                Console.WriteLine($"Qualification: {programInput.QualifyOptions}"); //storing qualification value
            }
            else{Console.WriteLine("Select qualification.")};
        }
    }
}
