
using System;

class Program
{
    static double CalculateAverage(int grade1, int grade2 , int grade3)
    {
        return ( grade1 + grade2 + grade3 ) / 3;
    }
    static void Main()
    {
        string studentName = "Ahmad";

        int grade1 = 85;
        int grade2 = 90;
        int grade3 = 80;

        double average = CalculateAverage(grade1 , grade2 , grade3);
        Console.Write("------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Student: " + studentName);
        Console.WriteLine("Grade 1: " + grade1);
        Console.WriteLine("Grade 2: " + grade2);
        Console.WriteLine("Grade 3: " + grade3);
        Console.WriteLine("Average: " + average);

        Person person = new Person();
        person.ID=1;
        person.FarstName="Mohammed Nabeel Ali ";
        person.LastName="Taheer";
        person.Age=28;
        person.DateOfBirth=new DateOnly(1998,4,6);
        
        Console.Write("------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine($"ID : {person.ID}");
        Console.WriteLine($"FullName:  {person.FarstName}{person.LastName}");
        Console.WriteLine("Sofware Engineer");
        Console.WriteLine($"Age : {person.Age}");
        Console.WriteLine($"DateOfBirth : {person.DateOfBirth}");
        Console.Write("------------------------------------------------------------------------------");
    }

}