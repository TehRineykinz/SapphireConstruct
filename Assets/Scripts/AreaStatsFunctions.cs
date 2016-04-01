<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

public class AreaStatsFunctions : MonoBehaviour {

    [Header("Location Statistics")]
    [Tooltip("The name of the location.  It's critical that names are short, due to their use as buttons.")]
    public string AreaName = "";
    [Tooltip("The location that this particular area is in.  Assign it a number.")]
    public int AreaIndex;
    [Tooltip("The locations that are also linked to this one, either entrances or exits.  Change the size of the Array to fit the amount of fields you need.")]
    public List<int> ExitsIndex;

    [Header("Miscellaneous Settings")]
    [Tooltip("This is used to set the alternative location for the area.  By changing this number, the various ''other'' locations can appear, such as a result of a large battle, or forest burning down.  \n\nBy default this value is set to 0, but by changing it in code, it will make the other frames appear.")]
    public int AlternateLocation = 0;

    [Header("Area Descriptions")]
    public List<string> AreaDescriptions;
    
    public void SaveFile()
    {
        int i = AreaDescriptions.Count;
        object[] obj = new object[i];
        obj = AreaDescriptions.ToArray();
        //AreaDescriptions.CopyTo(obj, 0);
        i = obj.Length;

        // use ,true if you want to append data to file
        // this process will open a save file dialog and give the option to choose
        // file location, name, and ext.  then when you press save it will save it
        FileDialog oDialog = new SaveFileDialog();
        oDialog.DefaultExt = "log";
        oDialog.FileName = "Memory_Add_List_SavetoFile";
        if (oDialog.ShowDialog() == DialogResult.OK)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@oDialog.FileName))
                foreach (string line in obj)
                {
                    file.WriteLine(line);
                }
        }
    }

=======
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

public class AreaStatsFunctions : MonoBehaviour {

    [Header("Location Statistics")]
    [Tooltip("The name of the location.  It's critical that names are short, due to their use as buttons.")]
    public string AreaName = "";
    [Tooltip("The location that this particular area is in.  Assign it a number.")]
    public int AreaIndex;
    [Tooltip("The locations that are also linked to this one, either entrances or exits.  Change the size of the Array to fit the amount of fields you need.")]
    public List<int> ExitsIndex;

    [Header("Miscellaneous Settings")]
    [Tooltip("This is used to set the alternative location for the area.  By changing this number, the various ''other'' locations can appear, such as a result of a large battle, or forest burning down.  \n\nBy default this value is set to 0, but by changing it in code, it will make the other frames appear.")]
    public int AlternateLocation = 0;

    [Header("Area Descriptions")]
    public List<string> AreaDescriptions;
    
    public void SaveFile()
    {
        int i = AreaDescriptions.Count;
        object[] obj = new object[i];
        obj = AreaDescriptions.ToArray();
        //AreaDescriptions.CopyTo(obj, 0);
        i = obj.Length;

        // use ,true if you want to append data to file
        // this process will open a save file dialog and give the option to choose
        // file location, name, and ext.  then when you press save it will save it
        FileDialog oDialog = new SaveFileDialog();
        oDialog.DefaultExt = "log";
        oDialog.FileName = "Memory_Add_List_SavetoFile";
        if (oDialog.ShowDialog() == DialogResult.OK)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@oDialog.FileName))
                foreach (string line in obj)
                {
                    file.WriteLine(line);
                }
        }
    }

>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
}