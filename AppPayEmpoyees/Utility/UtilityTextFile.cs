using System;
using System.IO;

namespace AppPayEmpoyees.Utility
{
    class UtilityTextFile
    {
        //METHOD FOR READ TEXT FILE
        public String ReadTextFileData()
        {
            try
            {
                String file = "";
                String result = "";

                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                string fileName = "fileData.txt";

                string pathFile = filePath + fileName;

                //Pass the file path and file name to the StreamReader constructor
                StreamReader reader = new StreamReader(pathFile);

                //Read the first line of text
                file = reader.ReadLine();

                //Continue to read until you reach end of file
                while (file != null)
                {
                    //write the lie to console window
                    //Console.WriteLine(file); ***

                    result += file;

                    //Read the next line
                    file = reader.ReadLine();
                }

                //close the file
                reader.Close();

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);

                return "";
            }
        }

        //METHOD FOR CREATE AND WRITE IN A TXT FILE 
        public void WriteTextFileData()
        {
            try
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                string fileName = "fileData.txt";

                string pathFile = filePath + fileName;

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter writer = new StreamWriter(pathFile);

                //Write a line of text
                writer.WriteLine("RENE=MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00-21:00;"); //The amount to pay RENE is: 215 USD
                writer.WriteLine("ASTRID=MO10:00-12:00,TH12:00-14:00,SU20:00-21:00;");
                writer.WriteLine("BOB=MO10:00-12:00;");
                writer.WriteLine("JOHN=TH12:00-14:00;");
                writer.WriteLine("EMILY=SU20:00-21:00,SA01:00-03:00");

                //Close the file
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
