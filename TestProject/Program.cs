// See https://aka.ms/new-console-template for more information
using NourNumberSystem;
using NourNumberSystem.Moodle;

Console.WriteLine("---- From BINARY ----");
Base b = new BinarySystem("1010");
var binary = b.To(NumberBase.BINARY);
var Octal = b.To(NumberBase.Octal);
var dec = b.To(NumberBase.Decimal);
var Hexadecimal = b.To(NumberBase.Hexadecimal);


Console.WriteLine($"({b.Value})({(int)NumberBase.BINARY}) = ({binary}){(int)NumberBase.BINARY}");
Console.WriteLine($"({b.Value})({(int)NumberBase.BINARY}) = ({Octal}){(int)NumberBase.Octal}");
Console.WriteLine($"({b.Value})({(int)NumberBase.BINARY}) = ({dec}){(int)NumberBase.Decimal}");
Console.WriteLine($"({b.Value})({(int)NumberBase.BINARY}) = ({Hexadecimal}){(int)NumberBase.Hexadecimal}");

Console.WriteLine("---- From Octal ----");

b = new OctalSystem("12");
binary = b.To(NumberBase.BINARY);
Octal = b.To(NumberBase.Octal);
dec = b.To(NumberBase.Decimal);
Hexadecimal = b.To(NumberBase.Hexadecimal);

Console.WriteLine($"({b.Value})({(int)NumberBase.Octal}) = ({binary}){(int)NumberBase.BINARY}");
Console.WriteLine($"({b.Value})({(int)NumberBase.Octal}) = ({Octal}){(int)NumberBase.Octal}");
Console.WriteLine($"({b.Value})({(int)NumberBase.Octal}) = ({dec}){(int)NumberBase.Decimal}");
Console.WriteLine($"({b.Value})({(int)NumberBase.Octal}) = ({Hexadecimal}){(int)NumberBase.Hexadecimal}");

Console.WriteLine("---- From Decimal ----");

b = new DecimalSystem("10");
binary = b.To(NumberBase.BINARY);
Octal = b.To(NumberBase.Octal);
dec = b.To(NumberBase.Decimal);
Hexadecimal = b.To(NumberBase.Hexadecimal);


Console.WriteLine($"({b.Value})({(int)NumberBase.Decimal}) = ({binary}){(int)NumberBase.BINARY}");
Console.WriteLine($"({b.Value})({(int)NumberBase.Decimal}) = ({Octal}){(int)NumberBase.Octal}");
Console.WriteLine($"({b.Value})({(int)NumberBase.Decimal}) = ({dec}){(int)NumberBase.Decimal}");
Console.WriteLine($"({b.Value})({(int)NumberBase.Decimal}) = ({Hexadecimal}){(int)NumberBase.Hexadecimal}");

Console.WriteLine("---- From HEXADECIMAL ----");


b = new Hexadecimal("A");
binary = b.To(NumberBase.BINARY);
var octal = b.To(NumberBase.Octal);
dec = b.To(NumberBase.Decimal);
var hexadecimal = b.To(NumberBase.Hexadecimal);

Console.WriteLine($"({b.Value})({(int)NumberBase.Hexadecimal}) = ({binary}){(int)NumberBase.BINARY}");
Console.WriteLine($"({b.Value})({(int)NumberBase.Hexadecimal}) = ({octal}){(int)NumberBase.Octal}");
Console.WriteLine($"({b.Value})({(int)NumberBase.Hexadecimal}) = ({dec}){(int)NumberBase.Decimal}");
Console.WriteLine($"({b.Value})({(int)NumberBase.Hexadecimal}) = ({hexadecimal}){(int)NumberBase.Hexadecimal}");