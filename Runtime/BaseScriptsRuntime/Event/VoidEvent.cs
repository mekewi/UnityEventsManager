using System.Collections;
using System.Collections.Generic;
using EventsSystem.Scripts.Observables;
using UnityEngine;
namespace ProjectArchitectureBase.Event
{
    [CreateAssetMenu(fileName = "VoidEvent", menuName = "Events/VoidEvent")]
    public class VoidEvent : Observable<Void>
    {
        public override void SetData(params object[] data)
        {
        }
        public override void Raise()
        {
            Raise(new Void());
        }
    }
}
