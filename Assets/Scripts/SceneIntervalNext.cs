using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneIntervalNext : MonoBehaviour
{
    public void OnClick(){
        GameScore.EnemyDestruction = 0;

        SceneManager.LoadScene("SceneGame");
    }
}
