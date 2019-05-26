using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventDescription : MonoBehaviour
{
    private string title;
    private string descritpion;
    public int time;

    public void SetTitle(string eventTitle)
    {
        title = eventTitle;
    }

    public void SetDescription(string eventDescription)
    {
        descritpion = eventDescription;
    }

    public void SetTime(int eventTime)
    {
        time = eventTime;
    }

    public void SetText()
    {
        this.gameObject.GetComponent<Text>().text = "<b>"+title+"</b>" + "\n" + descritpion;
        this.gameObject.GetComponent<Text>().alignment = TextAnchor.UpperCenter;
        this.gameObject.GetComponent<Text>().resizeTextForBestFit = true;
    }

    public int GetTime()
    {
        return time;
    }

    public string GetName()
    {
        return title;
    }

    public string GetDescription()
    {
        return descritpion;
    }
}
