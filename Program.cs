Console.WriteLine("Enter number of rows");
String s = Console.ReadLine();
int row;
if (int.TryParse(s,out row)==false)
{
	row = 0; 
	Console.WriteLine("There is an exception!!! Enter only number!"); 
}
else { row = int.Parse(s);}
int col = 2 * row - 1;
for (int i = 1; i <= row; i++)
{
	for (int j = 1; j <= i - 1; j++)
	{
		Console.Write(' ');
	}
	for (int j = 1; j <= col + 1 - (2 * i - 1); j++)
	{
		Console.Write('*');
	}
	Console.WriteLine();
}
