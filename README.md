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
   **(جایگذاری مثال مربوط به Multilevel Inheritance)**

### 3. Hierarchical Inheritance  
   چندین کلاس فرزند از یک کلاس والد مشترک ارث می‌برند.  
   **(جایگذاری مثال مربوط به Hierarchical Inheritance)**

### 4. Multiple Inheritance  
   یک کلاس از چندین کلاس والد ارث می‌برد (در زبان‌هایی مثل C++ و Python پشتیبانی می‌شود).  
   **(جایگذاری مثال مربوط به Multiple Inheritance)**
### 5. Hybrid Inheritance
   ترکیبی از چند نوع وراثت بالا.  
   **(جایگذاری مثال مربوط به Hybrid Inheritance)**

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


