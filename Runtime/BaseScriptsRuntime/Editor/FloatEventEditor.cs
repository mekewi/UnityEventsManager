using EventsSystem.Scripts.Editor;
using ProjectArchitectureBase.Event;
using UnityEditor;
namespace ProjectArchitectureBase.Editor
{
#if UNITY_EDITOR
    [CustomEditor(typeof(FloatEvent))]
    public class FloatEventEditor : EventEditorBase<float,FloatEvent>
    {
    }
#endif
}
