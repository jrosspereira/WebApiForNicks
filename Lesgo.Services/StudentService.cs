using Lesgo.Data;
using Lesgo.Repository.Interfaces;
using Lesgo.Services.Interfaces;

namespace Lesgo.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void EnrollStudent(Student student, IList<int> subjectIds)
        {
            var studentId = _studentRepository.Insert(student);
            _studentRepository.EnrollToSubjects(studentId, subjectIds);
        }
    }
}