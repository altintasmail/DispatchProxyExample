using DispatchProxyTest.CrossCuttingConcerns;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchProxyTest.Attributes
{
    public class LogAttribute : AttributeBase
    {
        public override void Before(ILogService logService, ICacheService cacheService, IValidationService validationService) { logService.Before(); }
        public override void After(ILogService logService, ICacheService cacheService, IValidationService validationService) { logService.After(); }
    }
}
