namespace Student.Model
{
    public class StudentModel
    {
        public Guid RowPointer { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public StudentModel(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
}
