using System.Collections;
using System.Collections.Generic;
using EventsSystem.Scripts.Observables;
using UnityEngine;
namespace ProjectArchitectureBase.Event
{
    [CreateAssetMenu(fileName = "Vector3Event", menuName = "Events/Vector3Event")]
    public class Vector3Event : Observable<Vector3>
    {
        public override void SetData(params object[] data)
        {
        }
    }
}
