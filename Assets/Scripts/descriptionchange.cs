using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class descriptionchange : MonoBehaviour
{
    public TextMeshProUGUI DescriveTitle;
    public TextMeshProUGUI DescriveBody;

    // Update is called once per frame
    void Update()
    {
        switch(objectClick.trapType){
            case 0:
            DescriveTitle.text = "";
            DescriveBody.text = "";
            break;

            case 1:
            DescriveTitle.text = "Firewall";
            DescriveBody.text = "上を通った敵にダメージを与える。";
            break;

            case 2:
            DescriveTitle.text = "Canon";
            DescriveBody.text = "周りの敵に砲撃し、単体にダメージを与える。";
            break;

            case 3:
            DescriveTitle.text = "Pulsar";
            DescriveBody.text = "一定時間ごとに周りの敵にダメージを与える。";
            break;
        }
    }
}