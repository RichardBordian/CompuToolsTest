namespace Students.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SecondName{ get; set; }
    public int Age { get; set; }
    public List<Subject> Subjects { get; set; }
    public int AverageGrade { get; set; }

    public Grant Grant { get; set; } 
    
    
    

    public static List<Student> Fill() =>
    [
        new Student{Id = 1, FirstName = "Petro", SecondName = "Stamenko", Age = 20},
        new Student{Id = 2, FirstName = "Kristina", SecondName = "Evdokia", Age = 19},
        new Student{Id = 3, FirstName = "Anatoliy", SecondName = "Jovanovich", Age = 22}
    ];

    public void SetSubjects(List<Subject> subjects)
    {
        this.Subjects = subjects;
    }

    public void CalculateAverageGrade() => AverageGrade = (int)Subjects.Average(x => x.Grade);

    public void SetGrant()
    {
        if (AverageGrade < 60)
        {
            Grant = Grant.None;
        }

        if (AverageGrade >= 60 & AverageGrade < 90)
        {
            Grant = Grant.Regular;
        }

        if (AverageGrade > 90)
        {
            Grant = Grant.Increased;
        }
    }
}
