using System;

namespace DefaultNamespace
{
    public interface IObserver: IDisposable
    {
        void AddObservable(IObservable observable);
    }
}