using System;
using System.IO;

namespace Lab03System.IO
{
    public class Program

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

    {
        public static void Main(string[] args)
        {
            //string path = "../../../guesswords.txt";
            Console.WriteLine("Shall we play a game?");
            Console.WriteLine("==========");
            //CreateFile(path);
            //Menu();
        }

        //   /// <summary>
        //   /// Create fie path as a dependency and not in the 
        //   /// </summary>
        //   /// <param name="path"></param>
        //   static void CreateFile(string path)
        //   {
        //       //Defensive programming

        //           //this is a using statement and not a using directive like at the top of the page; allows us to open connection to a database of file and closes when it gets to the bottom of the closing curly brace; closes stream. non-closed streams cause security leaks
        //           using (StreamWriter sw = new StreamWriter(path))
        //           {
        //               try
        //               {
        //                   sw.WriteLine("bus");
        //                   sw.WriteLine("mall");
        //                   sw.WriteLine("salmon");
        //                   sw.WriteLine("cookies");
        //                   sw.WriteLine("about");
        //                   sw.WriteLine("me");
        //               }
        //               catch (Exception)
        //               {
        //                   throw;
        //               }
        //               finally
        //               {
        //                   sw.Close();
        //               }
        //           }
        //   }

        //   static void ReadFile(string path)
        //   {
        //       try
        //       {
        //           using (StreamReader sr = File.OpenText(path))
        //           {
        //               string s = "";

        //               while ((s = sr.ReadLine()) != null)
        //               {
        //                   Console.WriteLine(s);
        //               }
        //           }
        //       }
        //       catch (Exception)
        //       {

        //           throw;
        //       }
        //   }
        //}
    }
}
    //public static void Menu()
    //{
    //    Console.WriteLine("1. Play Game? A strange game. The only winning move is not to play.\n" +
    //        "2. Admin Menu\n" +
    //        "3. Exit\n");
    //    int userSelection = int.Parse(Console.ReadLine());
    //}


