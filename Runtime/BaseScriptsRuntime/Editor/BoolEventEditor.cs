using EventsSystem.Scripts.Editor;
using ProjectArchitectureBase.Event;
using UnityEditor;
namespace ProjectArchitectureBase.Editor
{
#if UNITY_EDITOR
    [CustomEditor(typeof(BoolEvent))]
    public class BoolEventEditor : EventEditorBase<bool,BoolEvent>
    {
    }
#endif
}
