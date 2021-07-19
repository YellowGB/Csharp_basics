using System;

namespace Vin_Fletcher_s_Arrows
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrowhead arrowhead = new();
            Fletching fletching = new();
            byte length;

            Console.WriteLine("Select the arrowhead's type :\n1. Wood\n2. Obsidian\n3. Steel");
            switch (Console.ReadLine())
            {
                case "1":
                    arrowhead = Arrowhead.Wood;
                    break;
                case "2":
                    arrowhead = Arrowhead.Obsidian;
                    break;
                case "3":
                    arrowhead = Arrowhead.Steel;
                    break;
            }

            Console.WriteLine("Select the fletching's type :\n1. Goose Feathers\n2. Turkey Feathers\n3. Plastic");
            switch (Console.ReadLine())
            {
                case "1":
                    fletching = Fletching.GooseFeathers;
                    break;
                case "2":
                    fletching = Fletching.TurkeyFeathers;
                    break;
                case "3":
                    fletching = Fletching.Plastic;
                    break;
            }

            Console.Write("Type the length in centimeters of the shaft : ");
            length = Convert.ToByte(Console.ReadLine());

            // Create arrow instance
            Arrow arrow = new(arrowhead, fletching, length);
            // Determine the cost of this arrow
            Console.WriteLine($"\nCrafting this arrow costs {arrow.GetCost()} gold");
        }
    }

    //-----------------------------------------------------------------------------------------------
    // CLASSES
    class Arrow
    {
        // Fields
        public Arrowhead _arrowhead;
        public Fletching _fletching;
        public byte _length;

        // Constructor
        public Arrow(Arrowhead arrowhead, Fletching fletching, byte length)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _length = length;
        }

        // Determine the arrow's cost
        public float GetCost()
        {
            return (float)_arrowhead + (float)_fletching + (float)(_length*0.05);
        }
    }

    //-----------------------------------------------------------------------------------------------
    // ENUMS
    enum Arrowhead 
    {
        Wood = 3,
        Obsidian = 5,
        Steel = 10
    }
    enum Fletching
    {
        GooseFeathers = 3,
        TurkeyFeathers = 5,
        Plastic = 10
    }
}
