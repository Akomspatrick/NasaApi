// See https://aka.ms/new-console-template for more information


using NasaLib;

Console.WriteLine("Starting the App....!");

var extreEdgeOfPlateau = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
var takeoffPoint =       Console.ReadLine().Trim();
var pathToTake =         Console.ReadLine().Trim();


Console.WriteLine( new Rover(takeoffPoint, new Plateau (  0,  0, extreEdgeOfPlateau[0],extreEdgeOfPlateau[1] )).Move(pathToTake).PresentLocation());
Console.WriteLine("sTOPPING the App....!");
