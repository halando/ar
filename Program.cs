// See https://aka.ms/new-console-template for more information
using ar.Models;

Console.WriteLine("Hello, World!");

var elemek = new List<Pont> {
    new Pont(10,20),
    new Pont(20,30),
    new Pont(30,40),
    new Pont(50,60),
    new Pont(70,80),
    new Pont(90,100),
    new Pont(110,120),
    new Pont(120,130),



};
#endregion





Console.WriteLine(String.Join(", ", elemek));
//var vr = from i in elemek select i.X;
//var vu = elemek.Select(i => i.X);
var vr = from i in elemek select new{XX= 2*i.X,YY=2*i.Y};
var vu = elemek.Select(i => new { XX = 2 * i.X, YY = 2 * i.Y });

var nu = elemek.Where(i => i.X > 10).Select(i => i).OrderBy(i=>i.X).ThenBy(i=>i.Y).ToList();
foreach (var ele in vr)
    Console.Write(ele+",");
Console.WriteLine();
foreach (var ele in vu)
    Console.Write(ele+",");
Console.WriteLine("Nagyobb mint 10");
//foreach (var ele in nu)
  //  Console.Write(ele+",");



    
