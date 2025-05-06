# 📦 Four Pillars of Object-Oriented Programming (OOP)

در این ریپازیتوری قصد داریم به بررسی پارادایم شی‌گرا (Object-Oriented Programming) و چهار ستون اصلی آن بپردازیم.


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



### 1. Single Inheritance

کلاس فرزند مستقیماً از یک کلاس والد ارث می‌برد. در وراثت تکی، کلاس فرزند یک رابطه ساده و مستقیم با کلاس والد دارد. این مدل سرعت درک و نگهداری کد را افزایش می‌دهد و برای مواقعی مناسب است که رابطه "یک به یک" بین دو مفهوم برقرار باشد، مثلاً `Cat` و `Animal`. یکی از مزایای آن جلوگیری از تکرار کد است، ولی توجه کنید که وابستگی شدید به کلاس والد می‌تواند انعطاف‌پذیری را کاهش دهد.

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

زنجیره‌ای از ارث‌بری بین چند کلاس شکل می‌گیرد. در وراثت چندسطحی، کلاس‌ها به شکل سلسله مراتبی سازماندهی می‌شوند و ویژگی‌ها از چند نسل منتقل می‌شوند. این تکنیک برای بازنمایی سلسله‌مراتب‌های واقعی مانند "موجودات -> حیوانات -> گربه" مناسب است. با این حال، افزایش عمق زنجیره می‌تواند پیچیدگی را بالا ببرد و اشکال‌زدایی را دشوار کند.


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

چندین کلاس فرزند از یک کلاس والد مشترک ارث می‌برند. در وراثت سلسله‌مراتبی، یک سوپركلاس مشترک، ویژگی‌ها و متدهای پایه را ارائه می‌دهد و کلاس‌های متعددی از آن ارث می‌برند. این ساختار به ما امکان می‌دهد تا کدهای مشترک را یکبار تعریف کنیم و از آن در چندین زیرکلاس استفاده کنیم. توجه داشته باشید که اگر نیاز به رفتارهای بسیار متفاوت باشد، این الگو ممکن است به سختی قابل نگهداری شود.

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

یک کلاس از چندین کلاس والد ارث می‌برد. وراثت چندگانه امکان ترکیب ویژگی‌ها و رفتارهای چند کلاس (یا اینترفیس) را در یک کلاس واحد می‌دهد. اینکار انعطاف‌پذیری زیادی می‌آورد، اما می‌تواند منجر به "مشکل الماس" (Diamond Problem) شود، جایی که تداخلی در توارث صفات از کلاس‌های مختلف رخ می‌دهد. در زبان‌هایی مانند C# برای حل این موضوع از اینترفیس‌ها استفاده می‌شود.

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

ترکیبی از چند نوع وراثت بالا. وراثت ترکیبی یا Hybrid، ترکیبی از چند نوع وراثت (مانند تک، چندسطحی و چندگانه) است تا انعطاف و قابلیت‌های بیشتری ارائه دهد. این الگو در طراحی سیستم‌های پیچیده بسیار کارآمد است اما می‌تواند نگهداری و درک معماری را دشوار سازد.

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


### Beyond the Basics



---

## 🎭 چندریختی (Polymorphism)

چندریختی به این معناست که یک تابع یا شی می‌تواند رفتارهای متفاوتی در شرایط مختلف از خود نشان دهد.
در این بخش به **چهار نوع اصلی چندریختی** می‌پردازیم:
### 1. Ad-hoc Polymorphism (Static Polymorphism) 

چندریختی آدهوک (Ad-hoc Polymorphism) به حالتی از چندریختی می‌گویند که در آن یک نام برای تابع یا عملگر می‌تواند پیاده‌سازی‌های متفاوتی داشته باشد و کامپایلر در زمان کامپایل بر اساس نوع آرگومان‌ها، پیاده‌سازی مناسب را انتخاب می‌کند.
```csharp
public class Arithmetic
{
    // Method overloading   
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
   
}
```
### 2. Parametric Polymorphism (Generic)

چندریختی پارامتریک (Parametric Polymorphism) به حالتی از چندریختی گفته می‌شود که در آن یک تابع یا ساختار داده با استفاده از پارامترهای نوع (type parameters) به‌صورت عمومی تعریف می‌شود و در زمان استفاده (Instantiation) با انواع خاص پر می‌شود؛ به این ترتیب همان پیاده‌سازی روی انواع مختلف کار می‌کند بدون آن‌که برای هر نوع جداگانه‌ای کد تکراری بنویسیم.
```csharp
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
```
### 3. Subtype (Inclusion) Polymorphism

چندریختی زیرنوع (Subtype Polymorphism) اجازه می‌دهد تا ارجاع یا اشاره‌گری به یک کلاس پایه، به اشیای کلاس‌های مشتق‌شده اشاره کند و متد مناسب در زمان اجرا انتخاب شود. این شیوه بر مبنای ارث‌بری (inheritance) و پیوند دیرهنگام (late binding) است و معمولاً با استفاده از متدهای مجازی (virtual methods) پیاده‌سازی می‌شود.
```csharp
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
```
### 4. Coercion Polymorphism

چندریختی کوئریشن (Coercion Polymorphism) حالتی از چندریختی است که در آن زبان برنامه‌نویسی به‌طور خودکار نوع یک مقدار را به نوع دیگری تبدیل (cast) می‌کند تا بتواند آن را در زمینهٔ مورد نظر استفاده کند. این تبدیل می‌تواند ضمنی (implicit) باشد، بدون نیاز به دخالت مستقیم برنامه‌نویس، یا صریح (explicit) و با استفاده از عملگرهای تبدیل نوع.
```csharp
int a = 10;
double b = a;
//this is also known as Implicit type conversion

Console.WriteLine(b);


double x = 3.4;
int y = (int)x;
//this is Explicit type conversion

Console.WriteLine(y);

//both Implicit and Explicit type conversions are considered a form of polymorphism(Coercion)
```


---


### Beyond the Basics





#### -Strategy Design Pattern

الگوی طراحی Strategy (استراتژی) یکی از الگوهای رفتاری در برنامه‌نویسی شیءگرا است که به ما اجازه می‌دهد الگوریتم‌های مختلف را در کلاس‌های جداگانه پیاده‌سازی کرده و در زمان اجرا، بدون تغییر در کد اصلی، بین آن‌ها جابه‌جا شویم.
در مثال زیر ما یک رابط ISortStrategy تعریف کرده‌ایم که متدی به نام Sort دارد. سپس یک کلاس BubbleSort این رابط را پیاده‌سازی می‌کند. کلاس Sorter به عنوان زمینه (Context) عمل می‌کند و استراتژی مورد نظر را از طریق سازنده دریافت می‌کند.



```csharp
public interface ISortStrategy {
    void Sort(List<int> data);
}

public class BubbleSort : ISortStrategy {
    //we implement the Sort method
    public void Sort(List<int> data) => Console.WriteLine("Sorted List");
}

public class Sorter {
    // we make a private field of type ISortStrategy
    private ISortStrategy _strategy;
    // we implement a constructor that accepts an argument of type ISortStrategy we store the argument in the earlier declared private field
    public Sorter(ISortStrategy strategy) => _strategy = strategy;
    // then when calling the method Execute we accept a list of ints and use the stored strategy from previous line to perform sorting 
    public void Execute(List<int> data) => _strategy.Sort(data);
}
```




#### -liskov substitution principle (LSP)







