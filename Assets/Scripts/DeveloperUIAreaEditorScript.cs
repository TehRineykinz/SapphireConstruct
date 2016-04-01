<<<<<<< HEAD
﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using GameDataClasses;

public class DeveloperUIAreaEditorScript : MonoBehaviour {

    public Dropdown RegionSelection;
    public Dropdown AreaSelection;
    public GameObject GameDataGlobal;


    // Replace the Region Dropdown in the Area Editor with valid data
	public void RegionSelectionUpdate() {
        GameDataGlobal GameData = GameDataGlobal.GetComponent<GameDataGlobal>();

        RegionSelection.options.Clear();

        foreach (RegionDetails Region in GameData.DefaultRegions)
        {
            RegionSelection.options.Add(new Dropdown.OptionData() { text = Region.Title });
        }

        RegionSelection.RefreshShownValue();
        RegionSelection.options.Add(new Dropdown.OptionData() { text = "New Region" });
    
        // This snippet belongs in the AreaSelectionUpdate() function when written
        AreaSelection.options.Add(new Dropdown.OptionData() { text = "New Area" });        
	}


    // This function is called when the Region Dropdown changes
    public void RegionDropdownChange()
    {

        // Create "New Region" button
        if (RegionSelection.value == RegionSelection.options.Count - 1)
        {
            RegionSelection.options.Insert(RegionSelection.options.Count - 1, new Dropdown.OptionData() { text = "Unnamed Region" });
            RegionSelection.RefreshShownValue();
        }
    }
=======
﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using GameDataClasses;

public class DeveloperUIAreaEditorScript : MonoBehaviour {

    public Dropdown RegionSelection;
    public Dropdown AreaSelection;
    public GameObject GameDataGlobal;


    // Replace the Region Dropdown in the Area Editor with valid data
	public void RegionSelectionUpdate() {
        GameDataGlobal GameData = GameDataGlobal.GetComponent<GameDataGlobal>();

        RegionSelection.options.Clear();

        foreach (RegionDetails Region in GameData.DefaultRegions)
        {
            RegionSelection.options.Add(new Dropdown.OptionData() { text = Region.Title });
        }

        RegionSelection.RefreshShownValue();
        RegionSelection.options.Add(new Dropdown.OptionData() { text = "New Region" });
    
        // This snippet belongs in the AreaSelectionUpdate() function when written
        AreaSelection.options.Add(new Dropdown.OptionData() { text = "New Area" });        
	}


    // This function is called when the Region Dropdown changes
    public void RegionDropdownChange()
    {

        // Create "New Region" button
        if (RegionSelection.value == RegionSelection.options.Count - 1)
        {
            RegionSelection.options.Insert(RegionSelection.options.Count - 1, new Dropdown.OptionData() { text = "Unnamed Region" });
            RegionSelection.RefreshShownValue();
        }
    }
>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
}