using System;
using System.Collections.Generic;

class Program 
{
    static void Main()
    {
        //creating a dictonary with string keys and int yvalues 
        Dictionary<string,int> ages = new Dictionary<string,int>();

        //adding key value pair to the dictonary
        ages["Alice"]= 25;
        ages["Bob"]= 30;
        ages["Sudha"]=22;

        //acissing value by key
        Console.WriteLine(ages["Sudha"]);


    

    }
}