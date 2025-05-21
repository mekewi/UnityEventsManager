using System;
using System.Collections.Generic;
using UnityEngine;

namespace EventsSystem.Scripts.Observables
{
    public class Observable<T> : EventBase
    {
        private readonly List<Action<T>> _eventListeners = new List<Action<T>>();
        public T InspectorRaiseValue => inspectorRaiseValue;
        [SerializeField]
        [Tooltip("Value that will be used when using the Raise button in the editor inspector.")]
        private T inspectorRaiseValue = default(T);
        public virtual void SetData(params object[] data)
        { }
        public void Raise(T subject)
        {
            for (var i = _eventListeners.Count - 1; i >= 0; i--)
            {
                _eventListeners[i].Invoke(subject);
            }
        }
        public void Register(Action<T> observer)
        {
            if (!_eventListeners.Contains(observer))
            {
                _eventListeners.Add(observer);
            }
        }
        public void Unregister(Action<T> observer)
        {
            if (_eventListeners.Contains(observer))
            {
                _eventListeners.Remove(observer);
            }
        }

    }
}
