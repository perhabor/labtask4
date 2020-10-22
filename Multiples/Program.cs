namespace MultipleNumber
{
    public class Multiple
    { 
         public Multiple(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
        public bool MultipleNumber()
        {
            if (FirstNumber == 0)
            {
                return SecondNumber;
            }
            else
            {
                return false;
            }
        }

    }
}