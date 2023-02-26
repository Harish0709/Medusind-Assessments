using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Saledetails
{
    public int Salesno { get; set; }
    public int Productno { get; set; }
    public double Price { get; set; }
    public DateTime Dateofsale { get; set; }
    public int Qty { get; set; }
    public double TotalAmount { get; private set; }

    public Saledetails(int salesno, int productno, double price, DateTime dateofsale, int qty)
    {
        Salesno = salesno;
        Productno = productno;
        Price = price;
        Dateofsale = dateofsale;
        Qty = qty;
        Sales();
    }

    public void Sales()
    {
        TotalAmount = Qty * Price;
    }

    public void showData()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Sales no:" +Salesno);
        Console.WriteLine("Product no:" +Productno);
        Console.WriteLine("Price:" +Price);
        Console.WriteLine("Date of sale:" +Dateofsale);
        Console.WriteLine("Quantity:" +Qty);
        Console.WriteLine("Total amount:" +TotalAmount);
        Console.Read();
    }
}

public class sales
{
    public static void Main()
    {
        Console.Write("Enter sales no: ");
        int salesno = int.Parse(Console.ReadLine());

        Console.Write("Enter product no: ");
        int productno = int.Parse(Console.ReadLine());

        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter date of sale (yyyy-MM-dd): ");
        DateTime dateofsale = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int qty = int.Parse(Console.ReadLine());

        Saledetails sale = new Saledetails(salesno, productno, price, dateofsale, qty);
        sale.showData();

    }
}
