using System;

public class Person
{
    protected string Name { get; set; }
    protected string Address { get; set; }

    public Person(string name, string address)
    {
        Name = name;
        Address = address;
    }
}

public class Doctor : Person
{
    private string RegnNo { get; set; }
    private double FeesCharged { get; set; }
    private string Specialization { get; set; }

    public Doctor(string name, string address, string regnNo, double feesCharged, string specialization)
        : base(name, address)
    {
        RegnNo = regnNo;
        FeesCharged = feesCharged;
        Specialization = specialization;
    }

    public void ShowData()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Name:"+Name);
        Console.WriteLine("Address:"+Address);
        Console.WriteLine("Registration number:"+RegnNo);
        Console.WriteLine("Fees charged:"+FeesCharged);
        Console.WriteLine("Specialization: "+Specialization);
        Console.Read();
    }
}

public class doctor
{
    public static void Main()
    {
        Console.Write("Enter the name of the doctor: ");
        string name = Console.ReadLine();

        Console.Write("Enter the address of the doctor: ");
        string address = Console.ReadLine();

        Console.Write("Enter the registration number of the doctor: ");
        string regnNo = Console.ReadLine();

        Console.Write("Enter the fees charged by the doctor: ");
        double feesCharged = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the specialization of the doctor: ");
        string specialization = Console.ReadLine();

        Doctor doctor = new Doctor(name, address, regnNo, feesCharged, specialization);
        doctor.ShowData();
    }
}
