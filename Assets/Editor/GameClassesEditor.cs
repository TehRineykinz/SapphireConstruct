<<<<<<< HEAD
﻿using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(GameClasses))]
public class GameClassesEditor : Editor {

    public override void OnInspectorGUI()
    {
        GameClasses script = (GameClasses)target;

        DrawDefaultInspector();

        if (GUILayout.Button("Click to Save Data"))
        {
            script.SaveGameData();
        }

        if (GUILayout.Button("Click to Load Data"))
        {
            script.LoadGameData();
        }
    }

=======
﻿using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(GameClasses))]
public class GameClassesEditor : Editor {

    public override void OnInspectorGUI()
    {
        GameClasses script = (GameClasses)target;

        DrawDefaultInspector();

        if (GUILayout.Button("Click to Save Data"))
        {
            script.SaveGameData();
        }

        if (GUILayout.Button("Click to Load Data"))
        {
            script.LoadGameData();
        }
    }

>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
}