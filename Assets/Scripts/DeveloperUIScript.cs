<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DeveloperUIScript : MonoBehaviour
{
    public GameObject EditorLabel;
    public GameObject[] EditorButtons;
    public GameObject[] EditorPanels;

    // Use this for initialization
    void Start()
    {
        Text EditorLabelText = EditorLabel.GetComponent<Text>();
        EditorLabelText.text = "Select an Editor to begin";

        ResetButtonsHighlight();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EditorSelected(string EditorString)
    {
        ResetButtonsHighlight();

        foreach (GameObject Button in EditorButtons)
        {
            if (Button.name.Contains(EditorString))
            {
                Image ButtonImage = Button.GetComponent<Image>();
                ButtonImage.color = Color.yellow;

                Text EditorLabelText = EditorLabel.GetComponent<Text>();
                EditorLabelText.text = EditorString;
            }
        }

        foreach (GameObject Panel in EditorPanels)
        {
            if (Panel.name.Contains(EditorString))
            {
                Panel.gameObject.SetActive(true);
            }
        }
    }

    public void ResetButtonsHighlight()
    {
        foreach (GameObject Button in EditorButtons)
        {
            Image ButtonImage = Button.GetComponent<Image>();
            ButtonImage.color = Color.white;
        }

        foreach (GameObject Panel in EditorPanels)
        {
            Panel.gameObject.SetActive(false);
        }
    }
=======
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DeveloperUIScript : MonoBehaviour
{
    public GameObject EditorLabel;
    public GameObject[] EditorButtons;
    public GameObject[] EditorPanels;

    // Use this for initialization
    void Start()
    {
        Text EditorLabelText = EditorLabel.GetComponent<Text>();
        EditorLabelText.text = "Select an Editor to begin";

        ResetButtonsHighlight();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EditorSelected(string EditorString)
    {
        ResetButtonsHighlight();

        foreach (GameObject Button in EditorButtons)
        {
            if (Button.name.Contains(EditorString))
            {
                Image ButtonImage = Button.GetComponent<Image>();
                ButtonImage.color = Color.yellow;

                Text EditorLabelText = EditorLabel.GetComponent<Text>();
                EditorLabelText.text = EditorString;
            }
        }

        foreach (GameObject Panel in EditorPanels)
        {
            if (Panel.name.Contains(EditorString))
            {
                Panel.gameObject.SetActive(true);
            }
        }
    }

    public void ResetButtonsHighlight()
    {
        foreach (GameObject Button in EditorButtons)
        {
            Image ButtonImage = Button.GetComponent<Image>();
            ButtonImage.color = Color.white;
        }

        foreach (GameObject Panel in EditorPanels)
        {
            Panel.gameObject.SetActive(false);
        }
    }
>>>>>>> f4397e399db2160da95f8ddddff179498d8de78f
}