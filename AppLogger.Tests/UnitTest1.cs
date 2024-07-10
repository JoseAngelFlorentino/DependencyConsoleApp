using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppLogger;
using System.Collections.Generic;
using System.Linq;

namespace AppLogger.Tests
{
    [TestClass]
    public class DependenciesTests
    {
        [TestMethod]
        public void TestDependenciesForA()
        {
            var dep = new Dependencies();
            dep.AddDirect("A", new List<string> { "B", "C" });
            dep.AddDirect("B", new List<string> { "C", "E" });
            dep.AddDirect("C", new List<string> { "G" });
            dep.AddDirect("D", new List<string> { "A", "F" });
            dep.AddDirect("E", new List<string> { "F" });
            dep.AddDirect("F", new List<string> { "H" });

            var result = dep.DependenciesFor("A");
            CollectionAssert.AreEquivalent(new List<string> { "B", "C", "E", "F", "G", "H" }, result);
        }

        [TestMethod]
        public void TestDependenciesForB()
        {
            var dep = new Dependencies();
            dep.AddDirect("A", new List<string> { "B", "C" });
            dep.AddDirect("B", new List<string> { "C", "E" });
            dep.AddDirect("C", new List<string> { "G" });
            dep.AddDirect("D", new List<string> { "A", "F" });
            dep.AddDirect("E", new List<string> { "F" });
            dep.AddDirect("F", new List<string> { "H" });

            var result = dep.DependenciesFor("B");
            CollectionAssert.AreEquivalent(new List<string> { "C", "E", "F", "G", "H" }, result);
        }

        [TestMethod]
        public void TestDependenciesForC()
        {
            var dep = new Dependencies();
            dep.AddDirect("A", new List<string> { "B", "C" });
            dep.AddDirect("B", new List<string> { "C", "E" });
            dep.AddDirect("C", new List<string> { "G" });
            dep.AddDirect("D", new List<string> { "A", "F" });
            dep.AddDirect("E", new List<string> { "F" });
            dep.AddDirect("F", new List<string> { "H" });

            var result = dep.DependenciesFor("C");
            CollectionAssert.AreEquivalent(new List<string> { "G" }, result);
        }

        // Añade pruebas similares para los otros métodos DependenciesFor según sea necesario...
    }
}


