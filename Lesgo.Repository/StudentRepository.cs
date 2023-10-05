using System.Data;
using Dapper;
using Lesgo.Data;
using Lesgo.Repository.Interfaces;
using Microsoft.Data.SqlClient;

namespace Lesgo.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public int Insert(Student student)
        {
            using IDbConnection connection =
                new SqlConnection("Server=localhost,11433;User=sa;Password=Pass123!;Database=basics;");

            var newStudentId = connection.QuerySingle<int>(@"
                INSERT INTO [Student] (FirstName, LastName) VALUES (@FirstName, @LastName);
                SELECT CAST(SCOPE_IDENTITY() as int)", new
            {
                student.FirstName, 
                student.LastName
            });

            return newStudentId;
        }

        public void EnrollToSubjects(int studentId, IList<int> subjectIds)
        {
            using IDbConnection connection =
                new SqlConnection("Server=localhost,11433;User=sa;Password=Pass123!;Database=basics;");
            foreach (var subjectId in subjectIds)
            {
                connection.Execute("INSERT INTO [StudentSubject](StudentId, SubjectId) values (@studentId, @subjectId)", 
                    new { studentId, subjectId });
            }
        }
    }
}