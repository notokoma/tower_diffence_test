using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class titlebutton_script : MonoBehaviour,IPointerClickHandler
{
    public GameObject setting;

    // タップ  
    public void OnPointerClick(PointerEventData eventData){
        switch(this.name){

        case "start":
            TitleNextSound.SoundFlag1 = true;
            SceneManager.LoadScene("SceneInterval");
        break;

        case "option":
            setting.SetActive(true);
        break;
        case "return":
            setting.SetActive(false);
        break;
        }
    }

}