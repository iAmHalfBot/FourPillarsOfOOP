public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a Circle");
}

public class Triangle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a Triangle");
}


public class my
{
    public static void main()
        {
            Circle myCircle = new Circle();
            myCircle.Draw();
        }
}

