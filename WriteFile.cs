namespace CMP1903M_A02_2223
{
    class WriteFile: FileInfo
    {

        public static void write(string name, int score, int d)
        {
            var list = new List<string>();

            string[] lines = {};

            try  //Try catch for reading the file
            {
                lines = System.IO.File.ReadAllLines(getPath());
            }
            catch (System.IO.FileNotFoundException)
            {
                Messages.fileNotFound();
            }

            foreach (string line in lines)  //For loop for adding the lines to the list
            {
                list.Add(line);
            }

            var lineArr = new List<int>();  //List for the scores

            list.Add(name + ": " + score);  //Adds the name and score to the list

            foreach (string line in list)  //For loop for adding the scores to the list
            {
                String[] lineSplit = line.Split(": ");   
                lineArr.Add(int.Parse(lineSplit[1]));
            }

            BubbleSort.sort(lineArr, list);  //Calls the sort method in the BubbleSort class to sort the list

            System.IO.File.WriteAllLines(getPath(), list);  //Writes the list to the file
        }
    }
}