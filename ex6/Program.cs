Console.Write("Your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "ivan")
{
  Console.WriteLine("Nice to see you again, Ivan!");
}
else
{
  Console.Write("Hello, ");
  Console.WriteLine(username);
}