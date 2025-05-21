using System.Collections;
using System.Collections.Generic;
using EventsSystem.Scripts.Observables;
using UnityEngine;
namespace ProjectArchitectureBase.Event
{
    [CreateAssetMenu(fileName = "Vector2Event", menuName = "Events/Vector2Event")]
    public class Vector2Event : Observable<Vector2>
    {
        public override void SetData(params object[] data)
        {
        }
    }
}
