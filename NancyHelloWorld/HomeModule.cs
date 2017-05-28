using System;
using Nancy;

namespace NancyHelloWorld
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Console.WriteLine("Starting module");
            Get("/", args => "Hello World, it's Nancy on .NET Core");
        }
    }
}
