class Program{
  static void Main(string[] args){
    Console.WriteLine("Addition Calculator");

    Console.Write("Enter the first number: ");
    //     Change this variable name
    int first = Convert.Int32(Console.ReadLine());
    Console.Write("Enter the second number: ");
    //     Change this variable name
    int second = Convert.Int32(Console.ReadLine());
    int result = first + second;

    Console.WriteLine("The total is: " + result);
    Console.Read();
  }
}
