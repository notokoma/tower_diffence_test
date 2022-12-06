using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class descriptionchange : MonoBehaviour
{
    public TextMeshProUGUI textA;

    // Update is called once per frame
    void Update()
    {
        switch(objectClick.trapType){
            case 0:
            textA.text = "";
            break;

            case 1:
            textA.text = "firewaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            break;

            case 2:
            textA.text = "canoooooooooooooooooooooooooooooooooooooooooooooo";
            break;

            case 3:
            textA.text = "barusuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu";
            break;
        }
    }
}