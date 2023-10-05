namespace WebApi.Models
{
    public class EnrollStudent
    {
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public IList<int> SubjectIds { get; set; }
    }
}
