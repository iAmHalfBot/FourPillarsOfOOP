public abstract class Database {
    public abstract void Connect();
    public void Log(string message) => Console.WriteLine($"Log: {message}");
}

public class SqlDatabase : Database {
    //overriding the base class abstract method  
    public override void Connect() => Console.WriteLine("SQL connection");
}

