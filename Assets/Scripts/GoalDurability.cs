using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalDurability : MonoBehaviour
{
    public static int GoalDurabilityNum = 3;

    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
        if(GoalDurabilityNum == 0){
            SceneManager.LoadScene("SceneLose");
        }
    }
}
