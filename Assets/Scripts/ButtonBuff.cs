using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBuff : MonoBehaviour
{
    GameObject ButtonSelect1,ButtonSelect2,ButtonSelect3,ButtonSelectPrimal;
    
    void Start(){
        ButtonSelect1 = GameObject.Find("ButtonBuff1");
        ButtonSelect2 = GameObject.Find("ButtonBuff2");
        ButtonSelect3 = GameObject.Find("ButtonBuff3");
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
            TrapBuffs.Buffs[BuffSelect.ButtonBuff2] = true;
            Destroy(ButtonSelectPrimal);
        }
        if(ButtonSelect3 == this.gameObject){
            TrapBuffs.Buffs[BuffSelect.ButtonBuff3] = true;
            Destroy(ButtonSelectPrimal);
        }

    }
}
