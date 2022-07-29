using System;
using System.Diagnostics;

namespace StormIsComing



    

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================== \nStorm thunder/distance calculator\n==================================\n\nCoded by Badea Andrei\n----------------------  \n \nPress space when you see the lightning and space again when you hear the thunder.\n");
            
            Console.WriteLine("Please press space to start counting or press esc to exit");
            Stopwatch timer = new Stopwatch();


            while (true)
                {

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Escape:
                            Console.WriteLine($"EEscape pressed");
                            return;

                            break;


                        case ConsoleKey.Spacebar:
                            timer.Start();


                        Console.WriteLine("Started timer");
                            Console.WriteLine("Press space to stop timer:");

                            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                            {
                                timer.Stop();

                            double miliseconds = Convert.ToDouble(timer.ElapsedMilliseconds);
                            StormDistanceCalculaor.CalculateDistance(miliseconds); //Distance calculator method, returns meters
                            
                            StormDistanceCalculaor.MessageByDistance(miliseconds);  //Messaging method, return strings

                            Console.WriteLine(StormDistanceCalculaor.MessageByDistance(miliseconds));


                            timer.Reset();
                                if (timer.ElapsedMilliseconds > 10000.000)
                                {
                                    Console.WriteLine("Timeout");
                                    return;
                                }

                               
                                
                            }
                            Console.WriteLine("Please press space to start counting!");
                            break;
                             default:
                            Console.WriteLine("Invalid key entered");
                            break;






                    }

                }
            
           



























        }
    }
}