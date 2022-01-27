using System;
class Program
{
    static void Main()
    {  
        Console.WriteLine("Roach-Foot-Nuke. Choose 1-4.");
        Console.WriteLine("1) Cockroach 2) Foot 3) Nuke 4) Exit");
        string input = Console.ReadLine(); int user = Convert.ToInt32(input);
        switch (user) 
        {
            case 1: Console.Write("Cockroach! "); break;
            case 2: Console.Write("Foot! "); break;
            case 3: Console.Write("Nuke! "); break;
            case 4: Environment.Exit(1); break; 
            default: Console.WriteLine("Invalid input: " + input + ", should be 'int' from range '1-4' "); Main(); break;
        }

        Console.Write("Tietokone valitsi: ");
        int winner = WinCalc(user, CPUChoice());

        switch (winner)
        {
            case 0: Console.Write("Tie!"); break;
            case 1: Console.Write("Player wins!"); break;
            case 2: Console.Write("CPU Wins!"); break;
        }
        Console.WriteLine("\n");Main();
    }
    static int WinCalc(int player,int CPU)
    {
        int winner = 99; // 99 indicates an unaccounted for result 

        if (CPU == player) {  winner = 0; }

        if (player == 1)
        {
            if (CPU == 2) { winner = 2; }
            if (CPU == 3) { winner = 1; }
        }

        if (player == 2)
        {
            if (CPU == 1) { winner = 1; }
            if (CPU == 3) { winner = 2; }
        }

        if (player == 3)
        {
            if (CPU == 1) { winner = 2; }
            if (CPU == 2) { winner = 1; }
        }
        return winner; // winner 0 for tie, winner 1 for player, winner 2 for CPU 
    }
    static int CPUChoice()
    {
        Random random = new Random();int computer = random.Next(1, 4); 
        switch (computer) 
        { 
            case 1: Console.Write("Cockroach. "); break;
            case 2: Console.Write("Foot. "); break;
            case 3: Console.Write("Nuke. "); break;
        }
        return computer;
    }
}
