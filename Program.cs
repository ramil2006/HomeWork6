using HomeWork6;
string userName;
string password;

Console.WriteLine("Istifadeci adini daxil edin:");
userName = Console.ReadLine();

Console.WriteLine("Sifreni daxil edin:");
password = Console.ReadLine();

User user = new User(userName, password);

Console.WriteLine($"{user.UserName} {user.Password}");




