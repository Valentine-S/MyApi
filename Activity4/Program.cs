
public interface StudentInterface
{
    string? FirstName { get; set; }
    string? LastName { get; set; }
    int year { get; set; }
    double getGPA();
    void setGPA(double temp);
    //Class list and other private members not included in the interface because they are private and should not be visible to the user 
}


class Student : StudentInterface
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    private double GPA;
    public int year { get; set; }
    private string[] classList = new string[50];
    private bool Enrolled;
    private string? StudentID;

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
        this.Enrolled = false;
        this.StudentID = null;
    }

    public double getGPA()
    {
        return GPA;
    }

    public void setGPA(double temp)
    {
        GPA = temp;
    }

    public bool getEnrolled()
    {
        return Enrolled;
    }

    public void setEnrolled(bool temp)
    {
        Enrolled = temp;
    }

    public string getStudentID()
    {
        return StudentID;
    }

    public void setStudentID(string temp)
    {
        StudentID = temp;
    }

} 




class Program
{
    static void Main(string[] args)
    {
        //var student1 = new Student { FirstName = "Valentine", LastName = "Shidlovskiy", year = 4}; This instantiation method also works
        var student1 = new Student();
        student1.FirstName = "Valentine";
        student1.LastName = "Shidlovskiy";
        student1.setStudentID("0123456789");
        student1.setEnrolled(true);
        student1.setGPA(3.9);
        student1.year = 4;
        student1[0] = "CSCI 39537: Intro to API";
        student1[1] = "Math 123: Something Something";
        Console.WriteLine("Student First Name: " + student1.FirstName);
        Console.WriteLine("Student Last Name: " + student1.LastName);
        Console.WriteLine("Studnet ID: " + student1.getStudentID());
        Console.WriteLine("Student GPA: " + student1.getGPA());
        Console.WriteLine("Year: " + student1.year);
        Console.WriteLine("Is the Student Currently Enrolled: " + student1.getEnrolled());
        Console.WriteLine("List of Classes: ");
        Console.WriteLine(student1[0]);
        Console.WriteLine(student1[1]);
    }
}