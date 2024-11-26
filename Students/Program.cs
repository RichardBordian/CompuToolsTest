using Students.Models;
namespace Students;

class Program
{
    static void Main(string[] args)
    {
        var students = Student.Fill();
        var subjects = Subject.Fill();

        foreach (var s in students)
        {
            s.SetSubjects(subjects.Where(x=> x.StudentId == s.Id).ToList());
            s.CalculateAverageGrade();
            s.SetGrant();
        }

        var student = students.First();
        
        Console.WriteLine($"Id: {student.Id}, Name: {student.FirstName}, second name: {student.SecondName}, Age: {student.Age}, Average: {student.AverageGrade}, Grant: {student.Grant}, subjects:");
        foreach(var s in student.Subjects)
        {
            Console.WriteLine($"Name: {s.Name}, Grade: {s.Grade}, Date: {s.Date}");
        }
    }
}