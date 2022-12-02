using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDeployTime : MonoBehaviour
{
    GameObject[] buttons;
    public void OnClick()
    {
        GameTimeline.deployTime = false;
        buttons = GameObject.FindGameObjectsWithTag("Button");
        
        foreach (GameObject b in buttons){
            Destroy(b);
        }
    }
}
