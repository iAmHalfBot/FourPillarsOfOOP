public class Box<T>
{
    public T Value;
}

//here we define our type for the new instance of the Box and we define value
var randomBox = new Box<string>{Value = "random data"};

Console.WriteLine(randomBox.Value);


public class ListBox<T>
{
    public List<T> Items = new List<T>();
}

var randomListBox = new ListBox<string>{Items = {"random data", "more random data"}};
foreach (var item in randomListBox.Items)
{    
    Console.WriteLine(item);
}
