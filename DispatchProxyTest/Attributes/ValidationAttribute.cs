using DispatchProxyTest.CrossCuttingConcerns;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchProxyTest.Attributes
{
    public class ValidationAttribute : AttributeBase
    {
        public override void Before(ILogService logService, ICacheService cacheService, IValidationService validationService) { validationService.Before(); }
    }
}
