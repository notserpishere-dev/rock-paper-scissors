Random random = new Random();
bool play = true;
void game()
{
    int computer_selection = random.Next(1, 4);
    Console.WriteLine("Rock Paper Scissors made by notserpishere");
    Console.WriteLine("Write your move! (1 = Rock, 2 = Paper, 3 = Scissors, 4 = Exit) ");
    int player_selection = Convert.ToInt32(Console.ReadLine());
    if (player_selection == 1 && computer_selection == 1)
    {
        Console.WriteLine("You both chose Rock, it's a tie!");
    }
    else if (player_selection == 1 && computer_selection == 2)
    {
        Console.WriteLine("You lost, computer chose Paper!");
    }
    else if (player_selection == 1 && computer_selection == 3)
    {
        Console.WriteLine("You win, computer chose Scissors!");
    }
    else if (player_selection == 2 && computer_selection == 1)
    {
        Console.WriteLine("You win, computer chose Rock!");
    }
    else if (player_selection == 2 && computer_selection == 2)
    {
        Console.WriteLine("You both chose Paper, it's a tie!");
    }
    else if (player_selection == 2 && computer_selection == 3)
    {
        Console.WriteLine("You lost, computer chose Scissors!");
    }
    else if (player_selection == 3 && computer_selection == 1)
    {
        Console.WriteLine("You lost, computer chose Rock!");
    }
    else if (player_selection == 3 && computer_selection == 2)
    {
        Console.WriteLine("You win, computer chose Paper!");
    }
    else if (player_selection == 3 && computer_selection == 3)
    {
        Console.WriteLine("You both chose Scissors, it's a tie!");
    }
    else if (player_selection == 4)
    {
        play = false;
    }
    else
    {
        Console.WriteLine("Invalid option");
    }
}

while (play)
{
    game();
}
