namespace CodingChallenge 
{
  public class PositiveTwoDigit
  {
    public bool IsTwoDigitPos(int X)
    {
      if(X > 9 &&  X <= 99){
        return true;
      } else {
        return false;
      }
    }
  }
}

// Explanation

// X <= Y checks whether X is less than, or equal to, Y. 

 

// Question

// Which of the following checks whether X is a positive two-digit number?


// A)

// X < 100


// B)

// X // 10 > 0


// C)

// X > 10 and X < 100


// D)

// X > 9 and X <= 99


// E)

// X >= 10 and X <= 100