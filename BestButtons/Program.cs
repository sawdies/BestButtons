namespace BestButtons
{
    internal class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Menu();
        }
        static void Menu()
        {
            Button[] buttons = [
                new Button("1", PrintHello),
                new Button("2", PrintBye),
            ];
            int buttonsCount = buttons.Length;
            int activeButtonIndex = 0;
            int nextButtonIndex = 0;
            buttons[0]._activity = true;
            Console.Clear();
            Button.PrintButtons(buttons);
            while (true) {
                switch (Console.ReadKey(true).Key) {
                    case ConsoleKey.Escape: Environment.Exit(0); break;
                    case ConsoleKey.Enter: buttons[activeButtonIndex].buttonAction(); break;
                    case ConsoleKey.W: case ConsoleKey.LeftArrow: case ConsoleKey.NumPad4:
                    case ConsoleKey.A: case ConsoleKey.UpArrow: case ConsoleKey.NumPad8:
                        nextButtonIndex = activeButtonIndex--; break;
                    case ConsoleKey.S: case ConsoleKey.RightArrow: case ConsoleKey.NumPad6:
                    case ConsoleKey.D: case ConsoleKey.DownArrow: case ConsoleKey.NumPad2:
                        nextButtonIndex = activeButtonIndex++; break;
                }
                if (activeButtonIndex < 0) activeButtonIndex = buttonsCount - 1;
                else if (activeButtonIndex >= buttonsCount) activeButtonIndex = 0;
                Button.SwitchButton(buttons, nextButtonIndex, activeButtonIndex);
            }
        }
        public static void PrintHello() => Console.Write("Hello");
        public static void PrintBye() => Console.Write("Bye");
    }
}