using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimeline : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time == 3){
    GameObject StartingPoint = GameObject.Find("enemyspawnpoint");
    Transform StartingPointTransform = StartingPoint.transform;
    Vector3 StartingPointPos = StartingPointTransform.position;
    GameObject obj = (GameObject)Resources.Load ("Enemy");
        Instantiate (obj, StartingPointPos, Quaternion.identity);
        }
    }
}
