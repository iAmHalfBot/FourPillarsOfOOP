public class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing a shape");
}

public class Circle : Shape
{
    //we override the virtual method from base class
    public override void Draw() => Console.WriteLine("Drawing a Circle");
    
}

public class Triangle : Shape
{
    //This uses the virtual method from the base class
}
