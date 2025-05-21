using System.Collections;
using System.Collections.Generic;
using EventsSystem.Scripts.Editor;
using ProjectArchitectureBase.Event;
using UnityEditor;
using UnityEngine;
namespace ProjectArchitectureBase.Editor
{
#if UNITY_EDITOR
    [CustomEditor(typeof(Vector3Event))]
    public class Vector3EventEditor : EventEditorBase<Vector3,Vector3Event>
    {
    }
#endif
}
