public abstract class Shape
{
    public abstract double Area();
    
    public void Display()
    {
        Console.WriteLine("this is a shape");
    }
}


public class Rectangle : Shape
{
    double height;
    double width;
    
    public Rectangle(double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    public override double Area()
    {
        return height * width;
    }
}



