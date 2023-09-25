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
        //program type model
        public class ProgType
        {
            public int typeID { get; set; }
            public string Name { get; set; }
        }
        public class SelectedProgType
        {
            public List<ProgType> ProgOptions = new List<ProgType>
            {
                new ProgType {typeID = 1, Name = "Internship"},
                new ProgType {typeID = 2, Name = "Job"},
                new ProgType {typeID = 3, Name = "Training"},
                new ProgType {typeID = 4, Name = "Mentoring"},
                new ProgType {typeID = 5, Name = "Course"},
                new ProgType {typeID = 6, Name = "Live Webinar"},
                new ProgType {typeID = 7, Name = "Volunteering"},
                new ProgType {typeID = 8, Name = "Other"},
            };
            public List<ProgType> GetProgType()
            {return type;}
        }

        public class ProgStart
        {
            private DateTime StartDate { get; set; }
        }
        public class AppliOpen
        {
            private DateTime ApplicationOpenDate { get; set; }
        }
        public class AppliClose
        {
            private DateTime ApplicationCloseDate { get; set; }
        }
        public string Duration { get; set; }
        public string Location { get; set; }

        public class Qualification
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public class QualificationOptions
        {
            public List<Qualification> QualificationTypes = new List<Qualification>
            {
                new Qualification {ID = 1, Name = "High School"},
                new Qualification {ID = 2, Name = "College"},
                new Qualification {ID = 3, Name = "Graduate"},
                new Qualification {ID = 4, Name = "University"},
                new Qualification {ID = 5, Name = "Masters"},
                new Qualification {ID = 6, Name = "PhD"},
            };
            public List<Qualification> GetQualify()
            {return Qualify;}
        }
        public int MaxNoApplication { get; set; }
        public string SaveCont { get; set; }
    }
}