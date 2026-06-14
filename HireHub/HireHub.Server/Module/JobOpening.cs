using HireHub.Server.Enums;

namespace HireHub.Server.Module
{
    public class JobOpening
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location {  get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public EmploymentType Employment {  get; set; }
        public int ExperienceLevel { get; set; }
        public List<string> Skills { get; set; }
        public DateOnly ApplicationDeadline { get; set; }

    }
}
