class MainApp
{
    static void onWrongPathType(string type)
    {
        Console.WriteLine($"{type} is wrong type");
        return;
    }

    static void Main(string[] args)
    {
        if(args.Length == 0)
        {
            Console.WriteLine(
                "Usage : Touch.exe<Path> [Type:File/Directory]");
            return;
        }

        string path = args[0];
        string type = "File";
    }
}