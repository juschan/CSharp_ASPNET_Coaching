using System;

static class Constants {
    public const int STACK_SIZE = 100;
}

public class Stack
{
	private int[] data;
	private int num;
	
	public Stack() {
		this.data = new int[Constants.STACK_SIZE];
		this.num=0;
	}
	
	public void push(int a){
		data[num++]=a;
	}
	
	public int pop(){
		return data[--num];
	}
}

public class Program
{
	public static void Main()
	{
		Stack myStack = new Stack();
		myStack.push(1);
		myStack.push(4);
		myStack.push(11);
		
		Console.WriteLine(myStack.pop());
		Console.WriteLine(myStack.pop());
		Console.WriteLine(myStack.pop());
	}
}