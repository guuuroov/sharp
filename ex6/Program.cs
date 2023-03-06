Console.Write("Your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "ivan")//tolower - переводит все введенные символы в нижний регистр
{
  Console.WriteLine("Nice to see you again, Ivan!");
}
else
{
  Console.Write("Hello, ");
  Console.WriteLine(username);
}