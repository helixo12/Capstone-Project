using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatelogue
{
    class Game
    {
        #region Fields

        private string _title;
        private string _developer;
        private string _publisher;
        private bool _inStock;
        private double _price;
        private double _sales;

        #endregion

        #region Properties

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Developer
        {
            get { return _developer; }
            set { _developer = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public bool InStock
        {
            get { return _inStock; }
            set { _inStock = value; }
        }

        public Double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double Sales
        {
            get { return _sales; }
            set { _sales = value; }
        }
        #endregion

        #region Constructors

        public Game()
        {

        }

        #endregion

        #region Properties

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            DisplayOpeningScreen();

            List<Game> inventory;
            Game game;

            inventory = InitializeInventory();
            game = DisplayGetGame();
            inventory.Add(game);
            DisplayInventory(inventory);
            DisplayClosingScreen();
        }

        static Game DisplayGetGame()
        {
            Game userGame = new Game();

            DisplayHeader("Enter Game");

            Console.Write("Title: ");
            userGame.Title = Console.ReadLine();

            Console.Write("Publisher: ");
            userGame.Publisher = Console.ReadLine();

            Console.Write("Developer: ");
            userGame.Developer = Console.ReadLine();

            Console.Write("In Stock: ");
            userGame.InStock = bool.Parse(Console.ReadLine());

            Console.Write("Price: ");
            userGame.Price = double.Parse(Console.ReadLine());

            Console.Write("Sales: ");
            userGame.Sales = double.Parse(Console.ReadLine());

            DisplayContinuePrompt();


            return userGame;
        }

        static void DisplayInventory(List<Game> inventory)
        {
            DisplayHeader("Inventory");

            foreach (Game game in inventory)
            {
                Console.Write(game.Title.PadRight(30));
                Console.Write(game.Publisher.PadRight(30));
                Console.Write(game.Developer.PadRight(6));
                Console.Write(game.Price.ToString("C").PadLeft(8));
                Console.Write(game.Sales.ToString("G").PadLeft(10));
                if (game.InStock)
                {
                    Console.Write("Yes".PadLeft(5));
                }
                else
                {
                    Console.Write("No".PadLeft(5));
                }
                Console.WriteLine();
            }

            DisplayContinuePrompt();

        }

        static List<Game> InitializeInventory()
        {
            List<Game> inventory = new List<Game>()
            {

                new Game()
                {
                    Title = "Xenoblade Chronicles 2",
                    Publisher = "Nintendo",
                    Developer = "MonolithSoft",
                    InStock = true,
                    Price = 59.99,
                    Sales = 300000
                },

                new Game()
                {
                    Title = "Super Mario Odyssey",
                    Publisher = "Nintendo",
                    Developer = "Nintendo",
                    InStock = true,
                    Price = 59.99,
                    Sales = 2000000
                },

                new Game()
                {
                    Title = "Middle Earth: Shadow of War",
                    Publisher = "Warners Bros",
                    Developer = "Monolith Productions",
                    InStock = true,
                    Price = 59.99,
                    Sales = 3000000
                },

                new Game()
                {
                    Title = "Dragon Ball Fighterz",
                    Publisher = "Bandai Namco",
                    Developer = "Arc System Works",
                    InStock = false,
                    Price = 59.99,
                    Sales = 0
                },

                new Game()
                {
                    Title = "Wolfenstein II",
                    Publisher = "Bethesda",
                    Developer = "MachineGames",
                    InStock = true,
                    Price = 59.99,
                    Sales = 0
                },

                new Game()
                {
                    Title = "Pokemon Ultra Sun and Moon",
                    Publisher = "Nintendo",
                    Developer = "Game Freak",
                    InStock = true,
                    Price = 39.99,
                    Sales = 1200000
                },

                new Game()
                {
                    Title = "Sonic Mania",
                    Publisher = "SEGA",
                    Developer = "PagodaWest Games",
                    InStock = true,
                    Price = 19.99,
                    Sales = 500000
                }

            };



            return inventory;
        }

        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to the Game Catelogue Page!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();



            Console.WriteLine();
            Console.WriteLine("\t\tThanks for looking at our game catelogue!");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }
    }
}
