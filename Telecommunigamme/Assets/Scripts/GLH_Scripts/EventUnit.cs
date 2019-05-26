using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventUnit : MonoBehaviour
{
    public GameObject eventPanel;

    private void OnMouseEnter()
    {
        eventPanel.SetActive(true);
    }

    private void OnMouseExit()
    {
        eventPanel.SetActive(false);
    }

    public void SetPanel(GameObject panel)
    {
        eventPanel = panel;
    }
}
