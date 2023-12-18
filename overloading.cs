// using System;

// class Vector
// {
//     public double X {get; set;}
//     public double Y {get; set;}

//     public Vector(double x, double y)
//     {
//         X = x;
//         Y = y;
//     }
//     //overload + operator to add two vectors 
//     public static Vector operator +(Vector v1, Vector v2)
//     {
//         return new Vector(v1.X +v2.X, v1.Y+v2.Y);
        
//     }
//     //overload - opoerator to subtract one vector from another 
//     public static Vector operator -(Vector v1, Vector v2)
//     {
//         return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        
//     }
//    public static Vector operator /(Vector v1, Vector v2)
//    {
//     return new Vector(v1.X / v2.X, v1.Y / v2.Y);
//    }
//     public static Vector operator *(Vector v1, double scalar)
//     {
//         if (scalar == 0)
//         {
//             throw new ArgumentException("scalar cannot be zero");
//         }
//         return new Vector(v1.X /scalar, v1.Y /scalar);
//     }
//     public override string ToString()
//     {
//         return$"({X}, {Y})";
//     }
//     class Program{
//         static void Main()
//         {

// //input for vector 1
// Console.WriteLine("enter components for vector v1");
// Console.Write("X: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y:");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Vector v1 = new Vector(x1, y1);

// //input for vector 2;
// Console.WriteLine("enter components for vector v2");
// Console.Write("X:");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y:");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Vector v2 = new Vector(x2, y2);

// Console.WriteLine($"\n Vector v1: {v1}");
// Console.WriteLine($"Vector v2: {v2}");

// //perform operations 
// Vector sum = v1 +v2;
// Console.WriteLine($"\n sum of v1 and v2: {sum}");

// Vector difference = v1 - v2;
// Console.WriteLine($"Difference of v1 and v2: {difference}");

// Console.WriteLine("\n enter a scalat for scaling v1");
// double scalar = Convert.ToDouble(Console.ReadLine());
// Vector scaled = v1 * scalar;
// Console.WriteLine($"v1 * {scalar} = {scaled}");

// try{
//     Console.WriteLine("\n Enter a non-zero scalar for dividing v2");
//     double divisor = Convert.ToDouble(Console.ReadLine());
//     Vector division = v2 / divisor;
//     Console.WriteLine ($"v2 divided by {divisor} = {division}");



// }
// catch (ArgumentException e)
// {
//     Console.WriteLine($"Error: {e.Message}");

// }
// Console.ReadKey();




//         }
//     }

// }
using System;

class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Overload + operator to add two vectors 
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    // Overload - operator to subtract one vector from another 
    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector(v1.X - v2.X, v1.Y - v2.Y);
    }

    // Overload * operator to multiply a vector by a scalar
    public static Vector operator *(Vector v1, double scalar)
    {
        return new Vector(v1.X * scalar, v1.Y * scalar);
    }

    // Overload / operator to divide a vector by a scalar
    public static Vector operator /(Vector v1, double scalar)
    {
        if (scalar == 0)
        {
            throw new ArgumentException("scalar cannot be zero");
        }
        return new Vector(v1.X / scalar, v1.Y / scalar);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main()
    {
        // Input for vector 1
        Console.WriteLine("Enter components for vector v1");
        Console.Write("X: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Vector v1 = new Vector(x1, y1);

        // Input for vector 2
        Console.WriteLine("Enter components for vector v2");
        Console.Write("X: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Vector v2 = new Vector(x2, y2);

        Console.WriteLine($"\nVector v1: {v1}");
        Console.WriteLine($"Vector v2: {v2}");

        // Perform operations 
        Vector sum = v1 + v2;
        Console.WriteLine($"\nSum of v1 and v2: {sum}");

        Vector difference = v1 - v2;
        Console.WriteLine($"Difference of v1 and v2: {difference}");

        Console.WriteLine("\nEnter a scalar for scaling v1");
        double scalar = Convert.ToDouble(Console.ReadLine());
        Vector scaled = v1 * scalar;
        Console.WriteLine($"v1 * {scalar} = {scaled}");

        try
        {
            Console.WriteLine("\nEnter a non-zero scalar for dividing v2");
            double divisor = Convert.ToDouble(Console.ReadLine());
            Vector division = v2 / divisor;
            Console.WriteLine($"v2 divided by {divisor} = {division}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        Console.ReadKey();
    }
}