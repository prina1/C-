// See https://aka.ms/new-console-template for more information
public struct point
{
    public int x;
    public int y;
    public point (int x , int y)
    {
        this.x = x; 
        this.y = y;
    }
    public void display()
    {
        Console.WriteLine($"X: {x} , Y: {y}");
    }
}

class program
{
    static void Main ()
    {
        point myPoint = new point (10,20);

        Console.WriteLine("Initial point:");
        myPoint.display();
    }
}