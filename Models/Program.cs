using System;




namespace CodingChallenge
{
  public class Program
  {
    public static void Main()
    {
      static void Play()
      {
        RockPaperScissors newScorer = new RockPaperScissors();
        string Answer = newScorer.Scorer();
        Console.WriteLine(value: Answer);
      }
      
      static void StringEqualsZero()
      {
        Console.WriteLine(value: "Enter a positive number");
        string? Response = Console.ReadLine();
        if(String.IsNullOrEmpty(value: Response)){
          Console.WriteLine(value: "Please Try again");
          StringEqualsZero();
        } else {
         Solution newSolution = new Solution();
          int nInPut = Int32.Parse(s: Response);
          int[] AnswerArray = newSolution.solution(N: nInPut);
          Console.WriteLine(value: AnswerArray.Count());
          int total = 0;
          for(int i = 0; i < AnswerArray.Length; i ++){
            Console.WriteLine(value: AnswerArray[i]);
            total += AnswerArray[i];
          }
          Console.WriteLine(value: "This is the total:");
          Console.WriteLine(value: total);
          Main();
        }
      }
      
      static void IsPositiveTwoDigit(){
        Console.WriteLine(value: "Enter a  number");
        string? Response = Console.ReadLine();
        if(String.IsNullOrEmpty(value: Response)){
          Console.WriteLine(value: "Please Try again");
          IsPositiveTwoDigit();
        } else {
        PositiveTwoDigit newPositiveTwoDigit = new PositiveTwoDigit();
          int ParsedAnswer = Int32.Parse(s: Response);
          bool IsPositive = newPositiveTwoDigit.IsTwoDigitPos(X: ParsedAnswer);
          Console.WriteLine(value: IsPositive);
        }
      }
      
      static void FindTens()
      {
        Console.WriteLine(value: "Enter a  number > 9");
        string? Response = Console.ReadLine();
        int ParsedAnswer = Int32.Parse(s: Response);
        if(String.IsNullOrEmpty(value: Response) || ParsedAnswer <= 9){
          Console.WriteLine(value: "Please Try again");
          FindTens();
        } else {
          FindTensPlace newTensPlace = new FindTensPlace();
          
          int Tens = newTensPlace.WhatsTheTens(X: ParsedAnswer);
          Console.WriteLine(value: Tens);
        }
      }
      
      static void SmallestIntNotInArray()
      {
         FindSmallestInt newSmallestInt = new FindSmallestInt();
          int Answer = newSmallestInt.SmallestNumber();
          int Answer2  = newSmallestInt.FasterSmallestNumber();
          Console.WriteLine(value: Answer);
          Console.WriteLine(value: Answer2);
      }
      
      
      Console.WriteLine(value: "Enter a number: 1 = Rock Paper Scissors, 2 = Make an Array that equals 0,  3 = Is my number positive and two digits, 4 = Return the tens place from inputted number, 5 = Find the smallest number not in an array, 6 = Exit");
      string? Response = Console.ReadLine();
       if(String.IsNullOrEmpty(value: Response)){
          Console.WriteLine(value: "Please Try again");
          Main();
        } else {
          if(Response.Contains(value: '1')){
            Play();
          } else if (Response.Contains(value: '2')){
            StringEqualsZero();
          } else if (Response.Contains(value: '3')){
            IsPositiveTwoDigit();
          } else if(Response.Contains(value: '4')){
            FindTens();
          } else if (Response.Contains(value: '5')){
            SmallestIntNotInArray();
          } else if (Response.Contains(value: '6') || Response.ToLower().Contains(value: "exit")){
            System.Environment.Exit(exitCode: 0);
            
      //   Console.WriteLine(value: "What number would you like to evaluate?");
      //   string? DigitAnswer = Console.ReadLine(); 
       
          // FormAList newFormAList = new FormAList();
          // int ParsedAnswer = Int32.Parse(s: Response);
          // int[] array = newFormAList.MakeTheList(N: ParsedAnswer);
          // int total = 0;
          // Console.WriteLine(value: array.Count());
          // for(int i = 0; i < array.Length; i ++){
          //   Console.WriteLine(value: array[i]);
          //   total += array[i];
          // }
          // Console.WriteLine(value: "This is the total:");
          // Console.WriteLine(value: total);
          
          
          
          
         
          
         
          
         
          
          
        }
      }
    }
  }
}