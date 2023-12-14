namespace funkce;

public class Functions
{
    public void Run()
    {
        Console.WriteLine(TextLength("hello")); //should return 5; returns 5
        Console.WriteLine(SquareRoot(5)); //should return 25; returns 25
        PrintHappyBirthday(true); //should return a string; returns the string
        Console.WriteLine(IsOdd(3)); //should return "ODD"; returns "ODD"
        Counter(8); //should return 8 - 0 inclusive; returns 8 - 0 inclusive
        Console.WriteLine(ReturnLonger("test", "thisislonger")); //should return "thisislonger"; returns "thisislonger"
        
        Console.WriteLine(TextLength("testnumidk")); //should return 10; returns 10
        Console.WriteLine(SquareRoot(14)); //should return 196; returns 196
        PrintHappyBirthday(false); //shouldnt return anything; returns nothing
        Console.WriteLine(IsOdd(32)); //should return "EVEN"; returns "EVEN"
        Counter(3); //should return 3 - 0 inclusive; returns 3 - 0 inclusive
        Console.WriteLine(ReturnLonger("imnottoosureaboutthiscode", "thisislonger")); //should return "imnottoosureaboutthiscode"; returns "imnottoosureaboutthiscode"
        
        //code passed personal tests
    }

    public int TextLength(string text)
    {
        return text.Length;
    }

    public int SquareRoot(int num)
    {
        return num * num;
    }

    public void PrintHappyBirthday(bool print)
    {
        if (print)
        {
            Console.WriteLine("Vše nejlepší!");
        }
    }

    public string IsOdd(int num)
    {
        string[] results = { "ODD", "EVEN" };
        return results[num % 2 == 1 ? 0 : 1];
    }

    public void Counter(int num)
    {
        for (int x = num; x >= 0; x--)
        {
            Console.WriteLine(x);
        }
    }

    public string ReturnLonger(string text1, string text2)
    {
        string[] texts = { text1, text2 };
        return texts[text1.Length > text2.Length ? 0 : 1];
    }
}