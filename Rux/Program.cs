namespace Rux
{
    internal class Program
    {
        static void ShowHelp()
        {
            string[] lines = [
                "Usage: rux [options] [commands] input",
                "Options:",
                "   -h, --help      Show help",
                "   -v, --version   Show version",
                "Commands",
                "    build          Compile the current package",
                "    clean          Remove the target directory",
                "    init           Create a new package in the current directory",
                "    new            Create a new package",
                "    run            Run a binary"
            ];
            Console.WriteLine(string.Join("\n", lines));
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowHelp();
            }
        }
    }
}
