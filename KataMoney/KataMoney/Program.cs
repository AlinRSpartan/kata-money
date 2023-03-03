namespace KataMoney;

public class Moneyy
{
    static void Main()
    {   
        double money = 21474836.47;

        Console.WriteLine(GetMoney(money));
    }

    public static string GetMoney(double money)
    {
        if (money == 0) return "No money";
        else if (money < 0) throw new ArgumentOutOfRangeException("Can't have negative money!");
        int totalPennies;
        checked 
        { 
            totalPennies = (int)(money * 100);
        }

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