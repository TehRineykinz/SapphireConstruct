<<<<<<< HEAD
﻿using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(AreaStatsFunctions))]
public class AreaStatsFunctionsEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        AreaStatsFunctions Script = (AreaStatsFunctions)target;
        int DescCount = Script.AreaDescriptions.Count;
        int AltCount = Script.AlternateLocation + 1;

        //Error Checking
        if (AltCount < 0)
        {
            Script.AlternateLocation = -1;
            Debug.LogWarning("Alternate Location can not be set to -1.  Please try a higher number.");
        }


        while (DescCount > AltCount) {
            Script.AreaDescriptions.RemoveAt(DescCount - 1);
            DescCount--;
        }


        while (DescCount < AltCount)
        {
            Script.AreaDescriptions.Add("New Field");
            DescCount++;
        }

        if (GUILayout.Button("Click to save."))
        {
            Script.SaveFile();
        }

    }

=======
﻿using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(AreaStatsFunctions))]
public class AreaStatsFunctionsEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        AreaStatsFunctions Script = (AreaStatsFunctions)target;
        int DescCount = Script.AreaDescriptions.Count;
        int AltCount = Script.AlternateLocation + 1;

        //Error Checking
        if (AltCount < 0)
        {
            Script.AlternateLocation = -1;
            Debug.LogWarning("Alternate Location can not be set to -1.  Please try a higher number.");
        }


        while (DescCount > AltCount) {
            Script.AreaDescriptions.RemoveAt(DescCount - 1);
            DescCount--;
        }


        while (DescCount < AltCount)
        {
            Script.AreaDescriptions.Add("New Field");
            DescCount++;
        }

        if (GUILayout.Button("Click to save."))
        {
            Script.SaveFile();
        }

    }

>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
}