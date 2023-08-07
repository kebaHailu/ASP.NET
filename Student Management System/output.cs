using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class StudentManager<T> where T : Student
{
    private List<T> students;

    public StudentManager()
    {
        students = new List<T>();
    }

    public void AddStudent(T student)
    {
        students.Add(student);
    }

    public T SearchStudentByName(string name)
    {
        return students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public T SearchStudentByID(int id)
    {
        return students.FirstOrDefault(s => s.ID == id);
    }

    public void DisplayAllStudents()
    {   Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("=========---- Student List ----=========");
        foreach (var student in students)
        {
            
            
            Console.WriteLine($"|| {student.ID}. {student.Name} Age:{student.Age} ");
            
        }
        Console.WriteLine("=========================================");
    }

    public void SerializeStudentsToJson(string filePath)
    {
        string json = JsonSerializer.Serialize(students);
        File.WriteAllText(filePath, json);
        Console.WriteLine("Student data has been serialized to JSON successfully.");
    }

    public static List<T> DeserializeStudentsFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        List<T> students = JsonSerializer.Deserialize<List<T>>(json);
        return students;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "students.json";
        StudentManager<Student> studentManager = new StudentManager<Student>();

        while (true)
        {   Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========----- Welcome Again -----========");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student by Name");
            Console.WriteLine("3. Search Student by ID");
            Console.WriteLine("4. Display All Students");
            Console.WriteLine("5. Serialize Student Data to JSON");
            Console.WriteLine("6. Deserialize Student Data from JSON");
            Console.WriteLine("7. Exit");
            Console.WriteLine("=====---Student Management System ---=====");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Student ID: ");
                    try {int id = Convert.ToInt32(Console.ReadLine()); 
                     
                    Student searchedStudentByID = studentManager.SearchStudentByID(id);
                    if (searchedStudentByID != null)
                    {
                        Console.WriteLine($"This ID is already exist by {searchedStudentByID.Name}. please try Again");
                        break;
                    }
                    
                    
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Student Age: ");
                    
                    int age = Convert.ToInt32(Console.ReadLine()); 
                    if (age < 0 || age > 100) { Console.WriteLine("please Enter valid Age !"); break;}
                    
                    Student student = new Student { ID = id, Name = name, Age = age };
                    studentManager.AddStudent(student);
                    Console.WriteLine("Student added successfully."); }
                    catch (FormatException ex){Console.WriteLine("Invalid Input Type"+ex);}
                    break;
                case "2":
                    Console.Write("Enter Student Name: ");
                    string searchName = Console.ReadLine();
                    Student searchedStudentByName = studentManager.SearchStudentByName(searchName);
                    if (searchedStudentByName != null)
                    {
                        Console.WriteLine("==========---- Student Found ----===========");
                        Console.WriteLine($"|| {searchedStudentByName.ID}. {searchedStudentByName.Name} Age:{searchedStudentByName.Age} ||");
                        Console.WriteLine("==========-----------------------===========");                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;
                case "3":
                    Console.Write("Enter Student ID: ");
                    try{
                    int searchID = Convert.ToInt32(Console.ReadLine());
                    Student searchedStudentByID = studentManager.SearchStudentByID(searchID);
                    if (searchedStudentByID != null)
                    {   Console.WriteLine("==========---- Student Found ----===========");
                        Console.WriteLine($"|| {searchedStudentByID.ID}. {searchedStudentByID.Name} Age:{searchedStudentByID.Age} ||");
                        Console.WriteLine("==========-----------------------===========");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    }
                    catch (FormatException ex){Console.WriteLine("Invalid Input Type"+ex);}
                   
                    break;
                case "4":
                    studentManager.DisplayAllStudents();
                    break;
                case "5":
                    studentManager.SerializeStudentsToJson(filePath);
                    break;
                case "6":
                    List<Student> deserializedStudents = StudentManager<Student>.DeserializeStudentsFromJson(filePath);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("===============----- Student List  -----===============");
                    foreach (Student deserializedStudent in deserializedStudents)

                    {   
                        Console.WriteLine($"|| {deserializedStudent.ID}. {deserializedStudent.Name}  Age:{deserializedStudent.Age} ");
                        // Add student to the list if the student is not in the list
                        Student searchStudent = studentManager.SearchStudentByName(deserializedStudent.Name);
                    if (searchStudent == null)
                    {
                        studentManager.AddStudent(deserializedStudent);                 }
                   
                        
                    }
                    Console.WriteLine("==========================================================");
                    Console.WriteLine();
                    break;
                case "7":
                    Console.WriteLine("Exiting the program....");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}