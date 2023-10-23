using ProgramDetails.Enums;

namespace ProgramDetails.DTO
{
    public class ProgramDTO
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public Skills Skills { get; set; }
        public string Benefits { get; set; }
        public string AppliCriteria { get; set; }

        public ProgType ProgType { get; set; }

        public DateTime ProgStart { get; set; }
        public DateTime ApplicationOpenDate { get; set; }
        public DateTime ApplicationCloseDate { get; set; }
        public int Duration { get; set; }
        public ProgLocation Location { get; set; }

        public MinQualification Qualification { get; set; }
        public int MaxNoApplication { get; set; }
    }
}
