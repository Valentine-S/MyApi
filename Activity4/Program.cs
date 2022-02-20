
public interface StudentInterface
{
    string? FirstName { get; set; }
    string? LastName { get; set; }
    int year { get; set; }
    double getGPA();
    void setGPA(double temp);
}


class Student : StudentInterface
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    private double GPA;
    public int year { get; set; }
    private string[] classList = new string[50];

    public string this[int i]
    {
        get { return classList[i]; }
        set { classList[i] = value; }
    }

    public Student()
    {
        this.FirstName = null;
        this.LastName = null;
        this.GPA = 0;
        this.year = 0;
    }

    public double getGPA()
    {
        return GPA;
    }

    public void setGPA(double temp)
    {
        GPA = temp;
    }
} 




class Program
{
    static void Main(string[] args)
    {
        var student1 = new Student { FirstName = "Valentine", LastName = "Shidlovskiy", year = 4};
        student1.setGPA(3.7);
        student1[0] = "CSCI 39537: Intro to API";
        student1[1] = "Math Something Something";
        Console.WriteLine("Student First Name: " + student1.FirstName);
        Console.WriteLine("Student Last Name: " + student1.LastName);
        Console.WriteLine("Student GPA: " + student1.getGPA());
        Console.WriteLine("Year " + student1.year);
        Console.WriteLine("List of Classes: ");
        Console.WriteLine(student1[0]);
        Console.WriteLine(student1[1]);
    }
}