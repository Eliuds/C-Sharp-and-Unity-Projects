using System;

public class Class1
{
	public Class1()
	{

    public List<string> FirstName { get; set; }
    public List<string> LastName { get; set; }

    public void FullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

