// using System;
// using System.Collections.Generic;
// class Progam 
// {
//     static void Main()
//     {
//         //creating a new queue of integers 
//         Queue<int>myQueue = new Queue<int>();
//         Queue<string>myQueue1 = new Queue<string>();

//         // enque add elements to the queue

//         myQueue.Enqueue(10);
//         myQueue.Enqueue(20);
//         myQueue.Enqueue(30);
//         Console.WriteLine(myQueue.Count);

//         myQueue1.Enqueue("Apple");
//         myQueue1.Enqueue("Orange");
//         myQueue1.Enqueue("Banana");
        

//         //dequeue removes the first element from the queue
//         int firstElement = myQueue.Dequeue();
//         Console.WriteLine("Dequeued:" +firstElement);

//         //peek the front element of the queue
//         int peekedElement = myQueue.Peek();
//         Console.WriteLine("Peeked:" +peekedElement);

//         //Display the remaining elements in the queue
//         Console.WriteLine("Remaining elements in the queue:");
//         foreach(int element in myQueue)
//         {
//             Console.WriteLine(element);
//         }
//         myQueue.Clear();
//         Console.WriteLine("Count after clear:" +myQueue.Count);

//     }
// }