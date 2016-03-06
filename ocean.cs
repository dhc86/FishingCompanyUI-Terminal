using System;
using System.Collections.Generic;
using System.Diagnostics;
 
public class FishingCompany
{
  class Fish{

    public double weight { get; set; }
    public double value { get; set; } 

    public Fish(){
      this.weight = 0;
      this.value = 0;
      numberOfFishes++;
    }

    public Fish(double value = 0, double weight = 0){
      this.value = value;
      this.weight = weight;
      numberOfFishes++;
    }

    static int numberOfFishes = 0;

    public static int getNumberOfFishes(){
      return numberOfFishes;
    }

    
    public string infoFishes(){
      return String.Format("\n You have found" + getNumberOfFishes() + " fishes today!");
    }
  }


  static public void Main ()
  {
    
    string TUNA   = "T";
    string SALMON = "S";
    string EMPTY  = "~";

    // The board below represents the ocean. It's an array of array of strings (a 2 dimensional Array). Don't let the weird syntax confuse you. It's just a fancy way of defining an array of strings. Each depth is actual an array of strings. Each tile is either empty (~) or has fish: SALMON (S) or TUNA (T)

    string[,] BOARD = {{"~", "~", "~", "S", "~", "~", "~", "T", "S", "T"}, {"T", "T" ,"~", "~", "S", "~", "~", "S", "~", "~"}, {"S", "~", "~", "T", "~", "S", "~", "T", "~", "S"},{"~", "~", "~", "T", "~", "S", "~", "S", "~", "~"}};

    //this represents the array but for visualization purposes strings do not have qualtations.

    //   0 1 2 3 4 5 6 7 8 9   # Tile Number
    // {"~ ~ ~ S ~ ~ ~ T S T"}, // Depth of -500
    // {"T T ~ ~ S ~ ~ S ~ ~"}, // Depth of -1000
    // {"S ~ ~ T ~ S ~ T ~ S"}, // Depth of -1500
    // {"~ ~ ~ T ~ S ~ S ~ ~"}  // Depth of -2000
    //}
    // => => Forward direction => =>

    Console.WriteLine("\n============   @Welcome to Fishing Company (FC™)   ============\n\nThe  Fishing Company (FC™) has invented a new form of fishing: Underwater fishing!!! ZOMG!\nOur new protoype deep sea vessel (The DEEP-FISHR-9000) needs to be deployed ASAP... \nWhy you ask? Because the ocean is running out of fish and we need to take deep sea fishing to a whole new level baby!\n\n");
 
    Console.WriteLine("This is the array representing the ocean:\n");
    Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9   -> Tile Number");

    int deep = 0;
    for(int x = 0; x < BOARD.GetLength(0); x++ ){
      for (int y = 0; y < BOARD.GetLength(1); y++ ){
        Console.Write(" " + BOARD[x,y]);

      }
      deep = deep + 500;
      Console.Write("   -> Depth of -"+ deep);
      Console.WriteLine("");
    }

    Console.Write("\nWould you like to start the game?  ");
    string decision = Console.ReadLine().ToLower();

    while(decision == "yes"){ //--start while loop --

      Console.Write("\nLets start fishig!, as you can see you will need to select a Tile Number and a Depth\nEnter depth (0-3): ");
      int depth = int.Parse(Console.ReadLine());
      while(depth > 3 || depth < 0){
        Console.Write("Please enter a valid value (0-3): ");
        depth = int.Parse(Console.ReadLine());
      }

      Console.Write("\nEnter Tile (0-9): ");
      int tile = int.Parse(Console.ReadLine());
      while(tile > 9 || depth < 0){
        Console.Write("Please enter a valid Tile (0-9): ");
        tile = int.Parse(Console.ReadLine());
      }

      string result = BOARD[depth,tile];
      //notes: depth is 0,1,2,3 and tiles goes from 0 to 9.
      Console.WriteLine("This is what you got: " + result +"\n");

      switch (result){
        case "T":
          Console.WriteLine("You got TUNA in your basket!");
          break;
        case "S":
          Console.WriteLine("You got SALMON in your basket");
          break;
        default:
          Console.WriteLine("You got NOTHING, sorry. Try again!");
          break;
      }


      Console.Write("\nWould you like to keep fishing?   ");
      decision = Console.ReadLine().ToLower();
    } //-- END while loop --

    

    






  }
}
