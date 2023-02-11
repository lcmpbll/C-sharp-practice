

namespace CodingChallenge
{
  public class RockPaperScissors
  {
    public string Scorer() 
    {
      List<string> computerPlay = new List<string> {"paper", "rock", "scissors", "paper", "rock", "paper", "paper" };
      List<string> playerPlay = new List<string> {"rock", "paper", "scissors"};
      string highestPlay = "";
      int highestScore = 0;
      int currentScore = 0;
      for(int i = 0; i < playerPlay.Count; i ++){
        for(int k = 0; k < computerPlay.Count; k ++){
          if(playerPlay[index: i] == computerPlay[index: k]){
            currentScore += 1;
          } else if(Equals(objA: playerPlay[index: i], objB: "rock") && Equals(objA: computerPlay[index: k], objB: "scissors")){
            currentScore += 2;
          } else if(Equals(objA: playerPlay[index: i], objB: "paper") && Equals(objA: computerPlay[index: k], objB: "rock")){
            currentScore += 2;
          } else if(Equals(objA: playerPlay[index: i], objB: "scissors") && Equals(objA: computerPlay[index: k], objB: "paper")){
            currentScore += 2;
          }
        }
        if(currentScore > highestScore){
          highestScore = currentScore;
          highestPlay = playerPlay[index: i];
        } 
      
      }
      return highestPlay;
    }
  }
}

// Explanation

// Two players are playing Rock Paper Scissors.

 

// The game consists of rounds. In each round, players simultaneously show one of the three symbols: rock, paper or scissors.

 

// Rock beats scissors, paper beats rock and scissors beats paper.

// If players show the same symbol then each of them earns 1 point.

// If players show different symbols then only the winner gets 2 points.

 

// Question

// The first player shows symbols "paper, rock, scissors, paper, rock, paper, paper" in that order. The second player wants to choose one symbol (rock, paper or scissors) and show that symbol throughout the whole game.

 

// What is the highest score that the second player can achieve?


// A)

// 4


// B)

// 8


// C) <= Answer scissors

// 9


// D)

// 10