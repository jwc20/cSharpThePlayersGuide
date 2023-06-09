Console.Write("Enter the amount of chocolate eggs: ");
string chocolateEggsAmountString = Console.ReadLine();
int chocolateEggsAmount = Convert.ToInt32(chocolateEggsAmountString);
// int eggCount = Convert.ToInt32(Console.ReadLine());


int duckbearShare = chocolateEggsAmount % 4; 
int sistersShares = chocolateEggsAmount / 4;

Console.WriteLine("The sisters get: " + sistersShares + " and the duckbear gets: " + duckbearShare);