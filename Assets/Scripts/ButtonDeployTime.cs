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
        buttons = GameObject.FindGameObjectsWithTag("Button");
        flames = GameObject.FindGameObjectsWithTag("flame");
        
        foreach (GameObject b in buttons){
            Destroy(b);
        }
        foreach (GameObject f in flames){
            Destroy(f);
        }
    }
}
