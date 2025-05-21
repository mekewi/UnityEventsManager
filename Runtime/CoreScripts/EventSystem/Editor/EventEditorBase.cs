using EventsSystem.Scripts.Observables;
using UnityEngine;
using UnityEngine.UIElements;

namespace EventsSystem.Scripts.Editor
{
#if UNITY_EDITOR
    public abstract class EventEditorBase<T, TE> : UnityEditor.Editor
        where TE : Observable<T>
    {
        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();

            IMGUIContainer defaultInspector = new IMGUIContainer(() => DrawDefaultInspector());
            root.Add(defaultInspector);

            TE eventTarget = target as TE;

            var runtimeWrapper = new VisualElement();
            runtimeWrapper.SetEnabled(Application.isPlaying);
            runtimeWrapper.Add(new Button(() =>
            {
                eventTarget?.Raise(eventTarget.InspectorRaiseValue);
            })
            {
                text = "Raise"
            });
            root.Add(runtimeWrapper);
            return root;
        }
    }
#endif
}
