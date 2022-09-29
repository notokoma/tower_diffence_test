using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFirewall : MonoBehaviour
{
    public void OnClick()
    {
        objectClick.trapType = 1;
        Time.timeScale = 0.05f;
    }
}
