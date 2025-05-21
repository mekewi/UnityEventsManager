using System.Collections;
using System.Collections.Generic;
using EventsSystem.Scripts.Observables;
using UnityEngine;
namespace ProjectArchitectureBase.Event
{
    [CreateAssetMenu(fileName = "IntEvent", menuName = "Events/IntEvent")]
    public class IntEvent : Observable<int>
    {
        public override void SetData(params object[] data)
        {
        }
    }
}
