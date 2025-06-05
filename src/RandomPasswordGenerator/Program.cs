
var random = new Random();

var passwordLength = 10;

var buffer = new char[passwordLength];

for (var i = 0; i < passwordLength; i++)
    buffer[i] = (char)('a' + random.Next(0, 26));

var password = new string(buffer);

Console.WriteLine(password);
