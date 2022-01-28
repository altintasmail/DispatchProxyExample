using DispatchProxyTest.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchProxyTest.CrossCuttingConcerns
{
    public interface ICacheService
    {
        void After();
        void Before();
    }
    public class CacheService : ICacheService
    {
        public void After()
        {
            Console.WriteLine("Cache After");
        }

        public void Before()
        {
            Console.WriteLine("Cache Before");
        }
    }
}
