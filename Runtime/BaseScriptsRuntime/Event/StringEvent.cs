using System.Collections;
using System.Collections.Generic;
using EventsSystem.Scripts.Observables;
using UnityEngine;
namespace ProjectArchitectureBase.Event
{
    [CreateAssetMenu(fileName = "StringEvent", menuName = "Events/StringEvent")]
    public class StringEvent : Observable<string>
    {
        public override void SetData(params object[] data)
        {
        }
    }
}
