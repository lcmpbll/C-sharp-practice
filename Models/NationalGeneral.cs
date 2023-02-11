namespace CodingChallenge 
{
  class Solution {
    public int[] solution(int N) {
        int[]AnswerArray = new int [N];
        if(N ==1){
            return AnswerArray;
        }
        for(int i = 0; i < N; i += 2){
            if(N % 2 == 1 && i == 0){
                AnswerArray[0] = 0;
                AnswerArray[1] = -1;
                AnswerArray[2] = 1;
                i += 1;
            } else if ( i == 0 ){
                AnswerArray[i] = -N;
                AnswerArray[i + 1] = N;
            } else {
                AnswerArray[i] = -i;
                AnswerArray[i + 1] = i;
            }
        }
        return AnswerArray;
    }
  }
}