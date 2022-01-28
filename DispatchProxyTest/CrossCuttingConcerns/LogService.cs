using DispatchProxyTest.Attributes;
using DispatchProxyTest.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchProxyTest.CrossCuttingConcerns
{
    public interface ILogService
    {
        void After();
        void Before();
    }
    public class LogService : ILogService
    {
        public void After()
        {
            Console.WriteLine("Log After");
        }

        public void Before()
        {
            Console.WriteLine("Log Before");
        }
    }
}
