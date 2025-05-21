using EventsSystem.Scripts.Observables;
using System;

public interface IEventsManager
{
    void InvokeEvent<T>(T action);
    void RegisterEvent<T>(Action<T> action) where T : Observable<T>;
}