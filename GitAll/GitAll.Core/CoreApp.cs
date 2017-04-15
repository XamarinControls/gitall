using System.Reflection;
using GitAll.Core.Services.Interfaces;
using GitAll.Core.I18NPortable;
using System.Diagnostics;
using GitAll.Core.Services;

namespace GitAll.Core
{
    public class CoreApp
    {
        
        private static IDependencyService _dependencyService;
        
        public void Init(IDependencyService dependencyService)
        {
            _dependencyService = dependencyService;

            Register<MasterDetailMenuService>();
            Register<AppSettings>();
            Register<AccountService>();
            Register<RepositoryService>();

            I18N.Current
                .SetNotFoundSymbol("$")
                .SetFallbackLocale("en")
                .SetThrowWhenKeyNotFound(true)
                .SetLogger(text => Debug.WriteLine(text))
                .Init(GetType().GetTypeInfo().Assembly);
        }

        

        public static T Get<T>() where T : class
        {
            return _dependencyService.Get<T>();
        }

        public static void Register<T>() where T : class
        {
            _dependencyService.Register<T>();
        }
    }
}
