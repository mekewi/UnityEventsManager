using EventsSystem.Scripts.Observables;
using UnityEngine;
namespace ProjectArchitectureBase.Event
{
    [CreateAssetMenu(fileName = "BoolEvent", menuName = "Events/BoolEvent")]
    public class BoolEvent : Observable<bool>
    {
        public override void SetData(params object[] data)
        {
        }
    }
}
