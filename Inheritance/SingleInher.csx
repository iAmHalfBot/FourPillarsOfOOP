public class Animal
{
    public void Eat() => Console.WriteLine("the Animal is eating");
}

public class Cat : Animal
{
    public void Speak() => Console.WriteLine("MEOW");
}

var myCat = new Cat();

myCat.Eat();
//the Eat method is inherited from the Animal class(our Base class)
myCat.Speak();
//the Speak method is declared and defined inside the cat class and is specific to Cat
