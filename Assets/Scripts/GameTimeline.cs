using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimeline : MonoBehaviour
{
    float SpawnTimecounter;
    public static bool deployTime;
    public int spawncounter;
    bool spawn;
    public static int EnemySpawnNumber;
    public static int EnemyDestruction;

    public float minTime =0.1f; //時間間隔の最小値
    public float maxTime = 2.0f; //時間間隔の最大値
    private float interval;
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        EnemySpawnNumber = 5;
        SpawnTimecounter = 0.0f;
        spawncounter = 0;
        deployTime = true;
        EnemyDestruction = 0;
        interval = GetRandomTime(); //ランダムに決定
        //print(GameScore.StageNumber);
        spawn=true;

    }

    // Update is called once per frame
    void Update()
    {
        if(deployTime == false){ //時間計測
            SpawnTimecounter = SpawnTimecounter + Time.deltaTime;
            GameScore.ClearTime[GameScore.StageNumber] = GameScore.ClearTime[GameScore.StageNumber] + Time.deltaTime;
        }

        time += Time.deltaTime;
        //print(interval);

        if(time >= interval && spawncounter < 5 && spawn == true && SpawnTimecounter >= 3.0f){
            GameObject StartingPoint = GameObject.Find("enemyspawnpoint");
            Transform StartingPointTransform = StartingPoint.transform;
            Vector3 StartingPointPos = StartingPointTransform.position;

            GameObject obj = (GameObject)Resources.Load ("Enemy");
            Instantiate (obj, StartingPointPos, Quaternion.identity);
            spawncounter++;
            time=0; //時間リセット
            interval = GetRandomTime(); //インターバルを乱数に再設定する
        }

        if(EnemySpawnNumber == EnemyDestruction){ //全部破壊したら
            deployTime = true;
            print(GameScore.ClearTime[GameScore.StageNumber] 
            + "," + GameScore.MagicDamaged[GameScore.StageNumber]
            + "," + GameScore.PhysicsDamaged[GameScore.StageNumber]
            + "," + GameScore.DamagedNumber[GameScore.StageNumber]);
            

            if(GameScore.StageNumber == 9){ //クリアしたとき
                SceneManager.LoadScene("SceneClear");
            } else {
                SceneManager.LoadScene("SceneInterval");
            }
        }
    }

    //ランダムな時間を生成する関数
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }
    
}