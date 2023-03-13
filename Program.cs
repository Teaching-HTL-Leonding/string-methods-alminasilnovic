{
    do
    {
        int index = 0;
        int length = 0;
        System.Console.Write("Enter a string: ");
        string text = Console.ReadLine()!;
        if (text == "")
        {
            return;
        }
        System.Console.Write("Enter a char: ");
        char c = char.Parse(Console.ReadLine()!);
        System.Console.Write("Enter another char: ");
        char c2 = char.Parse(Console.ReadLine()!);

        System.Console.WriteLine($"The string contains {c}: {Contains(text, c)}");
        System.Console.WriteLine($"The first index of the {c} in the string is {IndexOf(text, c, ref index)}");
        System.Console.WriteLine($"The last index of the {c} in the string is {LastIndexOf(text, c, index)}");
        System.Console.WriteLine($"The string with TrimStart() is now {TrimStart(text, c2)}");
        System.Console.WriteLine($"The string with TrimEnd() is now {TrimEnd(text, c2)}");
        System.Console.WriteLine($"The string with Trim() is now {Trim(text, c2)}");
        System.Console.WriteLine($"The string with Substring() is now {Substring(text, index, length)}");
        System.Console.WriteLine($"The string with Remove() is now {Remove(text, index, length)}");
    }
    while (true);
}

bool Contains(string text, char c)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == c)
        {
            return true;
        }
    }
    return false;
}
int IndexOf(string text, char c, ref int index)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == c)
        {
            return i;
        }
    }
    return -1;
}
int LastIndexOf(string text, char c, int index)
{
    for (int i = text.Length - 1; i > 0; i--)
    {
        if (text[i] == c)
        {
            return i;
        }
    }
    return -1;
}
string TrimStart(string text, char c)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[0] == c)
        {
            text = text.Substring(1, text.Length - 1);
        }
    }
    return text;
}
string TrimEnd(string text, char c)
{
    for (int i = text.Length; i > -1; i--)
    {
        if (text[text.Length - 1] == c)
        {
            text = text.Substring(0, i - 1);
        }
    }
    return text;
}
string Trim(string text, char c)
{
    for (int i = text.Length; i > -1; i--)
    {
        if (text[i - 1] == c)
        {
            text = text.Substring(0, i - 1);
        }
        else
        {
            return TrimStart(text, c);
        }
    }
    return text;
}
string Substring(string text, int index, int length)
{
    System.Console.Write("What index should the substring start at? ");
    index = int.Parse(Console.ReadLine()!);
    System.Console.Write("How long should the substring be? ");
    length = int.Parse(Console.ReadLine()!);
    for (int i = 0; i != index; i++)
    {
        text = text.Replace(text[0].ToString(), "");
    }
    if (length % 1000 != 0)
    {
        for (int i = 0; text.Length != length; i++)
        {
            text = text.Remove(text.Length - 1, 1); 
        }
    }
    return text;
}
string Remove(string text, int index, int length)
{
    string remove = "";
    System.Console.Write("What index does the letter have you want to remove? ");
    index = int.Parse(Console.ReadLine()!);
    System.Console.Write("How many letters after that do you want to remove? ");
    length = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < length; i++)
    {
        remove += text[index];
    }
    text = text.Replace(remove, "");
    return text;
}