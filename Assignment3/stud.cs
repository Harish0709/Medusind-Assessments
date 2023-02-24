using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Student
{
    int rollno, semester;
    string name, classname, branch;
    public int[] marks = new int[5];
    public string result;

    public Student(int rollno, int semester, string name, string classname, string branch)
    {
        this.rollno = rollno;
        this.semester = semester;
        this.name = name;
        this.classname = classname;
        this.branch = branch;
    }

    public void GetMarks()
    {
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter marks for subject {0}:", i + 1);
            marks[i] = Convert.ToInt32(Console.ReadLine());
            if (marks[i] < 35)
            {
                result = "FAIL";
            }
        }
    }

    public void DisplayResult()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Roll No: {0}", rollno);
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Class: {0}", classname);
        Console.WriteLine("Semester: {0}", semester);
        Console.WriteLine("Branch: {0}", branch);

        Console.WriteLine("Marks:");


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Subject {0}: {1}", i + 1, marks[i]);
        }
        if (result == "FAIL")
        {
            Console.Write($"Result: {result}");
        }
        else
        {
            result = marks.Average() < 50 ? "FAIL" : "PASS";
            Console.Write($"Result: {result}");
        }
    }

    static void Main()
    {
        int rollno, semester;
        string name, classname, branch;
        
        Console.WriteLine("Enter Student Details:");
        Console.Write("Roll Number: "); 
        rollno = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: "); 
        name = Console.ReadLine();
        Console.Write("Class: "); 
        classname = Console.ReadLine();
        Console.Write("Semester: ");
        semester = Convert.ToInt32(Console.ReadLine());
        Console.Write("Branch: ");
        branch = Console.ReadLine();
        
        Student s = new Student(rollno, semester, name, classname, branch);
        s.GetMarks();
        s.DisplayResult();
        Console.Read();
    }
}