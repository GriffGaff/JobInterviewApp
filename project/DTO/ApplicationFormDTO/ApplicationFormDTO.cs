namespace ApplicationForm.DTO
{
    public class ApplicationDTO
    {
        public class CoverImg
        {
            public string FileName { get; set; } //  name of uploaded file
            public byte[] FileData { get; set; } //  binary data 
            public string Description { get; set; } //cover img
        }
        public class PersonalInfoDTO
        {
            public string f.Name { get; set; }
            public string l.Name { get; set; }
            public string email { get; set; }

            public class Phone
            {
                public string InternalText { get; set; }
                public bool IsEnabled { get; set; } //select or not
                public string hidebtn { get; set; }
                public string label { get; set; } //hide
                public bool IsToggled { get; set; } // hide or not
                public string ActivateColor { get; set; } //color when activated
                public bool deactivateColor { get; set; } //color on deactivation
            }
            public class Nationality
            {
                public string InternalText { get; set; }
                public bool IsEnabled { get; set; } //select or not
                public string hidebtn { get; set; }
                public string label { get; set; } //hide
                public bool IsToggled { get; set; } // hide or not
                public string ActivateColor { get; set; } //color when activated
                public bool deactivateColor { get; set; } //color on deactivation
            }
            public class CurrentResidence
            {
                public string InternalText { get; set; }
                public bool IsEnabled { get; set; } //select or not
                public string hidebtn { get; set; }
                public string label { get; set; } //hide
                public bool IsToggled { get; set; } // hide or not
                public string ActivateColor { get; set; } //color when activated
                public bool deactivateColor { get; set; } //color on deactivation
            }
            public class idNum
            {
                public string InternalText { get; set; }
                public bool IsEnabled { get; set; } //select or not
                public string hidebtn { get; set; }
                public string label { get; set; } //hide butn
                public bool IsToggled { get; set; } // hide or not
                public string ActivateColor { get; set; } //color when activated
                public bool deactivateColor { get; set; } //color on deactivation
            }
            public class DoBirth
            {
                public string InternalText { get; set; }
                public bool IsEnabled { get; set; } //select or not
                public string Hidebtn { get; set; }
                public string label { get; set; } //hide
                public bool IsToggled { get; set; } // hide or not
                public string ActivateColor { get; set; } //color when activated
                public bool deactivateColor { get; set; } //color on deactivation
            }
            public class Gender
            {
                public string InternalText { get; set; }
                public bool IsEnabled { get; set; } //select or not
                public string hidebtn { get; set; }
                public string label { get; set; } //hide butn
                public bool IsToggled { get; set; } // hide or not
                public string ActivateColor { get; set; } //color when activated
                public bool deactivateColor { get; set; } //color on deactivation
            }
            public class AddQuestionDTO
            {
                public class type
                {
                    public string selectedType { get; set; }
                    public list<choose> ProvidedTypes { get; set; } //list of available question types
                    public type()
                    {
                        ProvidedTypes = new list<choose>
                    {
                        "paragraph"
                        "multiple choice"
                    }
                    }
                }
                /*public class options
                {
                    public string Id { get; set; } //option1
                    public string Text { get; set; } //displays first opt
                }
                public class question { get; set; }
                public class choice { get; set; }*/
            }
        }

        public class ProfileDTO
        {
            public class Education
            {
                public string Text { get; set; }
                public bool IsEnabled { get; set; } //select or not
                public string hidebtn { get; set; }
                public string label { get; set; } //hide
                public bool IsToggled { get; set; } // hide or not
                public string ActivateColor { get; set; } //color when activated
                public bool deactivateColor { get; set; } //color on deactivation
                public string ClickAction { get; set; } //action to Education form
            }
            public class EducationForm
            {
                public string School { get; set; }
                public class Degree
                {
                    public List<string> DegreeType { get; set; }
                    public Degree()
                    {
                        DegreeType = new List<string>
                    {//degree for showcase
                        "B.Sc"
                        "M.Sc"
                        "HND"
                        "Associates Degree"
                    };
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
                        "USA"
                        "Nigeria"
                        "UK"
                        "Canada"
                        "Kenya"
                        "Ghana"
                    }
                    }
                }
                public class StartEndDate
                {
                    private DateTime StartDate { get; set; }
                    private DateTime EndDate { get; set; }
                }
            }
            public class Experience
            {
                public string CompanyName { get; set; }
                public string PostionTitle { get; set; }
                public class WorkLocation
                {
                    public List<string> Location { get; set; }
                    public WorkLocation()
                    {
                        Location = new List<string>
                    {
                        "Remote"
                        "Hybrid"
                        "Physical"
                    }
                    }
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
                public string Description { get; set; } //resume

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
