using System;
using System.IO;

namespace Lab03System.IO
{
    //TODOS
    //Create file
    //Read file
    //Update file
    //Delete file
    //User menu 
    //1. Play game
    //2. Exit game
    //3. Admin Menu - Display Words, Add a Word, Delete a Word, Return to Main Menu
    //Additional methods needed Contains(), Random(), ToCharArray, Ingore casing, StringComparison.CurrentCultureIgnoreCase
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../guesswords.txt";
            Console.WriteLine("Shall we play a game?");
            Console.WriteLine("==========");
            CreateFile(path);
            Menu();
        }

        /// <summary>
        /// Create fie path as a dependency and not in the 
        /// </summary>
        /// <param name="path"></param>
        public static void CreateFile(string path)
        {
            //Defensive programming

            //this is a using statement and not a using directive like at the top of the page; allows us to open connection to a database of file and closes when it gets to the bottom of the closing curly brace; closes stream. non-closed streams cause security leaks
            using (StreamWriter sw = new StreamWriter(path))
            {
                try
                {
                    sw.WriteLine("bus");
                    sw.WriteLine("mall");
                    sw.WriteLine("salmon");
                    sw.WriteLine("cookies");
                    sw.WriteLine("about");
                    sw.WriteLine("me");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        public static void ReadFile(string path)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";

                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //refer to ATM Lab with switch case and menu selection; 
        public static void Menu()
        {
            Console.WriteLine("1. Play Game? A strange game. The only winning move is not to play.\n" +
                "2. Exit\n" +
                "3. Admin Menu\n");
            //check if user input is within parameters given; source: StackExchange and Daily .NET Tips tried to be clever with ToInt64 and figure out that is (long) source: C# Corner
            //I'm certain this can be refactored into one line using different logic 
            int userSelection = Convert.ToInt32(Console.ReadLine());
            if (userSelection < 1 || userSelection > 3)

                switch (userSelection)
                //Console.Clear(); clears the console window; side note don't popular search engine Console.Clear() in it's entirety
                {
                    case 1:
                        Console.Clear();
                        PlayGame();
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                    case 3:
                        Console.Clear();
                        AdminMenu();
                        break;
                }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter either 1, 2, or 3");
                Menu();
            }
        }

        //Random word generator reference Cprogramming.com; Random.next method MSDOCS this was tough to understand but I just had to trust the DOCS and trial and lots of errors
        public static void PlayGame()
        {
            string[] 
        }


        public static void AdminMenu()
        {

        }
    }
}
