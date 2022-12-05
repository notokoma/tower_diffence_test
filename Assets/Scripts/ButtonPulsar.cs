using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPulsar : MonoBehaviour
{
    public void OnClick()
    {
        objectClick.trapType = 3;
        Time.timeScale = 0.05f;
    }
}
