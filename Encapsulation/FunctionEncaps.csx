public class Tax
{
    //the 0.05 is just an example
    //we hide the logic behind calculating the tax in the private TaxNum method 
    private double TaxNum(double inputNum) => inputNum * 0.05;
    //then we use the public Total method as an interface 
    public double Total(double inputNum) => inputNum + TaxNum(inputNum);
}



