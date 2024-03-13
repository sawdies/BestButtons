namespace BestButtons
{
    public class Button
    {
        public string _name;
        public bool _activity;
        public ConsoleColor _color;
        public Action buttonAction;
        public Button(string name, Action action, ConsoleColor color = ConsoleColor.Gray)
        {
            _name = name;
            _activity = false;
            _color = color;
            buttonAction = action;
        }
        public static void PrintButtons(Button[] array)
        {
            foreach (Button b in array)
            {
                if (b._activity)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = b._color;
                    Console.WriteLine($"  {b._name}  ");
                }
                else
                {
                    Console.ForegroundColor = b._color;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine($"  {b._name}  ");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        protected static void PrintSingleButton(Button[] array, int index)
        {
            if (array[index]._activity)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = array[index]._color;
                Console.WriteLine($"  {array[index]._name}  ");
            }
            else
            {
                Console.ForegroundColor = array[index]._color;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"  {array[index]._name}  ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void SwitchButton(Button[] array, int activeButtonIndex, int nextActiveButton)
        {
            foreach (Button b in array)
            {
                b._activity = false;
            }
            array[activeButtonIndex]._activity = false;
            array[nextActiveButton]._activity = true;
            Console.SetCursorPosition(0, activeButtonIndex);
            PrintSingleButton(array, activeButtonIndex);
            Console.SetCursorPosition(0, nextActiveButton);
            PrintSingleButton(array, nextActiveButton);
        }
        public static void Ignore(){}//действие для пустых кнопок
    }

}
