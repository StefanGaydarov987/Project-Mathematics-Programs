using QuickGraph;
using QuickGraph.Graphviz;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of p");
            var p = int.Parse(Console.ReadLine()); //We create the variable p
            Console.WriteLine("Enter value of coefficient in front of x^n");
            var k = int.Parse(Console.ReadLine()); //We create a coefficient in front of x^n
            Console.WriteLine("Enter value of constant term of the function");
            var d = int.Parse(Console.ReadLine()); //We create a constant term
            Console.WriteLine("Enter value of power of n in x^n");
            var n = int.Parse(Console.ReadLine()); //We create a variable, which is going to be the power of x in kx^n 
            Dictionary<int, int> dict = new Dictionary<int, int>(); //We create dictionary, which is going to contain all the relations between the numbers in the set Z/pZ
            for (var i = 0; i < p; i++)
            {
                int q = (int)(k * Math.Pow(i, n)+d); //This line creates the function, from which the program generates the graph
                dict.Add(i, q % p); 
            }
            Console.WriteLine("Copy the result you are going to get after this line and paste it next to https://quickchart.io/graphviz?graph");
            Console.WriteLine("digraph G {");//From this line until the end is just typing the result in a way, which can be understood by the engine QuickChart and create the image of the graph
            for (var i = 0; i < p; i++)
            {
                Console.WriteLine("{0} ;", i);
            }
            for (var i = 0; i < p; i++)
            {
                Console.WriteLine("{0} -> {1} [];", i, dict.ElementAt(i).Value);
            }
            Console.WriteLine("}");
        }
    }
}
