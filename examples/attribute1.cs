using System; 
 
public class Program { 
  
    [Obsolete("This method is obsolete...", true)]
    static public void Main() 
    { 
  		Console.WriteLine("Printing from obsolete method");		
	}
		
} 