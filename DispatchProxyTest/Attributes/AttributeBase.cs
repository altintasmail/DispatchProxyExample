using DispatchProxyTest.CrossCuttingConcerns;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchProxyTest.Attributes
{
    public abstract class AttributeBase : Attribute
    {
        public virtual void Before(ILogService logService,ICacheService cacheService,IValidationService validationService) { }
        public virtual void After(ILogService logService, ICacheService cacheService, IValidationService validationService) { }
    }
}
