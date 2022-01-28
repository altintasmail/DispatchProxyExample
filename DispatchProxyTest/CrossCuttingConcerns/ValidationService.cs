using DispatchProxyTest.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchProxyTest.CrossCuttingConcerns
{
    public interface IValidationService
    {
        void Before();
    }
    public class ValidationService : IValidationService
    {
        public void Before()
        {
            Console.WriteLine("Validation Before");
        }
    }
}
