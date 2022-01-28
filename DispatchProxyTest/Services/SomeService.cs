using DispatchProxyTest.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchProxyTest.Services
{
    [Log]
    public interface ISomeService
    {
        [Validation]
        string Do(string message);
    }

    public class SomeService : ISomeService
    {
        public string Do(string message)
        {
            Console.WriteLine($"Do: {message}");
            return message;
        }
    }
}
