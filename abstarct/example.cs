using System;

//Abstratct class
abstract class Shape
{
    public abstract double CalculatorArea();
    
    //Concrete method
    public void DisplayArea()
    {
        double area = CalculatorArea();
        Console.WriteLine($"Area:{area}");
    }
}
//Derived class :Circle 
class Circle : Shape
{
    //properties 
    public double Radius {get; set;}

    //implement the abstract method
    public override double CalculatorArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

//Derved class : Rectangle 
class Rectangle : Shape 
{
    //properties 
    public double Length {get; set;}
    public double Width {get; set;}

    //implement the abstract method
    public override double CalculatorArea()
    {
        return Length * Width;
    }
}
class Program 
{
    static void Main()
    {
        //Create instance of Circle class
        Circle circle = new Circle{Radius = 2.4};
        Rectangle rectangle = new Rectangle{Length = 2.5, Width = 3.5};

        //use the abstract class and its methods
        Console.WriteLine("Circle");
        circle.DisplayArea();

        Console.WriteLine("\nRectangle");
        rectangle.DisplayArea();
    }
}
