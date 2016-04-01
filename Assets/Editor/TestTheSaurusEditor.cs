<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(TestTheSaurus))]
public class TestTheSaurusEditor : Editor {

    public override void OnInspectorGUI()
    {
        TestTheSaurus script = (TestTheSaurus)target;

        EditorGUILayout.HelpBox("This is a debugging tool to automatically send data to The Saurus.  This will " +
        "be useful in the future to test out various Keywords and overrides.", MessageType.Info);

        DrawDefaultInspector();

        displaySeparator();
                
        if (GUILayout.Button("Click to test"))
        {
            script.TestingTheSaurus();
        }

        if (Application.isPlaying)
        {
            EditorGUILayout.HelpBox("Click the box above to test!", MessageType.Info);
        }
        else
        {
            EditorGUILayout.HelpBox("Click the box above to test.  You must be in Game Preview mode to test.", MessageType.Warning);
        }

    }

    public void displaySeparator()
    {
        GUILayout.Label("\n");
    }

=======
﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(TestTheSaurus))]
public class TestTheSaurusEditor : Editor {

    public override void OnInspectorGUI()
    {
        TestTheSaurus script = (TestTheSaurus)target;

        EditorGUILayout.HelpBox("This is a debugging tool to automatically send data to The Saurus.  This will " +
        "be useful in the future to test out various Keywords and overrides.", MessageType.Info);

        DrawDefaultInspector();

        displaySeparator();
                
        if (GUILayout.Button("Click to test"))
        {
            script.TestingTheSaurus();
        }

        if (Application.isPlaying)
        {
            EditorGUILayout.HelpBox("Click the box above to test!", MessageType.Info);
        }
        else
        {
            EditorGUILayout.HelpBox("Click the box above to test.  You must be in Game Preview mode to test.", MessageType.Warning);
        }

    }

    public void displaySeparator()
    {
        GUILayout.Label("\n");
    }

>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
}