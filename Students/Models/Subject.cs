namespace Students.Models;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int StudentId { get; set; }
    public byte Grade { get; set; }
    public DateOnly Date { get; set; }

    public static List<Subject> Fill()
    {
        return 
        [
            new Subject{Id = 1,  Name = "Economics",   StudentId = 1, Grade = 93, Date = new DateOnly(2024, 10,5)},
            new Subject{Id = 2,  Name = "Biology",     StudentId = 1, Grade = 90, Date = new DateOnly(2024, 10,8)},
            new Subject{Id = 3,  Name = "Mathematics", StudentId = 1, Grade = 95, Date = new DateOnly(2024, 10, 10)},
            new Subject{Id = 4,  Name = "Chemistry",   StudentId = 1, Grade = 99, Date = new DateOnly(2024, 10, 15)},
            new Subject{Id = 5,  Name = "Physics",     StudentId = 1, Grade = 98, Date = new DateOnly(2024, 10, 20)},
            
            new Subject{Id = 6,  Name = "Economics",   StudentId = 2, Grade = 50, Date = new DateOnly(2024, 10,5)},
            new Subject{Id = 7,  Name = "Biology",     StudentId = 2, Grade = 80, Date = new DateOnly(2024, 10,8)},
            new Subject{Id = 8,  Name = "Mathematics", StudentId = 2, Grade = 60, Date = new DateOnly(2024, 10, 10)},
            new Subject{Id = 9,  Name = "Chemistry",   StudentId = 2, Grade = 40, Date = new DateOnly(2024, 10, 15)},
            new Subject{Id = 10, Name = "Physics",     StudentId = 2, Grade = 65, Date = new DateOnly(2024, 10, 20)},
        
            new Subject{Id = 11, Name = "Economics",   StudentId = 3, Grade = 65, Date = new DateOnly(2024, 10,5)},
            new Subject{Id = 12, Name = "Biology",     StudentId = 3, Grade = 87, Date = new DateOnly(2024, 10,8)},
            new Subject{Id = 13, Name = "Mathematics", StudentId = 3, Grade = 69, Date = new DateOnly(2024, 10, 10)},
            new Subject{Id = 14, Name = "Chemistry",   StudentId = 3, Grade = 77, Date = new DateOnly(2024, 10, 15)},
            new Subject{Id = 15, Name = "Physics",     StudentId = 3, Grade = 65, Date = new DateOnly(2024, 10, 20)},
        ];
    }

    public List<Subject> GetByStudentId(List<Subject> subjects, int studentId) => subjects.Where(x=> x.StudentId == studentId).ToList();
}