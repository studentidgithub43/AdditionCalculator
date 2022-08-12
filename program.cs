class Program{
static void Main(string[] args){
Console.WriteLine("Addition Calculator");

Console.Write("Enter the first number: ");
int a = Convert.Int32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.Int32(Console.ReadLine());
int result = a + b;

Console.WriteLine("The total is: " + result);
Console.Read();
}
}
