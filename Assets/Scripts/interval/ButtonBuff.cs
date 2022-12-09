using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBuff : MonoBehaviour,IPointerClickHandler
{
    GameObject ButtonSelect1,ButtonSelect2,ButtonSelect3;
    Image flame1,flame2,flame3;
    public static int BuffS=0;
    AudioSource audioSource;

    void Start(){
        flame1=GameObject.Find("RedFlame1").GetComponent<Image>();
        flame2=GameObject.Find("RedFlame2").GetComponent<Image>();
        flame3=GameObject.Find("RedFlame3").GetComponent<Image>();
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        switch(this.gameObject.name){
            case "ButtonBuff1":
            //print(BuffSelect.ButtonBuff1);
            BuffS=1;
            flame1.enabled=true;
            flame2.enabled=false;
            flame3.enabled=false;
            //Destroy(ButtonSelectPrimal);
            break;
            case "ButtonBuff2":
            //print(BuffSelect.ButtonBuff2);
            BuffS=2;
            flame1.enabled=false;
            flame2.enabled=true;
            flame3.enabled=false;
            //Destroy(ButtonSelectPrimal);
            break;
            case "ButtonBuff3":
            //(BuffSelect.ButtonBuff3);
            BuffS=3;
            flame1.enabled=false;
            flame2.enabled=false;
            flame3.enabled=true;
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
            GameObject.Find("GeneticAlgorithm").GetComponent<GeneticAlgorithm>().GeneticStatus();
            GameScore.StageNumber++;
            Array.Clear(GameScore.EnemySurviveTime,0,GameScore.EnemySurviveTime.Length);
            Array.Clear(GameScore.EnemyDestination,0,GameScore.EnemyDestination.Length);
            SceneManager.LoadScene("SceneGame");
            break;
        }
        audioSource.Play();

    }
}