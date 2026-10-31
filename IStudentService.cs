public  interface IStudentService
{
    void AddStudent(Student student);
    void DisplayStudents();
    void UpdateStudent(int id, string name, int age, string group);
    void DeleteStudent(int id);
    Student SearchByName(string name);
    List<Student> SearchByGroup(string group);
}