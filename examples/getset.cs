// See 
using System;

class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
	
  //shortcut for get/set
  private int age;
  public int Age { get; set; }
}

public class Program
{
	public static void Main()
	{
		Person p1 = new Person();
		p1.Name= "John";
		Console.WriteLine("The name is " + p1.Name); // we do not need to do: p1.getName()
		p1.Age=42;
		Console.WriteLine("The age is " + p1.Age);	
	}
}