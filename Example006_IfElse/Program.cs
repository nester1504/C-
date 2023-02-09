Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "саша")
{
  Console.WriteLine("Ура! Это Саша ");  
}
else
{
    Console.WriteLine("Привет " + username);
}