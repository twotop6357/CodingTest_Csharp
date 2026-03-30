using System;

public class Example
{
    public static void Main()
    {
        String s;
        Console.Clear();
        s = Console.ReadLine();        
        int length = s.Length;
        char[] result = new char[length];

        for(int i = 0; i < length; i++) {
            char c = s[i];
            if(char.IsUpper(c))
                result[i] = char.ToLower(c);
            else if(char.IsLower(c))
                result[i] = char.ToUpper(c);
            else
                result[i] = c;
        }
        Console.WriteLine(new string(result));
    }
}