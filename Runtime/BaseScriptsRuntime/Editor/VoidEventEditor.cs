using System.Collections;
using System.Collections.Generic;
using EventsSystem.Scripts.Editor;
using ProjectArchitectureBase.Event;
using UnityEditor;
using UnityEngine;
namespace ProjectArchitectureBase.Editor
{
#if UNITY_EDITOR
    [CustomEditor(typeof(VoidEvent))]
    public class VoidEventEditor : EventEditorBase<Void,VoidEvent>
    {
    }
#endif
}
