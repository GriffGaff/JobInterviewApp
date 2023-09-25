namespace ApplicationForm.DTO
{
    public class ApplicationDTO
    {
        public class CoverImgModel
        {
            public string FileName { get; set; } //  name of uploaded file
            public byte[] FileData { get; set; } //  binary data 
        }
        public class PersonalInfoDTO
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }

            public class PhoneModel
            {
                public string hidebtn { get; set; }
                public bool IsToggled { get; set; } // hide or not
                public string ActivateColor { get; set; } //color when activated
                public int phoneNumber { get; set; }//object to store mobile number
            }
            public class NationalityModel
            {
                private string hidebtn { get; set; }
                private bool IsToggled { get; set; } // hide or not
                private string ActivateColor { get; set; } //color when activated
                public string EnterNationality { get; set; }
            }
            public class CurrentResidenceModel
            {
                private string hidebtn { get; set; }
                private bool IsToggled { get; set; } // hide or not
                private string ActivateColor { get; set; } //color when activated
                public string EnterResidence { get; set; }

            }
            public class IDNumModel
            {
                private string hidebtn { get; set; }
                private bool IsToggled { get; set; } // hide or not
                private string ActivateColor { get; set; } //color when activated
                public string EnterIdentityNumber { get; set; }
            }
            public class DateOfBirthModel
            {
                private bool IsToggled { get; set; } // hide or not
                private string ActivateColor { get; set; } //color when activated
                public DateTime DoB { get; set; }
            }
            public class GenderModel
            {
                private bool IsToggled { get; set; } // hide or not
                private string ActivateColor { get; set; } //color when activated
                public List<string> Gender { get; set; }
                public string SelectedGender { get; set; }
                public GenderModel()
                {
                    Gender = new List<string>
                    {
                        "Male",
                        "Female",
                        "Binary",
                        "Transgender",
                        "Others",
                        "Prefer not to say",
                    };
                    SelectedGender = string.Empty;
                }
            }
            public class AddQuestionDTO
            {
                public class Type
                {
                    public string selectedType { get; set; }
                    public list<choose> ProvidedTypes { get; set; } //list of available question types
                    public Type()
                    {
                        ProvidedTypes = new list<choose>
                        {
                            "paragraph"
                            "multiple choice"
                        }
                    }
                }
            }
        }

        public class ProfileDTO
        {
            public class EducationModel
            {
                private bool IsToggled { get; set; } // hide or not
                private string ActivateColor { get; set; } //color when activated
                public string mandatorybtn { get; set; } //action to Education form
            }
            public class EducationFormModel
            {
                public string School { get; set; }
                public class Degree
                {
                    public List<string> DegreeType { get; set; }
                    public string SelectedDegree { get; set; }
                    public Degree()
                    {
                        DegreeType = new List<string>
                        {//degree for showcase
                            "B.Sc",
                            "M.Sc",
                            "HND",
                            "Associates Degree",
                        };
                        SelectedDegree = string.Empty;
                    }
                }
                public string Course { get; set; }
                public class StudyLocation
                {
                    public List<string> Country { get; set; }
                    public StudyLocation()
                    {
                        Country = new List<string>
                        {//few options for showcase
                            "USA",
                            "Nigeria",
                            "UK",
                            "Canada",
                            "Kenya",
                            "Ghana",
                        }
                    }
                }
                public class StartEndDate
                {
                    private DateTime StartDate { get; set; }
                    private DateTime EndDate { get; set; }
                }
            }
            public class ExperienceModel
            {
                public string CompanyName { get; set; }
                public string PostionTitle { get; set; }
                
                //Work Location model
                public class WorkLocation
                {
                    public int LocationId { get; set; }
                    public string Name { get; set;}
                }
                public class SelectedLocation
                {
                    public List<WorkLocation> Locations = new List<WorkLocation>
                    {
                        new WorkLocation {LocationId = 1, Name = "Remote"},
                        new WorkLocation {LocationId = 2, Name = "Physical"},
                        new WorkLocation {LocationId = 3, Name = "Hybrid"},
                    };
                    public List<WorkLocation> GetCountry()
                    {return country};
                }
                private class StartEndDate
                {
                    private DateTime StartDate { get; set; }
                    private DateTime EndDate { get; set; }
                }

            }
            public class resume //action was't set
            {
                public string FileName { get; set; } //  name of resume file
                public byte[] FileData { get; set; } //  binary data 

            }
        }
        public class AdditionalQue
        {
            public string ApplicantAnswer { get; set; }//tell me about yourself
            public class graduationYear
            {
                public int selectYear { get; set; }//selected year
                public List<int> YearOptions { get; set; }
                public graduationYear()
                {
                    YearOptions = new List<int>();
                    for (int year = 1990; year <= 2023; year++)
                    {
                        YearOptions.Add(year);
                    }
                }

            }
        }
    }
}
