using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDeployTime : MonoBehaviour
{
    GameObject[] buttons;
    GameObject[] flames;
    public void OnClick()
    {
        GameTimeline.deployTime = false;
        buttons = GameObject.FindGameObjectsWithTag("destroy_for_start");
        
        foreach (GameObject b in buttons){
            Destroy(b);
        }
    }
}
