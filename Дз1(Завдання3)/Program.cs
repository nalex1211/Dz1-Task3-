namespace MyApp;

public class Converter
{
    private decimal euro;
    private decimal dollar;
    public Converter(decimal euro, decimal dollar)
    {
        this.euro = euro;
        this.dollar = dollar;
    }

    public decimal euroToUah(decimal uah) => uah * euro;
    public decimal dollarToUah(decimal uah) => uah * dollar;
    public decimal uahToEuro(decimal uah) => uah / euro;
    public decimal uahToDollar(decimal uah) => uah / dollar;
}

internal class Program
{
    private static void Main(string[] args)
    {
        var converter = new Converter(40, 41);
        Console.Write("Enter the amount of UAH: ");
        decimal amountOfUah = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Choose your option:\n" +
            "1-Uah To Euro\n" +
            "2-Uah To Dollars\n" +
            "3-Euro To Uah\n" +
            "4-Dollar To Uah\n");

        int choice = Convert.ToInt32(Console.ReadLine());
        var choicesMap = new Dictionary<int, Func<decimal, decimal>>()
        {
            [1] = converter.uahToEuro,
            [2] = converter.uahToDollar,
            [3] = converter.euroToUah,
            [4] = converter.dollarToUah
        };
        Console.WriteLine(choicesMap[choice](amountOfUah));
    }
}
