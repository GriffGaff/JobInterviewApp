using System;
using ProgramDetails.DTO;

namespace project.tests
{
    public class ProgramDetailsTest
    {
        [Fact]
        //output of this test should include all the set instances
        public void Test1()
        {
            //set instances
            var programInput = new ProgramDTO();
            var Title = "Internship";
            var Summary = "Budding software developer";
            var Description = "You'll learn to develop your skills";
            var Skills = "C# .NET programming language";
            var Benefits = "Hands-on real life solutions";
            var AppliCriteria = "Understanding of .NET";

            var output = $"Title: {Title}\nSummary: {Summary}\nDescription: {Description}\n Skills: {Skills}\nBenefits: {Benefits}\nApplicatio criteria: {AppliCriteria}";
        }
    }
}
