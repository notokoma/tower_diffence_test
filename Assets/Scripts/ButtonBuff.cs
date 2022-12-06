using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonBuff : MonoBehaviour
{
    GameObject ButtonSelect1,ButtonSelect2,ButtonSelect3,ButtonSelectPrimal;
    TextMeshProUGUI ButtonSelectTextExp1,ButtonSelectTextExp2,ButtonSelectTextExp3;
    
    void Start(){
        ButtonSelect1 = GameObject.Find("ButtonBuff1");
        ButtonSelectTextExp1 = GameObject.Find("ButtonBuffTextExp1").GetComponent<TextMeshProUGUI>();
        ButtonSelect2 = GameObject.Find("ButtonBuff2");
        ButtonSelectTextExp2 = GameObject.Find("ButtonBuffTextExp2").GetComponent<TextMeshProUGUI>();
        ButtonSelect3 = GameObject.Find("ButtonBuff3");
        ButtonSelectTextExp3 = GameObject.Find("ButtonBuffTextExp3").GetComponent<TextMeshProUGUI>();
        ButtonSelectPrimal = GameObject.Find("ButtonBuffMaster(Clone)");

        if(ButtonSelect1 == this.gameObject && BuffSelect.ButtonBuff1 == -1){
            Destroy(this.gameObject);
        }
        if(ButtonSelect2 == this.gameObject && BuffSelect.ButtonBuff2 == -1){
            Destroy(this.gameObject);
        }
        if(ButtonSelect3 == this.gameObject && BuffSelect.ButtonBuff3 == -1){
            Destroy(this.gameObject);
        }
    }
    public void OnClick()
    {
        if(ButtonSelect1 == this.gameObject){
            print(BuffSelect.ButtonBuff1);
            TrapBuffs.Buffs[BuffSelect.ButtonBuff1] = true;
            Destroy(ButtonSelectPrimal);
        }
        if(ButtonSelect2 == this.gameObject){
            print(BuffSelect.ButtonBuff2);
            TrapBuffs.Buffs[BuffSelect.ButtonBuff2] = true;
            Destroy(ButtonSelectPrimal);
        }
        if(ButtonSelect3 == this.gameObject){
            print(BuffSelect.ButtonBuff3);
            TrapBuffs.Buffs[BuffSelect.ButtonBuff3] = true;
            Destroy(ButtonSelectPrimal);
        }
    }
}
