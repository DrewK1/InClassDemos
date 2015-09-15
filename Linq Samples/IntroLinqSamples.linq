<Query Kind="Program" />

void Main()
{
	//simple concatenation C# Expressions
	//"Hello World"
	//5+7
	
	//simple C# Statements
	//string name = "Drew";
	//string message = "hello " + name;
	//message.Dump();
	
	//simple C# program
	
	//Subroutine Call
	SayHello("Drew");
}

// Define other methods and classes here
public void SayHello(string name)
{
	string message = "Hello " + name;
	message.Dump();
}