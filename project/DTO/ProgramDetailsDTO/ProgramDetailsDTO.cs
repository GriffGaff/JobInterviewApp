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
            public List<string> ProgOptions { get; set; }//available options
            public string SelectedProgType { get; set; } //selected option

            public ProgType()
            {
                ProgOptions = new List<string>
                {//few options for showcase
                    "Internship",
                    "Job",
                    "Training",
                    "Mentoring",
                    "Course",
                    "Live Seminar",
                    "Volunteering",
                    "Other"
                };
                SelectedProgType = string.Empty;
            }
        }
        public string ProgStart { get; set; }
        public string AppliOpen { get; set; }
        public string AppliClose { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }
        public class Qualification
        {
            public string SelectedQualification { get; set; }
            public List<string> QualifyOptions { get; set; }//available options
            public Qualification()
            {
                QualifyOptions = new List<string>
                {//few options for showcase
                    "High School",
                    "College",
                    "Graduate",
                    "University",
                    "Masters",
                    "PhD"
                };
                SelectedQualification = string.Empty;
            }
        }

        public string MaxNoAppli { get; set; }
        public string SaveCont { get; set; }
    }
}