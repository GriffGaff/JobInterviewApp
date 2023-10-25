using ApplicationForm.Enums;

namespace ApplicationForm.DTO
{
    public class ApplicationDTO
    {
        public FileUpload.DTO.CoverImg CoverImg { get; set; }
	public string firstName { get; set; }
	public string lastName { get; set; }
	public string email { get; set; }
	public int phoneNumber { get; set; }
	public string Nationality { get; set; }
	public string Residence { get; set; }
	public string IdentityNumber { get; set; }
	public DateTime DateofBirth { get; set; }
        //add personal info questions

	public Education.DTO Education { get; set; }
	public Experience.DTO Experience { get; set; }
	public FileUpload.DTO.Resume Resume { get; set; }

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
