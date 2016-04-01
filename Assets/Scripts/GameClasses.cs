<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using GameDataClasses;

namespace GameDataClasses
{

    [System.Serializable()]
    public class GameData
    {public List<RegionDetails> Regions = new List<RegionDetails>();

        public GameData(List<RegionDetails> Regions)
        {
            foreach (RegionDetails Region in Regions)
            {
                this.Regions.Add(Region);
            }
        }
    }

    [System.Serializable()]
    public class AreaDetails
    {
        string AreaTitle { get; set; }
        string[] AreaDescriptions = { "" };
        int[] Routes = { 0 };


        public AreaDetails(string Title, string Description, int Route)
        {
            this.AreaTitle = Title;
            this.AreaDescriptions[0] = Description;
            this.Routes[0] = Route;
        }

        public AreaDetails(string Title, string[] Descriptions, int[] Routes)
        {
            this.AreaTitle = Title;
            this.AreaDescriptions = Descriptions;
            this.Routes = Routes;
        }
    }


    [System.Serializable()]
    public class RegionDetails
    {
        public string Title { get; set; }
        public string Weather { get; set; }
        public List<AreaDetails> Areas;


        public RegionDetails(string Title, string Weather, List<AreaDetails> Areas)
        {
            this.Title = Title;
            this.Weather = Weather;
            this.Areas = Areas;
        }
    }
}

public class GameClasses : MonoBehaviour
{
    public GameObject GameDataGlobal;

    public void SaveGameData()
    {
        GameDataGlobal GameDataScript = GameDataGlobal.GetComponent<GameDataGlobal>();

        while (true)
        {
            var SaveDataBank = new GameData(GameDataScript.DefaultRegions);

            try
            {

                // Create the file directory if it doesn't exist.
                if (!(Directory.Exists("C:\\RPG Maker")))
                {
                    Directory.CreateDirectory("C:\\RPG Maker");
                }

                using (Stream stream = File.Open("C:\\RPG Maker\\data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, SaveDataBank);
                }
            }
            catch (IOException)
            {
            }
            break;

        }
    }

    public void LoadGameData()
    {
        GameDataGlobal GameDataScript = GameDataGlobal.GetComponent<GameDataGlobal>();

        while (true)
        {
            try
            {
                using (Stream stream = File.Open("C:\\RPG Maker\\data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var LoadDataBank = (GameData)bin.Deserialize(stream);
                    foreach (RegionDetails Region in LoadDataBank.Regions)
                    {
                    Debug.Log(string.Format("Title {0}, Weather Type {1}, Areas Count {2}",
                        Region.Title,
                        Region.Weather,
                        Region.Areas.Count.ToString()));
                    }

                    // Reminder, store these results to the DefaultRegions variable.

                }
            }
            catch (IOException)
            {
            }
            break;

        }
    }
=======
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using GameDataClasses;

namespace GameDataClasses
{

    [System.Serializable()]
    public class GameData
    {public List<RegionDetails> Regions = new List<RegionDetails>();

        public GameData(List<RegionDetails> Regions)
        {
            foreach (RegionDetails Region in Regions)
            {
                this.Regions.Add(Region);
            }
        }
    }

    [System.Serializable()]
    public class AreaDetails
    {
        string AreaTitle { get; set; }
        string[] AreaDescriptions = { "" };
        int[] Routes = { 0 };


        public AreaDetails(string Title, string Description, int Route)
        {
            this.AreaTitle = Title;
            this.AreaDescriptions[0] = Description;
            this.Routes[0] = Route;
        }

        public AreaDetails(string Title, string[] Descriptions, int[] Routes)
        {
            this.AreaTitle = Title;
            this.AreaDescriptions = Descriptions;
            this.Routes = Routes;
        }
    }


    [System.Serializable()]
    public class RegionDetails
    {
        public string Title { get; set; }
        public string Weather { get; set; }
        public List<AreaDetails> Areas;


        public RegionDetails(string Title, string Weather, List<AreaDetails> Areas)
        {
            this.Title = Title;
            this.Weather = Weather;
            this.Areas = Areas;
        }
    }
}

public class GameClasses : MonoBehaviour
{
    public GameObject GameDataGlobal;

    public void SaveGameData()
    {
        GameDataGlobal GameDataScript = GameDataGlobal.GetComponent<GameDataGlobal>();

        while (true)
        {
            var SaveDataBank = new GameData(GameDataScript.DefaultRegions);

            try
            {

                // Create the file directory if it doesn't exist.
                if (!(Directory.Exists("C:\\RPG Maker")))
                {
                    Directory.CreateDirectory("C:\\RPG Maker");
                }

                using (Stream stream = File.Open("C:\\RPG Maker\\data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, SaveDataBank);
                }
            }
            catch (IOException)
            {
            }
            break;

        }
    }

    public void LoadGameData()
    {
        GameDataGlobal GameDataScript = GameDataGlobal.GetComponent<GameDataGlobal>();

        while (true)
        {
            try
            {
                using (Stream stream = File.Open("C:\\RPG Maker\\data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var LoadDataBank = (GameData)bin.Deserialize(stream);
                    foreach (RegionDetails Region in LoadDataBank.Regions)
                    {
                    Debug.Log(string.Format("Title {0}, Weather Type {1}, Areas Count {2}",
                        Region.Title,
                        Region.Weather,
                        Region.Areas.Count.ToString()));
                    }

                    // Reminder, store these results to the DefaultRegions variable.

                }
            }
            catch (IOException)
            {
            }
            break;

        }
    }
>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
}