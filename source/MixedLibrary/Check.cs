namespace MixedLibrary
{
    public class Check
    {
        // Method checks for a valid number! If num valid but negative, it´s converted into positive!
        // else Method returns -1 !
        public static int CheckValidNumber(string inputString)
        {
            bool validNumber = false;
            validNumber = int.TryParse(inputString, out int validadedNumber);

            if (validNumber)
            {
                return Math.Abs(validadedNumber);
            }
            else
            {
                return -1;
            }
        }
    }
}