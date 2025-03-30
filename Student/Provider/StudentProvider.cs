using Student.Model;

namespace Student.Provider
{
    public class StudentProvider : IStudentProvider
    {
        private List<StudentModel> students = new List<StudentModel>()
        {
            new StudentModel("Alice", 15, 10),
            new StudentModel("Bob", 16, 10),
            new StudentModel("Charlie", 15, 10),
            new StudentModel("David", 16, 10),
            new StudentModel("Emma", 15, 10),
            new StudentModel("Frank", 16, 10),
            new StudentModel("Grace", 15, 10),
            new StudentModel("Hannah", 16, 10),
            new StudentModel("Ian", 15, 10),
            new StudentModel("Jack", 16, 10),
            new StudentModel("Kate", 16, 11),
            new StudentModel("Leo", 17, 11),
            new StudentModel("Mia", 16, 11),
            new StudentModel("Noah", 17, 11),
            new StudentModel("Olivia", 16, 11),
            new StudentModel("Peter", 17, 11),
            new StudentModel("Quinn", 16, 11),
            new StudentModel("Rachel", 17, 11),
            new StudentModel("Sam", 16, 11),
            new StudentModel("Tom", 17, 11),
            new StudentModel("Uma", 17, 12),
            new StudentModel("Victor", 18, 12),
            new StudentModel("Wendy", 17, 12),
            new StudentModel("Xavier", 18, 12),
            new StudentModel("Yvonne", 17, 12),
            new StudentModel("Zach", 18, 12),
            new StudentModel("Abby", 17, 12),
            new StudentModel("Ben", 18, 12),
            new StudentModel("Cathy", 17, 12),
            new StudentModel("Daniel", 18, 12)
        };
        public List<StudentModel> GetStudents(int Grade)
        {
            var lst = students.Where(s => s.Grade == Grade).ToList();
            return lst;
        }
    }
}
