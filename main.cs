using System;

class Program {
  public static void Main (string[] args) {
    //DECLARE VARIBLES
    string userInput;
    string num;
    int intnum;
    Random rng = new Random();

    int ran1 = 0;
    int ran2 = 0;
    int point=0;

  //INTRODUCE USER TO PROGRAM
    Console.WriteLine("\t\t\t\tWELCOME TO VEER'S MATH LESSON. \n\n\t\t\t\tTODAY WE WILL BE LEARNING ABOUT ADDING NUMBERS!\nYAY!");
  
  //ASK USER FOR THEIR FAVORITE OF SOMETHING TO MAKE THE CODE MORE INTRESTING TO THE USER
    Console.Write("Start by entering your favorite kind of fruit (plural)\n>");
    userInput = Console.ReadLine();

    //ASSIGN RANDOM NUMBER BETWEEN 10 AND 99
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    int sum;
    
    //ASK FIRST QUESTION
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and your mother comes in with "+ran2+" more, how many do you have total?");
    num = Console.ReadLine();
    
    //PARSE USER INPUT INTO A NUMBER
    intnum = int.Parse(num);
    //ADD 2 RANDOM NUMBERS
    sum = ran1+ran2;


    //IF USER INPUT FOR ANSWER IS EQUAL TO THE ANSWER, GIVE THE USER A POINT, IF THEY ARE WRONG, TAKE AWAY A POINT
    //CHANGE COLORS DEPENDING ON IF THEY GOT CODE CORRECT OR INCORRECT
    if(intnum==sum)
    {

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point(s)!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nYou now how "+point+" points!");
    

    //NEXT QUESTION---2
    
    Console.WriteLine("Start by entering your favorite kind of car (plural)\n>");
    userInput = Console.ReadLine();

    
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and you win "+ran2+" more, how many do you have total?");
    num = Console.ReadLine();
    

    intnum = int.Parse(num);
    sum = ran1+ran2;

    if(intnum==sum)
    {

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nYou now how "+point+" points!");
    

    //NEXT QUESTION --3
    Console.WriteLine("Start by entering your favorite kind of phone (plural)\n>");
    userInput = Console.ReadLine();

    
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and you get "+ran2+" more, how many do you have total?");
    num = Console.ReadLine();
    

    intnum = int.Parse(num);
    sum = ran1+ran2;

    if(intnum==sum)
    {

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nYou now have "+point+" points!");
    
   //NEXT QUESTION --4
    Console.WriteLine("Start by entering your favorite kind of junk food (plural)\n>");
    userInput = Console.ReadLine();

    
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and your uncle gets "+ran2+" more from the store, how many do you have total?");
    num = Console.ReadLine();
    

    intnum = int.Parse(num);
    sum = ran1+ran2;
    if(intnum==sum)
    {

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nYou now have "+point+" points!");


     //NEXT QUESTION --5
     Console.WriteLine("Start by entering your favorite kind of candy (plural)\n>");
    userInput = Console.ReadLine();

    
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and you win "+ran2+" more from a game, how many do you have total?");
    num = Console.ReadLine();
    

    intnum = int.Parse(num);
    sum = ran1+ran2;

    if(intnum==sum)
    {

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nYou now have "+point+" points!");

     //NEXT QUESTION --6
     Console.WriteLine("Start by entering your favorite kind of flower (plural)\n>");
    userInput = Console.ReadLine();

    
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and you get "+ran2+" more, how many do you have total?");
    num = Console.ReadLine();
    

    intnum = int.Parse(num);
    sum = ran1+ran2;

    if(intnum==sum)
    {

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nYou now have "+point+" points!");


     //NEXT QUESTION --7
     Console.WriteLine("Start by entering your favorite toy (plural)\n>");
    userInput = Console.ReadLine();

    
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and you get "+ran2+" more, how many do you have total?");
    num = Console.ReadLine();
    

    intnum = int.Parse(num);
    sum = ran1+ran2;

    if(intnum==sum)
    {

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nYou now have "+point+" points!");

     //NEXT QUESTION --8
     Console.WriteLine("Start by entering your favorite kind of shoes (plural)\n>");
    userInput = Console.ReadLine();

    
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and you get "+ran2+" more, how many do you have total?");
    num = Console.ReadLine();
    

    intnum = int.Parse(num);
    sum = ran1+ran2;

    if(intnum==sum)
    {

    Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nYou now have "+point+" points!");

     //NEXT QUESTION --9
     Console.WriteLine("Start by entering your favorite kind of letter (plural)\n>");
    userInput = Console.ReadLine();

    
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and you get "+ran2+" more, how many do you have total?");
    num = Console.ReadLine();
    

    intnum = int.Parse(num);
    sum = ran1+ran2;

    if(intnum==sum)
    {

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nYou now have "+point+" points!");

     //NEXT QUESTION --10
     Console.WriteLine("Start by entering your favorite kind of headphones (plural)\n>");
    userInput = Console.ReadLine();

    
    ran1= rng.Next(10,99);
    ran2 = rng.Next(10,99);
    
    Console.WriteLine ("\t\t\t\tHERE IS YOUR QUESTION. GOOD LUCK! \n \nIf there are "+ran1+" "+userInput+" and you get "+ran2+" more, how many do you have total?");
    num = Console.ReadLine();
    

    intnum = int.Parse(num);
    sum = ran1+ran2;

    if(intnum==sum)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreat Job! You are so smart! You get a point!");
      point++;
      
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nAw man nice try. Maybe next time");
      point--;
    }
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nCONGRATS THE GAME IS NOW OVER. I HOPED YOU LEARNED SOMETHING NEW, OR GOT PRACTICE ON HOW TO ADD NUMBERS USING YOUR FAVORITE THINGS! YOUR FINAL AMOUNT OF POINTS IS "+point+"! \n SEE YOU AGAIN NEXT TIME. BYE!");


  }
}
