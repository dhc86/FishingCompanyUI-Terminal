using System;
using System.Collections.Generic;
using System.Diagnostics;
 
public class FisshingCompany
{




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

    // Console.WriteLine(TUNA);
    // Console.WriteLine(SALMON);
    // Console.WriteLine(EMPTY);
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
    Console.WriteLine("\n");

    Console.Write("Lets start fishig!, as you can see you will need to select a Tile Number and a Depth\nEnter depth (0-3): ");
    int depth = int.Parse(Console.ReadLine());
    Console.Write("Enter Tile you want to go (0-9): ");
    int tile = int.Parse(Console.ReadLine());

    //notes: depth is 0,1,2,3 and tiles goes from 0 to 9.
    Console.WriteLine("This is what you got: " + BOARD[depth,tile] +"\n");

    // Debug.Indent();






  }
}
