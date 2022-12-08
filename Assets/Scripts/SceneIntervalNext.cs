using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIntervalNext : MonoBehaviour
{
    public void OnClick(){
        GameObject.Find("GeneticAlgorithm").GetComponent<GeneticAlgorithm>().GeneticStatus();
        GameScore.StageNumber++;
        SceneManager.LoadScene("SceneGame");
    }
}
