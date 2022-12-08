using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
=======
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
>>>>>>> Stashed changes

public class ButtonBuff : MonoBehaviour,IPointerClickHandler
{
<<<<<<< Updated upstream
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
=======
    GameObject ButtonSelect1,ButtonSelect2,ButtonSelect3;
    public GameObject flame1,flame2,flame3;
    public static int BuffS=0;

    public void OnPointerClick(PointerEventData eventData)
>>>>>>> Stashed changes
    {
        switch(this.gameObject.name){
            case "ButtonBuff1":
            print(BuffSelect.ButtonBuff1);
<<<<<<< Updated upstream
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
=======
            BuffS=1;
            flame1.SetActive(true);
            flame2.SetActive(false);
            flame3.SetActive(false);
            //Destroy(ButtonSelectPrimal);
            break;
            case "ButtonBuff2":
            print(BuffSelect.ButtonBuff2);
            BuffS=2;
            flame1.SetActive(false);
            flame2.SetActive(true);
            flame3.SetActive(false);
            //Destroy(ButtonSelectPrimal);
            break;
            case "ButtonBuff3":
            print(BuffSelect.ButtonBuff3);
            BuffS=3;
            flame1.SetActive(false);
            flame2.SetActive(false);
            flame3.SetActive(true);
            //Destroy(ButtonSelectPrimal);
            break;

            case "ButtonNext":
            switch(BuffS){
                case 1:
                TrapBuffs.Buffs[BuffSelect.ButtonBuff1] = true;
                break;
                case 2:
                TrapBuffs.Buffs[BuffSelect.ButtonBuff2] = true;
                break;
                case 3:
                TrapBuffs.Buffs[BuffSelect.ButtonBuff3] = true;
                break;
            }
            GameScore.StageNumber++;
            SceneManager.LoadScene("SceneGame");
            break;
>>>>>>> Stashed changes
        }

    }
}