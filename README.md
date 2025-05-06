# 📦 Four Pillars of Object-Oriented Programming (OOP)

در این ریپازیتوری قصد داریم به بررسی پارادایم برنامه‌نویسی شی‌گرا (Object-Oriented Programming) و چهار ستون اصلی آن بپردازیم.  
در ابتدا با مفهوم **وراثت** و سپس **چندریختی** آشنا خواهیم شد.

---

## 🔑 چهار ستون اصلی OOP

1. **Inheritance** (وراثت)  
2. **Polymorphism** (چندریختی)  
3. **Encapsulation** (کپسوله‌سازی)  
4. **Abstraction** (انتزاع)

---

## 🧬 وراثت (Inheritance)

وراثت یکی از پایه‌های مهم OOP است که به یک کلاس اجازه می‌دهد خصوصیات و رفتارهای یک کلاس دیگر را به ارث ببرد.  
در این بخش به انواع مختلف وراثت می‌پردازیم:

### ✅ انواع وراثت:

### 1. Single Inheritance
   کلاس فرزند مستقیماً از یک کلاس والد ارث می‌برد.  
```csharp
public class Animal
{
    public void Eat() => Console.WriteLine("The animal is eating");
}

public class Cat : Animal
{
    public void Speak() => Console.WriteLine("MEOW");
}

class Program
{
    static void Main()
    {
        var myCat = new Cat();
        
        myCat.Eat();   // Inherited from Animal (base class)
        myCat.Speak(); // Defined in Cat (derived class)
    }
}
```

### 2. Multilevel Inheritance  
   زنجیره‌ای از ارث‌بری بین چند کلاس شکل می‌گیرد.  
 ```csharp
//this is our level 1 (base) class 
public class Creature  
{   
    public void Breath() => Console.WriteLine("the Creature is breating");
}
//Animal is the level 2
public class Animal : Creature
{
    public void Eat() => Console.WriteLine("the Animal is eating");
}
//and the level 3 so our chain would look like Cat -> Animal -> Creature
public class Cat : Animal
{
    public void Speak() => Console.WriteLine("the Cat says Meow");
}

var myCat = new Cat();
//the Breath method is inherited from the grandparent class (Creature) 
myCat.Breath();
//the Eat method is inherited from the parent class (Animal)
myCat.Eat();
//the Speak is defined inside the Cat class itself
myCat.Speak();
```

### 3. Hierarchical Inheritance  
   چندین کلاس فرزند از یک کلاس والد مشترک ارث می‌برند.  
```csharp
//this is our base class(superclass)
public class Electronics
{
    public void TurnOn() => Console.WriteLine("the electronic is turning on");
}
//Phone and Laptop classes are subclasses derived from our superclass
public class Phone : Electronics
{
    public void Calling() => Console.WriteLine("the phone is calling");
}

public class Laptop : Electronics
{
    public void Computing() => Console.WriteLine("the laptop is computing");
}

new Phone().Calling();
new Laptop().Computing();
```

### 4. Multiple Inheritance  
   یک کلاس از چندین کلاس والد ارث می‌برد (در زبان‌هایی مثل C++ و Python پشتیبانی می‌شود).  
```csharp
public interface ICall {void Calling();}
public interface IPhoto {void TakingPhoto();}
public interface IFlash {void FlashLight();}

public class Phone : ICall, IPhoto, IFlash
{
    public void Calling() => Console.WriteLine("phone is calling");
    public void TakingPhoto() => Console.WriteLine("phone is taking a photo");
    public void FlashLight() => Console.WriteLine("phone's FlashLight is turned on");
}

new Phone().Calling();
new Phone().TakingPhoto();
new Phone().FlashLight();
```
### 5. Hybrid Inheritance
   ترکیبی از چند نوع وراثت بالا.  
```csharp
public class Device 
{
    public string Model{get;set;}
}

public interface ICamera
{
    void Photo();
}
public interface ICall
{
    void Calling();
}
public class Phone : Device, ICamera, ICall
{
    public void Photo() => Console.WriteLine($"{Model} is taking photo");   
    public void Calling() => Console.WriteLine($"{Model} is making a call");
}

public class Camera :Device, ICamera
{
    public void Photo() => Console.WriteLine($"{Model} is taking photo");
}

var myPhone = new Phone{Model = "Galaxy s24"};
myPhone.Photo();
myPhone.Calling();


var myCamera = new Camera{Model = "myRandomCamera"};
myCamera.Photo();
```

---

## 🎭 چندریختی (Polymorphism)

چندریختی به این معناست که یک تابع یا شی می‌تواند رفتارهای متفاوتی در شرایط مختلف از خود نشان دهد.  
در این بخش به **چهار نوع اصلی چندریختی** می‌پردازیم:

### 1. Method Overloading (Compile-Time Polymorphism)

در یک کلاس، متدهایی با نام یکسان ولی با پارامترهای متفاوت تعریف می‌کنیم.  
**(جایگذاری مثال مربوط به Overloading)**

---

### 2. Method Overriding (Run-Time Polymorphism)

در کلاس فرزند، متدی را که در کلاس والد تعریف شده است، با رفتار متفاوت بازنویسی می‌کنیم.  
**(جایگذاری مثال مربوط به Overriding)**

---

### 3. Polymorphism via Interface

امکان استفاده از یک نوع مرجع (مثلاً یک Interface) برای ارجاع به اشیاء با پیاده‌سازی‌های مختلف.  
**(جایگذاری مثال مربوط به Interface-based Polymorphism)**

---

### 4. Parametric Polymorphism (Generics)

استفاده از نوع‌های عمومی برای نوشتن کلاس یا متدهایی که با انواع مختلف کار می‌کنند.  
**(جایگذاری مثال مربوط به Generics)**

---


