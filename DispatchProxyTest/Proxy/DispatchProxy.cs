using DispatchProxyTest.Attributes;
using DispatchProxyTest.CrossCuttingConcerns;
using DispatchProxyTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DispatchProxyTest
{
    public class DispatchProxy<Tdecorated> : DispatchProxy
    {
        private Tdecorated _decorated;
        private ILogService _logService;
        private ICacheService _cacheService;
        private IValidationService _validationService;

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            var attributes = ReflectionUtil.GetAttributes<AttributeBase>(targetMethod, targetMethod.DeclaringType, true);

            attributes.ForEach(p => p.Before(_logService, _cacheService, _validationService));
            var result = targetMethod.Invoke(_decorated, args);
            attributes.ForEach(p => p.After(_logService, _cacheService, _validationService));

            return result;
        }

        public static Tdecorated Create(Tdecorated decorated, ILogService logService, ICacheService cacheService, IValidationService validationService)
        {
            object proxy = Create<Tdecorated, DispatchProxy<Tdecorated>>();
            ((DispatchProxy<Tdecorated>)proxy).SetParameters(decorated, logService, cacheService, validationService);
            return (Tdecorated)proxy;
        }

        private void SetParameters(Tdecorated decorated, ILogService logService, ICacheService cacheService, IValidationService validationService)
        {
            _decorated = decorated ?? throw new ArgumentNullException(nameof(decorated));
            _logService = logService ?? throw new ArgumentNullException(nameof(logService));
            _cacheService = cacheService ?? throw new ArgumentNullException(nameof(cacheService));
            _validationService = validationService ?? throw new ArgumentNullException(nameof(validationService));
        }
    }
}
