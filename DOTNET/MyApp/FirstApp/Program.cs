using MyLibrary;

var name = args.Length > 0 ? args[0] : "World";

Console.WriteLine(Greeter.Hello(name));