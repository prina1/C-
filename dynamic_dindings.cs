using System;
class Shape {
    public virtual void Draw() {
        Console.WriteLine("Drawing a generic shape");
    }
}
class Circle :Shape 
{
    //override the virtual method
    public override void Draw()
    {
        Console.WriteLine("Circle Draw");
    }
}
class Rectangle : Shape 
{
    public override void Draw()
    {
        Console.WriteLine("Rectangle Draw");
    }
}
class Program
{
    static void Main()
    {
        //creating instance of Circle and Rectangle 
        Shape Shape1 = new Circle();
        Shape Shape2 = new Rectangle();
        

        // calls the overridden Drae method in circle
        DrawShape(Shape1);
        // calls the overridden Draw method in Rectangle
        DrawShape(Shape2);

       
    }
    static void DrawShape(Shape shape)
    {
        //calls the appropriate Draw method based on the actual type of object
        shape.Draw();
    }
}