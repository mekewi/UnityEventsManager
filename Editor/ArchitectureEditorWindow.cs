using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR
public class ArchitectureEditorWindow : EditorWindow
{
    string type = "";
    string savePath = "Assets/ProjectArchitectureBase/BaseScriptsRuntime/";
    string recordButton = "Create";
    string editorPath = "Packages/com.rashad.template/Editor/";
    string eventTemplate = "GameEvent.cs.txt";
    string eventListenerTemplate = "GameEventListener.cs.txt";
    string variableTemplate = "GameVariable.cs.txt";
    string constantVariableTemplate = "GameConstantVariable.cs.txt";
    string eventEditorTemplate = "GameEventEditor.cs.txt";

    bool createEventOnly;
    // Add menu named "My Window" to the Window menu
    [MenuItem("Window/ArchitectureWindow")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        ArchitectureEditorWindow window = (ArchitectureEditorWindow)EditorWindow.GetWindow(typeof(ArchitectureEditorWindow));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Create Events And Variables", EditorStyles.boldLabel);
        type = EditorGUILayout.TextField("Type", type);
        savePath = EditorGUILayout.TextField("Save Path", savePath);
        createEventOnly = EditorGUILayout.Toggle("Create Event Only", createEventOnly);
        if (GUILayout.Button(recordButton))
        {
            var eventClassName = CreateClassFromTemplate(eventTemplate, "Event", "");
            CreateClassFromTemplate(eventListenerTemplate, "EventListener", eventClassName);
            CreateClassFromTemplate(eventEditorTemplate, "Editor", eventClassName, "Event");
            if (!createEventOnly)
            {
                CreateClassFromTemplate(variableTemplate, "Variable", eventClassName);
                CreateClassFromTemplate(constantVariableTemplate, "Constant", eventClassName);
            }
        }

    }

    public string CreateClassFromTemplate(string templateName, string templateType, string eventClassName,string fileNamePrefix = "")
    {
        string templatePath = editorPath + templateName;
        string className = char.ToUpper(type[0]) + type.Substring(1);

        className += fileNamePrefix + templateType;
        var pathToSave = savePath + templateType;
        if (!Directory.Exists(pathToSave))
        {
            Directory.CreateDirectory(pathToSave);
        }
        pathToSave = pathToSave + $"/{className}.cs";
        if (File.Exists(pathToSave))
        {
            File.Delete(pathToSave);
        }

        StreamWriter writer = new StreamWriter(pathToSave, true);
        StreamReader reader = new StreamReader(templatePath);
        string line = "";
        while ((line = reader.ReadLine()) != null)
        {
            line = line.Replace("#SCRIPTNAME#", className);
            line = line.Replace("#TYPE#", type);
            line = line.Replace("#EVENTCLASS#", eventClassName);
            writer.WriteLine(line);
        }
        writer.Close();
        reader.Close();
        AssetDatabase.Refresh();
        return className;
    }
}
#endif