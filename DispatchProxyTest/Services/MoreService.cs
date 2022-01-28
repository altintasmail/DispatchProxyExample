using DispatchProxyTest.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchProxyTest.Services
{
    [Log]
    public interface IMoreService
    {
        [Cache]
        string DoMore(string message);
    }

    public class MoreService : IMoreService
    {
        public string DoMore(string message)
        {
            Console.WriteLine($"DoMore: {message}");
            return message;
        }
    }
}
