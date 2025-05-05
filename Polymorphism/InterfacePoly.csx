public interface INotification {
    void Send(string message);
}

public class EmailNotification : INotification {
    //we implement the send method 
    public void Send(string message) => Console.WriteLine($"Email: {message}");
}

public class SMSNotification : INotification {
    //we implement the send method  
    public void Send(string message) => Console.WriteLine($"SMS: {message}");
}
INotification notifier = new SMSNotification();
notifier.Send("some message...");
