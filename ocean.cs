using System;
using System.Collections.Generic;
using System.Diagnostics;
 
public class FishingCompany
{
  class Fish{

    public double value { get; set; } 
    public double weight { get; set; }
    public string name { get; set; }

    public Fish(){
      this.weight = 0;
      this.value = 0;
      this.name = "<No name yet>";
      numberOfFishes++;
    }

    public Fish(double value, double weight, string name){
      this.value = value;
      this.weight = weight;
      this.name = name;
    }

    static int numberOfFishes = 0;

    public static int getNumberOfFishes(){
      return numberOfFishes;
    }

    
    public string infoFishes(){
      return String.Format("\n You have found" + getNumberOfFishes() + " fishes today!");
    }
  }




  class Tuna:Fish {

    public bool sushiable { get; set; }

    public Tuna():base(){
      this.sushiable = true;
      numberOfTuna++;
    }

    public Tuna(double value, double weight, string name, bool sushiable):base(value, weight, name){
      this.sushiable = true;
    }

    static int numberOfTuna = 0;

    public static int getNumberOfTuna(){
      return numberOfTuna;
    }

    public string infoTuna(){
      return String.Format("\n You have found" + getNumberOfTuna() + " Tuna today!");
    }

    new public string infoFishes(){
      return String.Format("\n You have found " + getNumberOfFishes() + " fishes today!");
    }
  }


  class Salmon:Fish {
    public bool sushiable { get; set; }

    public Salmon():base(){
      this.sushiable = false;
      numberOfSalmon++;
    }

    public Salmon(double value, double weight, string name, bool sushiable):base(value, weight, name){
      this.sushiable = false;
    }

    static int numberOfSalmon = 0;

    public static int getNumberOfSalmon(){
      return numberOfSalmon;
    }

    public string infoSalmon(){
      return String.Format("\n You have found " + getNumberOfSalmon() + " Salmon today!");
    }

    new public string infoFishes(){
      return String.Format("\n You have found " + getNumberOfFishes() + " fishes today!");
    }
  }


  class Shark:Fish{

    public bool dangerous { set; get; }

    public Shark():base(){
      this.dangerous = true;
      numberOfShark++;
    } 

    public Shark(double value, double weight, string name, bool dangerous):base(value,weight,name){
      this.dangerous = true;
    }

    static int numberOfShark = 0;

    public static int getNumberOfShark(){
      return numberOfShark;
    }

    public string infoShark(){
      return String.Format("\n You have found " + getNumberOfShark() + " Sharks today!");
    }

    new public string infoFishes(){
      return String.Format("\n You have found " + getNumberOfFishes() + " fishes today!");
    }

  }

  static public void Main ()
  {
 
    // The board below represents the ocean. It's an array of array of strings (a 2 dimensional Array). Don't let the weird syntax confuse you. It's just a fancy way of defining an array of strings. Each depth is actual an array of strings. Each tile is either empty (~) or has fish: SALMON (S) or TUNA (T)

    string[,] BOARD = {{"~", "~", "~", "S", "~", "~", "~", "T", "S", "T"}, {"T", "T" ,"~", "~", "S", "~", "~", "S", "~", "~"}, {"S", "~", "~", "T", "~", "S", "~", "T", "~", "S"},{"~", "H", "~", "T", "~", "S", "~", "S", "~", "H"}};

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
    while((decision != "yes") && (decision != "no")){
      Console.Write("Please enter yes or no  ");
      decision = Console.ReadLine().ToLower();
    }
 


    while(decision == "yes"){ //--start while loop --

      Console.Write("\nLets start fishig!, as you can see you will need to select a Tile Number and a Depth\nEnter depth (0-3): ");
      int depth = int.Parse(Console.ReadLine());
      // Console.WriteLine("data type depth:     ----> " + depth.GetType());
      // Console.WriteLine("data type 10:     ----> " + 10.GetType());
      // while(depth.GetType() == 10.GetType()){
      //   Console.WriteLine("data type :     ----> " + depth.GetType());
      //   Console.Write("Please enter a valid Tile NUMBER (0-9): ");
      //   depth = int.Parse(Console.ReadLine());
      // }
      while(depth > 3 || depth < 0){
        Console.Write("Please enter a valid value (0-3): ");
        depth = int.Parse(Console.ReadLine());
      }

      Console.Write("\nEnter Tile (0-9): ");
      int tile = int.Parse(Console.ReadLine());
      // while(depth.GetType() != 10.GetType()){
      //   // Console.WriteLine("data type :     ----> " + depth.GetType());
      //   Console.Write("Please enter a valid Tile NUMBER (0-9): ");
      //   tile = int.Parse(Console.ReadLine());
      // }
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
          Tuna tunaFish = new Tuna();
          tunaFish = new Tuna(10, 25, "Flipper", true);
          Console.Write(tunaFish.infoFishes());
          Console.Write(tunaFish.infoTuna());
          break;
        case "S":
          Console.WriteLine("You got SALMON in your basket");
          Salmon salmonFish = new Salmon();
          salmonFish = new Salmon(10, 25, "Flipper", false);
          Console.Write(salmonFish.infoFishes());
          Console.Write(salmonFish.infoSalmon());
          break;
        case "H":
          Console.WriteLine("You got SHARK in your basket");
          Shark sharkFish = new Shark();
          sharkFish = new Shark(10, 25, "Flipper", false);
          Console.Write(sharkFish.infoFishes());
          Console.Write(sharkFish.infoShark());
          break;
        default:
          Console.WriteLine("You got NOTHING, sorry. Try again!");
          break;
      }


      Console.Write("\nWould you like to keep fishing?   ");
      decision = Console.ReadLine().ToLower();
      while((decision != "yes") && (decision != "no")){
        Console.Write("Please enter yes or no  ");
        decision = Console.ReadLine().ToLower();
      }

    } //-- END while loop --

    

    






  }
}
