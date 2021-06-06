using System;

namespace Simula_s_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commands:\nopen\nclose\nlock\nunlock\nexit");

            Chest simulaBox = new Chest(ChestState.locked);

            while (true)
            {
                switch (simulaBox.Current)
                {
                    case ChestState.open:
                        Console.Write("The chest is open. ");
                        break;
                    case ChestState.closed:
                        Console.Write("The chest is closed. ");
                        break;
                    case ChestState.locked:
                        Console.Write("The chest is locked. ");
                        break;
                }
                Console.Write("What do you want to do ? ");
                simulaBox.OperateChest(Console.ReadLine());
            }
        }

        public class Chest
    {
            private ChestState current;

            public Chest(ChestState currentState)
            {
                current = currentState;
            }

            public ChestState Current
            {
                get { return current; }
                set { current = value; }
            }

            public void OperateChest(string command)
            {
                if (command == "exit") Environment.Exit(0);
                else switch (current)
                {
                    case ChestState.open:
                            if (command == "close")
                                current = ChestState.closed;
                            else Console.WriteLine("Unauthorized operation");
                        break;
                    case ChestState.closed:
                            if (command == "open")
                                current = ChestState.open;
                            else if (command == "lock")
                                current = ChestState.locked;
                            else Console.WriteLine("Unauthorized operation");
                            break;
                    case ChestState.locked:
                            if (command == "unlock")
                                current = ChestState.closed;
                            else Console.WriteLine("Unauthorized operation");
                            break;
                }
            }
        }

        public enum ChestState { open, closed, locked }
    }
}
