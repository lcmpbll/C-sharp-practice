namespace CodingChallenge
{
  public class FindTensPlace
  {
    public int WhatsTheTens(int X) 
    {
      int Tens = (X % 10);
      return Tens;
    }
    
  }
}

// Explanation

// X and Y are whole numbers.
// X % Y finds the remainder after you divide X by Y.


// For example, 7 % 3, means divide 7 by 3 and determine what is left over (7 divided by 3 equals 2 and the remainder is 1). So, 7 % 3 equals 1.

 

// Question

// If X is a number. Which of the following will find the last digit of X?

// For example, the last digit of 1327 is 7.


// A)

// X % 2


// B)

// X % 3


// C)

// X % 5


// D)

// X % 10 <= Answer


// E)

// X % 100

 

