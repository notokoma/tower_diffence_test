using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimeline : MonoBehaviour
{
    float SpawnTimecounter;
    public static bool deployTime;
    bool spawn;

    public static int EnemySpawnNumber;

    // Start is called before the first frame update
    void Start()
    {
        EnemySpawnNumber = 2;
        SpawnTimecounter = 0.0f;
        spawn = true;
        deployTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(deployTime == false){
            SpawnTimecounter = SpawnTimecounter + Time.deltaTime;
        }

        //print(timecounter);

        if(SpawnTimecounter >= 3.0f && spawn == true){
    GameObject StartingPoint = GameObject.Find("enemyspawnpoint");
    Transform StartingPointTransform = StartingPoint.transform;
    Vector3 StartingPointPos = StartingPointTransform.position;
    for(int i=0; i<EnemySpawnNumber; i++){
        GameObject obj = (GameObject)Resources.Load ("Enemy");
        Instantiate (obj, StartingPointPos, Quaternion.identity);
    }
        spawn = false;
        }
        if(EnemySpawnNumber == GameScore.EnemyDestruction){
            SceneManager.LoadScene("SceneInterval");
        }
    }
}
