using Lesgo.Data;

namespace Lesgo.Services.Interfaces
{
    public interface IStudentService
    {
        public void EnrollStudent(Student student, IList<int> subjectIds);
    }
}
