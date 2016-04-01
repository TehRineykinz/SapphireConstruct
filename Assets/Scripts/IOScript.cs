<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IOScript : MonoBehaviour {

    /*
     * Simply put, below is the bulk of saving data, as well as loading data into the game.
     */

    public struct GameData
    {
        public List<Object> Characters;
        public List<Object> DialogGenerics;
        public List<Object> CharacterStats;
    }

    public void SaveGameData(List<Object> Data)
    {

    }
=======
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IOScript : MonoBehaviour {

    /*
     * Simply put, below is the bulk of saving data, as well as loading data into the game.
     */

    public struct GameData
    {
        public List<Object> Characters;
        public List<Object> DialogGenerics;
        public List<Object> CharacterStats;
    }

    public void SaveGameData(List<Object> Data)
    {

    }
>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
}