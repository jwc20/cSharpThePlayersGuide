Console.WriteLine("Provinces: ");
int provinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Duchies: ");
int duchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Estates: ");
int estates = Convert.ToInt32(Console.ReadLine());

int score = (estates) + (3 * duchies) + (6 * provinces);


Console.WriteLine(score);