// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;

Console.WriteLine("Welcome to Russian Roulette...");
Console.WriteLine("Choose a letter to see if there's a bullet or not");
Console.WriteLine("Pray you survive friend...");

bool A = true;
bool B = true;
bool C = false;
bool D = true;
bool E = false; 


Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
Console.WriteLine(D);
Console.WriteLine(E);


A = bool.Parse(Console.ReadLine());
Console.WriteLine("R.I.P");
B = bool.Parse(Console.ReadLine());
Console.WriteLine("R.I.P");
C = bool.Parse(Console.ReadLine());
Console.WriteLine("Safe");
D = bool.Parse(Console.ReadLine());
Console.WriteLine("R.I.P");
E = bool.Parse(Console.ReadLine());
Console.WriteLine("Safe");

if (A = true);