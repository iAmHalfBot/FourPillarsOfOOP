public class Animal
{
    public void MakesSound() => Console.WriteLine("the animal makes a sound");
}

public class Dog : Animal
{
    //here we hide the MakesSound method from animal class  
    public new void MakesSound() => Console.WriteLine("the dog barks");
}

new Animal().MakesSound();
new Dog().MakesSound();
