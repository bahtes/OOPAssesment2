namespace CMP1903M_A02_2223
{
    class ReadFile: FileInfo  //ReadFile class inherits from FileInfo class
    {
        public static void read()  //Read method
        {
            string[] lines = {};
            try  //Try catch block to catch any exceptions thrown by the program
            {
                lines = System.IO.File.ReadAllLines(getPath());  //Reads all lines from the file
                Messages.scoreBoard(lines);  //Calls the scoreBoard method in the Messages class
            }
            catch (System.IO.FileNotFoundException)  //Catches the exception thrown if the file is not found
            {
                Messages.fileNotFound();  //Call the fileNotFound method in the Messages class
            }
        }
    }
}