using UnityEngine;

namespace EventsSystem.Scripts.Observables
{
    public abstract class EventBase : ScriptableObject
    {
        public virtual void Raise()
        {
        }
    }
}