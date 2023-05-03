namespace CMP1903M_A02_2223
{
    class CheckIfDigits
    {
        public static bool check(string input)
        {
            foreach(char a in input)
            {
                if (!char.IsDigit(a))
                {
                    return false;
                }
            }
            return true;
        }
    }
}