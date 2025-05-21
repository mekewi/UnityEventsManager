using EventsSystem.Scripts.Observables;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour, IEventsManager
{
    public Dictionary<Type, EventBase> keyValuePairs = new Dictionary<Type, EventBase>();
    public void RegisterEvent<T>(Action<T> action) where T : Observable<T>
    {
        if (!keyValuePairs.ContainsKey(typeof(T)))
        {
            keyValuePairs[typeof(T)] = new Observable<T>();
        }
        var values = keyValuePairs[typeof(T)] as Observable<T>;
        values.Register(action);
    }
    public void InvokeEvent<T>(T action)
    {
        var values = keyValuePairs[typeof(T)] as Observable<T>;
        values.Raise(action);
    }
}
