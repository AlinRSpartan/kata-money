namespace KataMoney;

public class Moneyy
{
    static void Main()
    {   
        double money = 5.47;
        
        //int totalPennies = (int)(money * 100);
        //Console.WriteLine(totalPennies + "pennies");

        //int noOf5Notes = totalPennies / 500;
        //Console.WriteLine(noOf5Notes);

        Console.WriteLine(GetMoney(money));
    }

    public static string GetMoney(double money)
    {
        int totalPennies = (int)(money * 100);

        int[] storeValues = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        int[] noteValue = { 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        for(int i = 0; i < storeValues.Count(); i++)
        {
            storeValues[i] = totalPennies / noteValue[i];
            totalPennies = totalPennies % noteValue[i];
        }

        string[] notesString = { "£50", "£20", "£10", "£5", "£2", "£1", "50p", "20p", "10p", "5p", "2p", "1p" };

        string result = "";

        for(int i = 0; i < storeValues.Count(); i++)
        {
            if (storeValues[i] > 0)
                result += ($"{storeValues[i]} {notesString[i]}\n");
        }
        return result;
    }
}