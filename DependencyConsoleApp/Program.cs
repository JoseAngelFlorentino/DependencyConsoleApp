using System;
using System.Collections.Generic;
using AppLogger;

namespace DependencyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dep = new Dependencies();
            dep.AddDirect("A", new List<string> { "B", "C" });
            dep.AddDirect("B", new List<string> { "C", "E" });
            dep.AddDirect("C", new List<string> { "G" });
            dep.AddDirect("D", new List<string> { "A", "F" });
            dep.AddDirect("E", new List<string> { "F" });
            dep.AddDirect("F", new List<string> { "H" });

            Console.WriteLine("Dependencies for A: " + string.Join(", ", dep.DependenciesFor("A"))); // Output: B, C, E, F, G, H
            Console.WriteLine("Dependencies for B: " + string.Join(", ", dep.DependenciesFor("B"))); // Output: C, E, F, G, H
            Console.WriteLine("Dependencies for C: " + string.Join(", ", dep.DependenciesFor("C"))); // Output: G
            Console.WriteLine("Dependencies for D: " + string.Join(", ", dep.DependenciesFor("D"))); // Output: A, B, C, E, F, G, H
            Console.WriteLine("Dependencies for E: " + string.Join(", ", dep.DependenciesFor("E"))); // Output: F, H
            Console.WriteLine("Dependencies for F: " + string.Join(", ", dep.DependenciesFor("F"))); // Output: H
        }
    }
}

