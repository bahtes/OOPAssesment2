namespace CMP1903M_A02_2223
{
    class FileInfo  //FileInfo class
    {
        private static string easyPath = "EasyScores.txt";  //Path for the easy scores file 

        private static string hardPath = "HardScores.txt";  //Path for the hard scores file 

        private static string path;  //this will be set to either easyPath or hardPath depending on the difficulty
        
        public static void setPath(int difficulty)  //Sets the path depending on the difficulty
        {
            if (difficulty == 1)
            {
                path = getEPath();
            }
            else
            {
                path = getHPath();
            }
        }

        public static string getPath()  //Returns the path
        {
            return path;
        }

        public static string getEPath()  //Returns the easy path
        {
            return easyPath;
        }

        public static void setEPath(string newPath)  //Sets the easy path
        {
            easyPath = newPath;
        }

        public static string getHPath()  //Returns the hard path
        {
            return hardPath;
        }

        public static void setHPath(string newPath)  //Sets the hard path
        {
            hardPath = newPath;
        }

        public static int getELength()  //Returns the length of the easy file
        {
            string[] lines = System.IO.File.ReadAllLines(easyPath);
            return lines.Length;
        }

        public static int getHLength()  //Returns the length of the hard file
        {
            string[] lines = System.IO.File.ReadAllLines(hardPath);
            return lines.Length;
        }
    }
}