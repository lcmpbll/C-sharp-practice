namespace CodingChallenge
{
  public class FormAList
  {
    public int[] MakeTheList(int N)
    {
      List<int> answer = new List<int>();
      int endPoint = N;
      
       
     
      for(int i = 0; i < endPoint; i += 2 ){
        if(i == 0 && N > 2 && N % 2 == 1){
          answer.Add(item: 0);
          answer.Add( item: i + 1);
          answer.Add( item: -i - 1);
          endPoint -= 1;
        } else if (i == 0 && N == 1){
          answer.Add(item: 0);
          
        } else if(i == 0){
          answer.Add(item: N);
          answer.Add(item: -N);
        } else {
          answer.Add( item: i);
          answer.Add( item: -i);
        }
      }
      return answer.ToArray();
    }
  }
}


//Task description

// Write a function

// class Solution { public int[] solution(int N); }

// that, given an integer N (1 ≤ N ≤ 100), returns an array containing N unique integers that sum up to 0. The function can return any such array.

// For example, given N = 4, the function could return [1, 0, −3, 2] or [−2, 1, −4, 5]. The answer [1, −1, 1, 3] would be incorrect (because value 1 occurs twice). For N = 3 one of the possible answers is [−1, 0, 1] (but there are many more correct answers).