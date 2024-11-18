using System;
using System.IO;

public class StringSearchInFiles
{
    public void FindStringFiles(string folderPath, string searchString)
    {


        string[] files = Directory.GetFiles(folderPath);


        //here we loop to search the files
        foreach (string filePath in files)
        {
            // we read the content of the file
            string fileContent = File.ReadAllText(filePath);
            if (fileContent.Contains(searchString))
            {

                Console.WriteLine($"Present: {Path.GetFileName(filePath)}");
            }
            else
            {
                Console.WriteLine($"Absent: {Path.GetFileName(filePath)}");

            }
        }
    }


    public class Program
    {
        public static void Main()
        {
            //example search string in file
            string searchForString = "testing";
            string SearchfolderPath = @"C:\users\martins\desktop";  // put your directory name here
          

            StringSearchInFiles stringSearchfiles = new StringSearchInFiles();
            stringSearchfiles.FindStringFiles(SearchfolderPath, searchForString);
        }
    }
} 
