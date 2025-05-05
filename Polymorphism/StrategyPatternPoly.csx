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
