using Lesgo.Data;

namespace Lesgo.Repository.Interfaces
{
    public interface IStudentRepository
    {
        public int Insert(Student student);

        public void EnrollToSubjects(int studentId, IList<int> subjectIds);
    }
}
