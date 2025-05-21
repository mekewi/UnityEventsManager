using UnityEngine;
using UnityEngine.Events;

namespace EventsSystem.Scripts.Observables
{
    public class EventListenerBase<T,TE> : MonoBehaviour
        where TE : Observable<T>
    {
        public TE eventBase;
        public UnityEvent<T> unityEventResponse;
        private void OnEnable()
        {
            eventBase.Register(OnEventRaised);
        }

        private void OnEventRaised(T voidData)
        {
            unityEventResponse.Invoke(voidData);
        }

        private void OnDisable()
        {
            eventBase.Unregister(OnEventRaised);
        }

    }
}