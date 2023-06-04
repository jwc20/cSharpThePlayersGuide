/*
 * 1. int
 * 2. short 
 * 3. long 
 * 4. uint
 * 5. ushort 
 * 6. ulong 
 * 7. byte 
 * 8. sbyte
 * 9. char
 * 10. string
 * 11. float 
 * 12. double
 * 13. decimal 
 * 14. bool
 */


int n0 = 0;
short n1 = 1;
long n3 = 3_000_000_000;
uint n4 = 4;
ulong n5 = 5_000_000;
byte n6 = 255;
sbyte n7 = -100;

char alphaA = 'a';
string textString = "This is a string";

float n8 = 8.8888f;
double n9 = 9.9999;
decimal n10 = 10.10101010m;
bool truthyValue = true;

Console.WriteLine(n0);
Console.WriteLine(n1);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(n5);
Console.WriteLine(n6);
Console.WriteLine(n7);
Console.WriteLine(alphaA);
Console.WriteLine(textString);
Console.WriteLine(n8);
Console.WriteLine(n9);
Console.WriteLine(n10);
Console.WriteLine(truthyValue);

