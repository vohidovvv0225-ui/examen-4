// MyQueue<int> rakam = new MyQueue<int>();
//     rakam.Enqueue(111);
//     rakam.Enqueue(222);
//     rakam.Enqueue(333);
//     System.Console.WriteLine(rakam.Peek());
//     System.Console.WriteLine(rakam.Dequeue());
//     System.Console.WriteLine(rakam.Count);
// MyQueue<string> nom = new MyQueue<string>();
// nom.Enqueue("sulaymon");
// nom.Enqueue("yusuf");
// nom.Enqueue("suli");
// System.Console.WriteLine(nom.Peek());
// System.Console.WriteLine(nom.Dequeue());



// try
// {
//     rakam.Clear();
//     rakam.Dequeue();

// }
// catch(Exception ex)
// {
//     System.Console.WriteLine($"Owibka:  {ex.Message}");
// }



// taski 6

 IStudentService service = new StudentService();
  bool r = true;
 while (r)
        {
Console.WriteLine("1. dobavit studenta");
Console.WriteLine("2. Display Students");
Console.WriteLine("3. Update Student");
Console.WriteLine("4. udalit studenta");
Console.WriteLine("5. poisk imya");
Console.WriteLine("6. poisk");
Console.WriteLine("7. Exit");
            string choice = Console.ReadLine();
         try
         {
             switch (choice)
             {
                 case "1":
                     Console.Write("ID: ");
                     int id = int.Parse(Console.ReadLine());
                        Console.Write("Full Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Group: ");
                        string group = Console.ReadLine();

                        Student student = new Student(id, name, age, group);

                        service.AddStudent(student);
                        break;

                    case "2":
                        service.DisplayStudents();
                        break;

                    case "3":
                        Console.Write("Student ID: ");
                        int updateId = int.Parse(Console.ReadLine());

                        Console.Write("nomi mav: ");
                        string newName = Console.ReadLine();

                        Console.Write("soli nav: ");
                        int newAge = int.Parse(Console.ReadLine());

                        Console.Write("grupai nav: ");
                        string newGroup = Console.ReadLine();

                        service.UpdateStudent(
                            updateId, newName, newAge, newGroup);

                        break;

                    case "4":
                        Console.Write("Student ID: ");
                        int deleteId = int.Parse(Console.ReadLine());

                        service.DeleteStudent(deleteId);
                        break;

                    case "5":
                        Console.Write("Student Name: ");
                        string searchName = Console.ReadLine();

                        Student found = service.SearchByName(searchName);

                        if (found == null)
                        {
                            Console.WriteLine("student");
                        }
                        else
                        {
                            Console.WriteLine("ID: " + found.Id);
                            Console.WriteLine("Name: " + found.FullName);
                            Console.WriteLine("Age: " + found.Age);
                            Console.WriteLine("Group: " + found.Group);
                        }
                        break;

                    case "6":
                        Console.Write("Group: ");
                        string searchGroup = Console.ReadLine();

                        List<Student> result =
                            service.SearchByGroup(searchGroup);

                        if (result.Count == 0)
                        {
                            Console.WriteLine("student");
                        }
                        else
                        {
                            foreach (Student s in result)
                            {
                                Console.WriteLine(
                                    s.Id + 
                                    s.FullName + 
                                    s.Age +  
                                    s.Group);
                            }
                        }
                        break;

                    case "7":
                        r = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("lllll");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("owibka " + ex.Message);
            }
        }
   
