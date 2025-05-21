using UnityEditor;
#if UNITY_EDITOR
public class CreateNewScriptFromCustomTemplate
{
    private const string eventTemplatePath = "Assets/Editor/GameEvent.cs.txt";
    private const string eventListenerTemplatePath = "Assets/Editor/GameEventListener.cs.txt";

    [MenuItem(itemName: "Assets/Create/Class/Create Event Base", isValidateFunction: false, priority: 51)]
    public static void CreateEventTemplate()
    {
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(eventTemplatePath, "GameEvent.cs");
    }
    [MenuItem(itemName: "Assets/Create/Class/Create Event Listener Base", isValidateFunction: false, priority: 51)]
    public static void CreateEventListenerTemplate()
    {
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(eventListenerTemplatePath, "GameEventListener.cs");
    }
}
#endif