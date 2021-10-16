using System;

namespace DefaultNamespace
{
    public interface IObservable
    {
        event Action<object> OnChanged;
    }
}