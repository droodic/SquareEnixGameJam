﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    private Text dialogTextBox;
    [SerializeField] private string[] textsToDisplay;
    [SerializeField] private GameObject panel;
    //private Touch touch;
    private int currentText = 0;

    public void Start()
    {
        dialogTextBox = gameObject.GetComponent<Text>();
        dialogTextBox.text = textsToDisplay[currentText];
    }

    public void Update()
    {
        ClickToContinueText();
    }

    public void ClickToContinueText()
    {
        if(Input.GetMouseButtonDown(0))
        {
            NextText();
        }
    }

    public void NextText()
    {
        if(currentText < textsToDisplay.Length - 1)
        {
            currentText++;
            dialogTextBox.text = textsToDisplay[currentText];
        }
        else
        {
            panel.SetActive(false);
        }
        Debug.Log(currentText);
    }
}
