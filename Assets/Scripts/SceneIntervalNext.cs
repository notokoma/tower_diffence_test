using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIntervalNext : MonoBehaviour
{
    public void OnClick(){
        GameScore.StageNumber++;
        SceneManager.LoadScene("SceneGame");
    }
}
