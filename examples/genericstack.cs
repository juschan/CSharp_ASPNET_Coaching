using System;

static class Constants {
    public const int STACK_SIZE = 100;
}

public class Stack<T>
{
	private T[] data;
	private int num;
	
	public Stack() {
		this.data = new T[Constants.STACK_SIZE];
		this.num=0;
	}
	
	public void push(T a){
		data[num++]=a;
	}
	
	public T pop(){
		return data[--num];
	}
}

public class Program
{
	public static void Main()
	{
		Stack<int> myStack = new Stack<int>();
		myStack.push(1);
		myStack.push(4);
		myStack.push(11);
		
		Console.WriteLine(myStack.pop());
		Console.WriteLine(myStack.pop());
		Console.WriteLine(myStack.pop());
		
		//now do for string
		Stack<string> myStack2 = new Stack<string>();
		myStack2.push("John");
		myStack2.push("Mary");
		myStack2.push("Jane");
		
		Console.WriteLine(myStack2.pop());
		Console.WriteLine(myStack2.pop());
		Console.WriteLine(myStack2.pop());		
	}
}