using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIntervalNext : MonoBehaviour
{
    public void OnClick(){
        GameObject.Find("GeneticAlgorithm").GetComponent<GeneticAlgorithm>().GeneticStatus();
        GameScore.StageNumber++;
        Array.Clear(GameScore.EnemySurviveTime,0,GameScore.EnemySurviveTime.Length);
        Array.Clear(GameScore.EnemyDestination,0,GameScore.EnemyDestination.Length);
        SceneManager.LoadScene("SceneGame");
    }
}
