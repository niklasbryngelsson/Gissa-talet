class TextWriter
{
    public static void SuccessText (string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        SetDefaultText();
    }

    public static void WarningText(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        SetDefaultText();
    }

    public static void FailText(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        SetDefaultText();
    }

    private static void SetDefaultText()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
}