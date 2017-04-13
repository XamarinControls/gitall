namespace GitAll.Core.Services.Interfaces
{
    public interface IDependencyService
    {
        T Get<T>() where T : class;
        void Register<T>() where T : class;

    }
}
