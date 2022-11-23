using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimeline : MonoBehaviour
{
    float timecounter;
    bool spawn = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timecounter = timecounter + Time.deltaTime;
        //print(timecounter);
        if(timecounter >= 3.0f && spawn == true){
    GameObject StartingPoint = GameObject.Find("enemyspawnpoint");
    Transform StartingPointTransform = StartingPoint.transform;
    Vector3 StartingPointPos = StartingPointTransform.position;
    GameObject obj = (GameObject)Resources.Load ("Enemy");
        Instantiate (obj, StartingPointPos, Quaternion.identity);

        spawn = false;
        }
    }
}
