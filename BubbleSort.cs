namespace CMP1903M_A02_2223
{
    class BubbleSort  //Class for the BubbleSort method
    {
        public static List<string> sort(List<int> sortingArray, List<string> strArray)  //Method for sorting the array
        {
            for (int i = 0; i < sortingArray.Count; i++)  //For loop for sorting the array
            {
                for (int j = 0; j < sortingArray.Count - 1; j++)  //For loop for sorting the array
                {
                    if (sortingArray[j] < sortingArray[j + 1])  //If statement for sorting the array in descending order
                    {
                        int temp = sortingArray[j];
                        string tempStr = strArray[j];
                        sortingArray[j] = sortingArray[j + 1];
                        strArray[j] = strArray[j + 1];
                        sortingArray[j + 1] = temp;
                        strArray[j + 1] = tempStr;
                    }
                }
            }
            return strArray;
        }
    }
}