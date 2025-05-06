# 📦 Four Pillars of Object-Oriented Programming (OOP)

در این ریپازیتوری قصد داریم به بررسی پارادایم برنامه‌نویسی شی‌گرا (Object-Oriented Programming) و چهار ستون اصلی آن بپردازیم.


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

###   انواع وراثت:

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

**توضیح:** در وراثت تکی، کلاس فرزند یک رابطه ساده و مستقیم با کلاس والد دارد. این مدل سرعت درک و نگهداری کد را افزایش می‌دهد و برای مواقعی مناسب است که رابطه "یک به یک" بین دو مفهوم برقرار باشد، مثلاً `Cat` و `Animal`. یکی از مزایای آن جلوگیری از تکرار کد است، ولی توجه کنید که وابستگی شدید به کلاس والد می‌تواند انعطاف‌پذیری را کاهش دهد.

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

**توضیح:** در وراثت چندسطحی، کلاس‌ها به شکل سلسله مراتبی سازماندهی می‌شوند و ویژگی‌ها از چند نسل منتقل می‌شوند. این تکنیک برای بازنمایی سلسله‌مراتب‌های واقعی مانند "موجودات -> حیوانات -> گربه" مناسب است. با این حال، افزایش عمق زنجیره می‌تواند پیچیدگی را بالا ببرد و اشکال‌زدایی را دشوار کند.

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

**توضیح:** در وراثت سلسله‌مراتبی، یک سوپركلاس مشترک، ویژگی‌ها و متدهای پایه را ارائه می‌دهد و کلاس‌های متعددی از آن ارث می‌برند. این ساختار به ما امکان می‌دهد تا کدهای مشترک را یکبار تعریف کنیم و از آن در چندین زیرکلاس استفاده کنیم. توجه داشته باشید که اگر نیاز به رفتارهای بسیار متفاوت باشد، این الگو ممکن است به سختی قابل نگهداری شود.

### 4. Multiple Inheritance

یک کلاس از چندین کلاس والد ارث می‌برد.

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

**توضیح:** وراثت چندگانه امکان ترکیب ویژگی‌ها و رفتارهای چند کلاس (یا اینترفیس) را در یک کلاس واحد می‌دهد. اینکار انعطاف‌پذیری زیادی می‌آورد، اما می‌تواند منجر به "مشکل الماس" (Diamond Problem) شود، جایی که تداخلی در توارث صفات از کلاس‌های مختلف رخ می‌دهد. در زبان‌هایی مانند C# برای حل این موضوع از اینترفیس‌ها استفاده می‌شود.

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

**توضیح:** وراثت ترکیبی یا Hybrid، ترکیبی از چند نوع وراثت (مانند تک، چندسطحی و چندگانه) است تا انعطاف و قابلیت‌های بیشتری ارائه دهد. این الگو در طراحی سیستم‌های پیچیده بسیار کارآمد است اما می‌تواند نگهداری و درک معماری را دشوار سازد.

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
