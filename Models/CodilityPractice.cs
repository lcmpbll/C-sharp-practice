namespace CodingChallenge
{
  public class FindSmallestInt
  {
    public int SmallestNumber()
    {
      int[] A = new int [] {1, 3, 6, 5, 4, 1, 2};
      int Answer = 0;
      Array.Sort(array: A);
      for(int i = 1; i < A.Length + 1; i ++){
            if(Array.IndexOf(array: A, value: i) == -1){
                Answer = i;
                return Answer;
            }
        }
        return Answer;
    }
    
    public int FasterSmallestNumber()
    {
      int[] A = new int [] {1, 3, 6, 5, 4, 1, 2};
      int m = A.Max();
      
      if(m < 1)
      {
        return 1;
      }
      if(A.Length == 1)
      {
        if(A[0] == 1){
          return 2;
        }
        else
        {
          return 1;
        }
      }
      
      int[] l = new int [m];
      for(int i = 0; i < A.Length; i ++)
      {
        if(A[i] > 0)
        {
          if(l[A[i] -1] != 1)
          {
            l[A[i] - 1] = 1;
          }
        }
      }
      
      for(int i = 0; i < l.Length; i ++ )
      {
        if(l[i] == 0)
        {
          return i + 1;
        }
      }
      
      return m + 1;
      
      
      
      
      
      
      
    }
   
  }
}