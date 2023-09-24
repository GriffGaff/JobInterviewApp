namespace ProgramDetails.DTO
{
    public class ProgramDTO
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string Benefits { get; set; }
        public string AppliCriteria { get; set; }

        //additional Program Information
        public class ProgType
        {
            public string selectedProgType { get; set; }
            public List<string> progOptions { get; set; }//available options
            public ProgType()
            {
                progOptions = new List<string>
                {//few options for showcase
                    "Internship"
                    "Job"
                    "Training"
                    "Mentoring"
                    "Course"
                    "Live Seminar"
                    "Volunteering"
                    "Other"
                };
            }
        }
        public string ProgStart { get; set; }
        public string AppliOpen { get; set; }
        public string AppliClose { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }
        public class Qualification
        {
            public string minQualification { get; set; }
            public List<string> Options { get; set; }//available options
            public minQualification()
            {
                Options = new List<string>
                {//few options for showcase
                    "High School"
                    "College"
                    "Graduate"
                    "University"
                    "Masters"
                    "PhD"
                };
            }
        }

        public string MaxNoAppli { get; set; }
        public string SaveCont { get; set; }
    }
}