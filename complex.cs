// using System;
// using System.Globalization;
// using System.Net;

// class Complex
// {
//     private int x; 
//     private int y;
//     public Complex(int i , int j)
//     {
//         this.x = i;
//         this.y = j;

//     }
//     public  void showXY()
//     {
//         Console.WriteLine("{0} {1}" , x, y);
//     }
//     public static Complex operator -(Complex c)
//     {
//         Complex temp = new Complex();
//         temp.x = -c.x;
//         temp.y = -c.y;
//         return temp;
//     }
// }
// class Program{
//     static void main(string[] args)
//     {
//         Complex c1 = new Complex(10,20);
//         c1.showXY;
//         Complex c2 = new Complex();
//         c2.showXY();
//         c2 = -c1;
//         c2.showXY();

//     }
// }