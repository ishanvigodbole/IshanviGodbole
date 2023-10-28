// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

public class employee
{
    public string name;
    public string city;
    public int salary;
    public int DA;
    public int HRA;

    static public void getdata()
    {
        Console.WriteLine(" enter name: ");
        string name=Console.ReadLine(); 
       
        Console.WriteLine("enter your city");
        string city=Console.ReadLine();
        Console.WriteLine("enter your salary");
        int salary=ConvertToInt32(Console.ReadLine());
        Console.WriteLine("enter your DA");
        int DA= ConvertToInt32(Console.ReadLine());
        Console.WriteLine("enter your HRA");
        int HRA= ConvertToInt32(Console.ReadLine());
    }

    static public int calculate()
    {
        int total= salary + salary * DA/ 100 + salary * HRA / 100;
        return total;
    }

    static public void Display()
    { Console.WriteLine(int total); }
}
 employee employee=new employee();
 int employee.getdata();
int employee.calculate( );
 int employee.display(int total);