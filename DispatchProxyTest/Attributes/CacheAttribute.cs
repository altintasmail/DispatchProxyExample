using DispatchProxyTest.CrossCuttingConcerns;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchProxyTest.Attributes
{
    public class CacheAttribute : AttributeBase
    {
        public override void Before(ILogService logService, ICacheService cacheService, IValidationService validationService) { cacheService.Before(); }
        public override void After(ILogService logService, ICacheService cacheService, IValidationService validationService) { cacheService.After(); }
    }
}
