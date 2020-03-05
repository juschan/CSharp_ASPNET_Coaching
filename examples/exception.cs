using System;

namespace ErrorHandlingApplication {
	
	public class DivNumbers {
		  int result;

		  public DivNumbers() {
			 result = 0;
		  }
		  public void division(int num1, int num2) {
			 try {
				result = num1 / num2;
			 } catch (DivideByZeroException e) {
				Console.WriteLine("Exception caught: {0}", e);
			 } finally {
				Console.WriteLine("Result: {0}", result);
			 }
		  }

	}

	public class Program {
		  public void Main(string[] args) {
			 DivNumbers d = new DivNumbers();
			 d.division(25, 0);
		  } 
	}
	
}