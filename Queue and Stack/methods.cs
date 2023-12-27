using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        //creating a new stack of integes 
        Stack<int>myStack=new Stack<int> ();
        Stack<string>myStack1=new Stack<string> ();

        //push add elements to the stack
        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);

        myStack1.Push("Apple");
        myStack1.Push("Orange");
        myStack1.Push("Banana");

        string peekedElement1 = myStack1.Peek();
        Console.WriteLine("Peeked:" +peekedElement1);

        string popElement1 = myStack1.Pop();
        Console.WriteLine("Popped:" +popElement1);

        //poping (removing element from the stack)
        int popElement = myStack.Pop();
        Console.WriteLine("Popped:" +popElement);

        //peek at the top element with out removing 
        int peekedElement = myStack.Peek();
        Console.WriteLine("peeked:" +peekedElement);

        //display the remaining elements in the stack
        Console.WriteLine("Remaining elements in the stack:");
        foreach(int element in myStack)
        {
            Console.WriteLine(element);
        }
        foreach(string element1 in myStack1)
        {
            Console.WriteLine(element1);
        }
        myStack.Clear();
        Console.WriteLine("Count after clear:" +myStack.Count);
    

    
    }
}