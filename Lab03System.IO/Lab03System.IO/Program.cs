using System;
using System.IO;

namespace Lab03System.IO
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "../../../wordguess.txt";
            Console.WriteLine("Shall we play a game?");
            //using CreateFile creates the file in relative to the execution
            CreateFile(path);
            ReadFile(path);
            UpdateFile(path);
            DeleteLinesFromFile(path);


        }

        //create path to external file 
        //using try catch to prevent memory leaks to close out connections put in resourse
        //use StreamWriter to write to a file
        
        static void CreateFile(string path)
        {
            
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    try
                    {
                        sw.Write("");
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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //close the file

            }
        }

        static void ReadFile(string path)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string[] guessWords = File.ReadAllLines(path);

                    //while ((guessWords = sr.guessWords()) != null)
                    //{
                    //    Console.WriteLine(guessWords);
                    //}
                }
            }
            catch (Exception)
            {

                throw;
            } 
        }

        static void UpdateFile(string path)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        static void DeleteLinesFromFile(string path)
        {
            try
            {
                string[] currentGuessWords = ReadFile(path);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
