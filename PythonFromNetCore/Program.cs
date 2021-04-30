using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;

namespace PythonFromNetCore
{
    class Program
    {
        private const string PYTHON_FILE_PATH = @"PythonFiles\sample.py";

        static void Main(string[] args)
        {
            ScriptRuntime py = Python.CreateRuntime();
            
            // Execute Script
            dynamic pySample = py.UseFile(PYTHON_FILE_PATH);
            
            // Execute function in script
            pySample.Greeting("Sergio");

            // Get result from function in script
            var name = pySample.GetName();
            Console.WriteLine($"Hello {name}");
        }
    }
}
