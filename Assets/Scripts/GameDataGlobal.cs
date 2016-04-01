<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameDataClasses;

public class GameDataGlobal : MonoBehaviour {

    public List<RegionDetails> DefaultRegions = new List<RegionDetails>();
    public List<AreaDetails> DefaultAreas = new List<AreaDetails>();

    void Start()
    {
        // Purely some test code.
        DefaultAreas.Add(new AreaDetails("Town", "Shitty Description", 1));
        DefaultAreas.Add(new AreaDetails("Town Alley", "Crappy Description", 2));
        DefaultRegions.Add(new RegionDetails("Rocky Wastes", "desert", DefaultAreas));
        DefaultRegions.Add(new RegionDetails("Lust Forest", "forest", DefaultAreas));
        DefaultRegions.Add(new RegionDetails("Swampy Highlands", "marsh", DefaultAreas));
    }
=======
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameDataClasses;

public class GameDataGlobal : MonoBehaviour {

    public List<RegionDetails> DefaultRegions = new List<RegionDetails>();
    public List<AreaDetails> DefaultAreas = new List<AreaDetails>();

    void Start()
    {
        // Purely some test code.
        DefaultAreas.Add(new AreaDetails("Town", "Shitty Description", 1));
        DefaultAreas.Add(new AreaDetails("Town Alley", "Crappy Description", 2));
        DefaultRegions.Add(new RegionDetails("Rocky Wastes", "desert", DefaultAreas));
        DefaultRegions.Add(new RegionDetails("Lust Forest", "forest", DefaultAreas));
        DefaultRegions.Add(new RegionDetails("Swampy Highlands", "marsh", DefaultAreas));
    }
>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
}