// using System;
// using System.Collections.Generic;

// class Program{
//     static void Main()
//     {
//         //creating a generic list of type T
//         List<int>integerList = new List<int>();
//         List<string>stringList = new List<string>();
//         List<double>doubleList = new List<double>();

//         //adding elements to the list
//         integerList.Add(1);
//         integerList.Add(2);
//         integerList.Add(3);

//         stringList.Add("Apple");
//         stringList.Add("Orrange");
//         stringList.Add("Banana");

//         doubleList.Add(3.4);
//         doubleList.Add(5.6);
//         doubleList.Add(7.8);

//         Console.WriteLine("Integer List");
//         DisplayList(integerList);
//         integerList.Sort();
//         integerList.Remove(2);
//         integerList.RemoveAt(0);

//         DisplayList(integerList);


//         Console.WriteLine("\n sring List");
//         DisplayList(stringList);

//         Console.WriteLine("\n Double List");
//         DisplayList(doubleList);

//     }
//     //helper methid to display the content of generic list
//     static void DisplayList<T>(List<T>List)
//     {
//         foreach(T item in List)
//         {
//             Console.WriteLine(item);
//         }
//         Console.WriteLine();

//     }
// }