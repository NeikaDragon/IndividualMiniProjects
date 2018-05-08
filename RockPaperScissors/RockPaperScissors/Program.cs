using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            int output; //storage for converted string
            Random r = new Random();


            string rock = "ROCK";
            string paper = "PAPER";
            string scissors = "SCISSORS";
            string choice;
            int userWin = 0;
            int pcWin = 0;
            int tie = 0;
            int userLoss = 0;
            int pcLoss = 0;



            //loop
            while (true)
            {
                Console.WriteLine("Welcome to the Rock, Paper, Scissors Game!");
                Console.WriteLine("Please choose how many rounds 1 - 10 that you would like to play.");
                string input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    if (output >= 1 && output <= 10)
                    {
                        Console.WriteLine($"{output}, Is the amount of rounds you have chosen to play.");



                    }
                    else
                    {
                        Console.WriteLine($"{output}, is not a valid entry goodbye.");
                        Console.ReadLine();
                        break;

                    }


                }
                for (int i = 1; i <= output; i++) 
                                                 
                                  
                                    
               
                {


                    int random = r.Next(1, 4);
                    Console.WriteLine("Please choose your weapon!  Rock,  Paper, Scissors");
                    choice = Console.ReadLine();
                    choice = choice.ToUpper();

                    switch (random)
                    {
                        case 1:
                            if (choice == rock)
                            {
                                Console.WriteLine(choice + " <-you vs. us-> " + rock + ".\n");
                                Console.WriteLine("Look's like it's a tie, try again!!");
                                tie++;
                                Console.WriteLine($"Player Wins = {userWin}, Player Losses = {userLoss}, PC Losses = {pcLoss}, PC Wins = {pcWin}, Game Ties = {tie}");
                                Console.WriteLine($"Round {i} of {output} done.");


                            }
                            else if (choice == paper)
                            {
                                Console.WriteLine(choice + " <-you vs. us-> " + rock + ".\n");
                                Console.WriteLine("You win!");
                                userWin++; pcLoss++;
                                Console.WriteLine($"Player Wins = {userWin}, Player Losses = {userLoss}, PC Losses = {pcLoss}, PC Wins = {pcWin}, Game Ties = {tie}");
                                Console.WriteLine($"Round {i} of {output} done.");
                            }
                            else if (choice == scissors)
                            {
                                Console.WriteLine(choice + " <-you vs. us-> " + rock + ".\n");
                                Console.WriteLine("You lose!, try again!!");
                                userLoss++; pcWin++;
                                Console.WriteLine($"Player Wins = {userWin}, Player Losses = {userLoss}, PC Losses = {pcLoss}, PC Wins = {pcWin}, Game Ties = {tie}");
                                Console.WriteLine($"Round {i} of {output} done.");
                            }
                            else
                            {
                                Console.WriteLine("That isn't a valid" + choice +"");
                            }
                            break;
                        case 2:
                            if (choice == paper)
                            {
                                Console.WriteLine(choice + " <-you vs. us-> " + paper + ".\n");
                                Console.WriteLine("Look's like it's a tie, try again!!");
                                tie++;
                                Console.WriteLine($"Player Wins = {userWin}, Player Losses = {userLoss}, PC Losses = {pcLoss}, PC Wins = {pcWin}, Game Ties = {tie}");
                                Console.WriteLine($"Round {i} of {output} done.");
                            }
                            else if (choice == scissors)
                            {
                                Console.WriteLine(choice + " <-you vs. us-> " + paper + ".\n");
                                Console.WriteLine("You win!");
                                userWin++; pcLoss++;
                                Console.WriteLine($"Player Wins = {userWin}, Player Losses = {userLoss}, PC Losses = {pcLoss}, PC Wins = {pcWin}, Game Ties = {tie}");
                                Console.WriteLine($"Round {i} of {output} done.");
                            }
                            else if (choice == rock)
                            {
                                Console.WriteLine(choice + " <-you vs. us-> " + paper + ".\n");
                                Console.WriteLine("You lose!, try again!!");
                                userLoss++; pcWin++;
                                Console.WriteLine($"Player Wins = {userWin}, Player Losses = {userLoss}, PC Losses = {pcLoss}, PC Wins = {pcWin}, Game Ties = {tie}");
                                Console.WriteLine($"Round {i} of {output} done.");
                            }
                            else
                            {
                                Console.WriteLine($"{choice}, is not a valid weapon! pick something else");
                            }
                            break;
                        case 3:
                             if (choice == rock)
                            {
                                Console.WriteLine(choice + " <-you vs. us-> " + scissors + ".\n");
                                Console.WriteLine("You win!");
                                userWin++; pcLoss++;
                                Console.WriteLine($"Player Wins = {userWin}, Player Losses = {userLoss}, PC Losses = {pcLoss}, PC Wins = {pcWin}, Game Ties = {tie}");
                                Console.WriteLine($"Round {i} of {output} done.");

                            }
                            else if (choice == scissors)
                            {
                                Console.WriteLine(choice + " <-you vs. us-> " + scissors + ".\n");
                                Console.WriteLine("Look's like it's a tie, try again!!");
                                tie++;
                                Console.WriteLine($"Player Wins = {userWin}, Player Losses = {userLoss}, PC Losses = {pcLoss}, PC Wins = {pcWin}, Game Ties = {tie}");
                                Console.WriteLine($"Round {i} of {output} done.");
                            }
                            else if (choice == paper)
                            {
                                Console.WriteLine(choice + " <-you vs. us-> " + scissors + ".\n");
                                Console.WriteLine("You lose!, try again!!");
                                userLoss++; pcWin++;
                                Console.WriteLine($"Player Wins = {userWin}, Player Losses = {userLoss}, PC Losses = {pcLoss}, PC Wins = {pcWin}, Game Ties = {tie}");
                                Console.WriteLine($"Round {i} of {output} done.");
                            }
                            else
                            {
                                Console.WriteLine("That isn't a valid" + choice + "");
                            }
                            break;
                            {






                              






                            }
                    }
                }
                while (true)
                {
                    if (userWin > pcWin && pcLoss > userLoss)
                    {
                        Console.WriteLine("You are the overall winner!");
                    }
                    else
                    {
                        Console.WriteLine("The PC is the overall winner!");
                    }
                    
                    Console.Write("Do you want to play again [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "N")
                        return; // Exit the Main-method.
                }
            }
        }
    }
}

