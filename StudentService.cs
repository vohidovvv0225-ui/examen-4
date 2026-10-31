public class StudentService : IStudentService
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        foreach (Student s in students)
        {
            if (s.Id == student.Id)
            {
                throw new Exception("Id");
            }
        }

        students.Add(student);
    }

    public void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("goib");
            return;
        }

        foreach (Student s in students)
        {
            Console.WriteLine("ID: " + s.Id);
            Console.WriteLine("Name: " + s.FullName);
            Console.WriteLine("Age: " + s.Age);
            Console.WriteLine("Group: " + s.Group);
        }
    }

    public void UpdateStudent(int id, string name, int age, string group)
    {
        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                s.FullName = name;
                s.Age = age;
                s.Group = group;

                return;
            }
        }

        throw new Exception("nestay");
    }

    public void DeleteStudent(int id)
    {
        Student student = students.Find(s => s.Id == id);

        if (student == null)
        {
            throw new Exception("nestay");
        }

        students.Remove(student);
    }

    public Student SearchByName(string name)
    {
        return students.Find(s =>s.FullName.ToLower() == name.ToLower());
    }

    public List<Student> SearchByGroup(string group)
    {
        return students.FindAll(s =>s.Group.ToLower() == group.ToLower());
    }
}