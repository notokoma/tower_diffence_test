using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPresent : MonoBehaviour
{
    TextMeshProUGUI Clear;
    // Start is called before the first frame update
    void Start()
    {
        Clear = GameObject.Find("TextPresent").GetComponent<TextMeshProUGUI>();
        if(GameScore.StageNumber == 0){
            Clear.text = "最初のトラップを選んでください";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
