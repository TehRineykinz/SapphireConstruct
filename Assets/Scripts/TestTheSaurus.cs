<<<<<<< HEAD
﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestTheSaurus : MonoBehaviour {

    [TextArea(0, 5)]
    [Tooltip("A field to add text, run it through The Saurus, and see it on the main screen.")]
    public string TextForTesting = "";
    [Tooltip("The text area for testing.  By Default this should be the main panel text area.")]
    public GameObject UITextArea;


    public void TestingTheSaurus()
    {
        if (Application.isPlaying)
        {
            Text TheTextArea = UITextArea.gameObject.GetComponent<Text>();
            TheTextArea.text = MainScript.RequestTheSaurus(TextForTesting);
        }
        else
        {
            Debug.LogWarning("Test function only available during game preview.");
        }
    }

}
=======
﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestTheSaurus : MonoBehaviour {

    [TextArea(0, 5)]
    [Tooltip("A field to add text, run it through The Saurus, and see it on the main screen.")]
    public string TextForTesting = "";
    [Tooltip("The text area for testing.  By Default this should be the main panel text area.")]
    public GameObject UITextArea;


    public void TestingTheSaurus()
    {
        if (Application.isPlaying)
        {
            Text TheTextArea = UITextArea.gameObject.GetComponent<Text>();
            TheTextArea.text = MainScript.RequestTheSaurus(TextForTesting);
        }
        else
        {
            Debug.LogWarning("Test function only available during game preview.");
        }
    }

}
>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
