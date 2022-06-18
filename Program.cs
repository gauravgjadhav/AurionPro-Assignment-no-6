using System;
class Program
{
    public static void Main(string[] args)
    {
        string Strings = "Sachin,AurionPro,Mumbai";
        string[] stringList = Strings.Split(",");
        Console.WriteLine("Devoloper name is: " + stringList[0]);
        Console.WriteLine("Company name is: " + stringList[1]);
        Console.WriteLine("Locaiton is : " + stringList[2]);
    }
}