using Student.Model;

namespace Student.Provider
{
    public interface IStudentProvider
    {
        List<StudentModel> GetStudents(int Grade);
    }
}
