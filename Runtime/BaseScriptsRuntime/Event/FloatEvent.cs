using EventsSystem.Scripts.Observables;
using UnityEngine;
namespace ProjectArchitectureBase.Event
{
    [CreateAssetMenu(fileName = "FloatEvent", menuName = "Events/FloatEvent")]
    public class FloatEvent : Observable<float>
    {
        public override void SetData(params object[] data)
        {
        }
    }
}
