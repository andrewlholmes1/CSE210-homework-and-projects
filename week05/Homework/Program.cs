using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Doe", "History on historal wars");
        Console.WriteLine(a1.GetSummary());



        MathAssignment a2 = new MathAssignment("Jane Smith", "Algebra", "Section 2.3", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Emily Johnson", "English Literature", "The Great Gatsby");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}