using GitAll.Core.Services.Interfaces;
using Xamarin.Forms;

namespace GitAll.Forms.Services
{
    //TODO: Actually using Xamarin DI, but maybe create my own DI. Also, it's allow using inside Core, 
    //without insert dll dependencies    
    public class MyDependencyService : IDependencyService
    {
        public T Get<T>() where T : class
        {
            return DependencyService.Get<T>();
        }

        public void Register<T>() where T : class
        {
            DependencyService.Register<T>();            
        }
    }
}
