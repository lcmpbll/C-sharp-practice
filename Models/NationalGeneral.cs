namespace CodingChallenge 
{
  class Solution {
    public int[] solution(int N) {
        int[]answerArray = new int [N];
        if(N ==1){
            return answerArray;
        }
        for(int i = 0; i < N; i += 2){
            if(N % 2 == 1 && i == 0){
                answerArray[0] = 0;
                answerArray[1] = -1;
                answerArray[2] = 1;
                i += 1;
            } else if ( i == 0 ){
                answerArray[i] = -N;
                answerArray[i + 1] = N;
            } else {
                answerArray[i] = -i;
                answerArray[i + 1] = i;
            }
        }
        return answerArray;
    }
  }
}