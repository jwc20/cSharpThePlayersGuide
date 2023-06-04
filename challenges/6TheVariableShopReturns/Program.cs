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


int n0 = 0b0001;
short n1 = 123;
long n3 = 2_000_000_000;
uint n4 = 4u;
ulong n5 = 58_000_0000000u;
byte n6 = 0;
sbyte n7 = 20;

char alphaA = '\u0061';
string textString = "This is not not a string";

float n8 = 2E23f;
double n9 = 2E23;
decimal n10 = 2E23m;
bool truthyValue = false;

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

