using System;

class Hello{
    static void Main(string [] args){
        DateTime today = DateTime.Now;

        Console.WriteLine("I wrote my first c# program at: " + today.ToString());
        string msg = "You wanted to say hello to ";

        if(args.Length > 0){
            for(int index = 0; index <= args.Length; index++){
                msg += args[index] + "  ";
            }
            Console.WriteLine(msg)
        }
    }
}