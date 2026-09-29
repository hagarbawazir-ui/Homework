class Program
{
    static void Main(string[] args)
    {
        CourseResult s1 = new CourseResult();
        Console.WriteLine("enter the name");
        s1.StudentName = Console.ReadLine();

        Console.WriteLine("enter the mark");
        s1.Mark = int.Parse(Console.ReadLine());
        s1.PrintResult();



    }
}
class CourseResult
{
    public string StudentName { get; set; }
    private int mark;
    public int Mark
    {
        get
        { return mark; }
        set
        {
            if (value >= 0 && value <= 100)
            { mark = value; }
            else

            { Console.WriteLine("value must be between 0 snf 100."); }

        }
    }
    public char Grade
    {
        get
        {
            if (Mark >= 90)
                return 'A';
            else if (Mark >= 80)
                return 'B';
            else if (Mark >= 70)
                return 'C';
            else if (Mark >= 50)
                return 'D';
            else
                return 'F';
        }
    }

    public bool Passed
    {
        get
        { return mark >= 50; }

    }
    public void PrintResult()
    {

        Console.WriteLine($"Name:{StudentName}");
        Console.WriteLine($"Mark:{Mark}");
        Console.WriteLine($"Grad:{Grade}");
        Console.WriteLine($"Passed:{Passed}");

    }
