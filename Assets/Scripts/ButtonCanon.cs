using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCanon : MonoBehaviour
{
    public void OnClick()
    {
        objectClick.trapType = 2;
        Time.timeScale = 0.05f;
    }
}
