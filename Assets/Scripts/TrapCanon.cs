using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCanon : MonoBehaviour
{
    int count = 0;
    private GameObject[] targets;
    float closeDist;
    float CanonInterval;
    float closeDistN = 6.0f;
    GameObject closeEnemy;
    public GameObject nullnull;
    GameObject BoomObj;

    // Start is called before the first frame update
    void Start()
    {
        closeEnemy = nullnull;
        closeDist = closeDistN;
        BoomObj = (GameObject)Resources.Load ("CanonBoom");
    }

    // Update is called once per frame
    void Update()
    {




    if (count >= 5)
         {
           // カウント変数が5以上であれば、オブジェクトの生成を中止する
        return;
        }
        
        // オブジェクトを生成する
    // （ここでは、単純な例としてCubeオブジェクトを生成する）
    GameObject Canon = GameObject.CreatePrimitive(PrimitiveType.Cube);

    // オブジェクトの生成後、
        count++;








        CanonInterval = CanonInterval + Time.deltaTime;
        targets = GameObject.FindGameObjectsWithTag("enemy");
        foreach (GameObject t in targets)
        {
        Transform myTransform = this.transform;
        Vector3 thisPos = myTransform.position;

            // このオブジェクト（砲弾）と敵までの距離を計測
            float tDist = Vector3.Distance(transform.position, t.transform.position);
 
            // もしも「初期値」よりも「計測した敵までの距離」の方が近いならば、
            if(closeDist > tDist)
            {
                // 「closeDist」を「tDist（その敵までの距離）」に置き換える。
                // これを繰り返すことで、一番近い敵を見つけ出すことができる。
                closeDist = tDist;
 
                // 一番近い敵の情報をcloseEnemyという変数に格納する（★）
                closeEnemy = t;
                //print(Vector3.Distance(transform.position, t.transform.position));

                if(closeEnemy != nullnull && CanonInterval >= 0.5f){
                
                Instantiate (BoomObj, thisPos, Quaternion.identity);
                CanonBoomScript.destinationEnemy = closeEnemy;
                CanonInterval = 0.0f;

                }
            }
            if(closeDistN < tDist){
                closeEnemy = nullnull;
            }
        }
        closeDist = closeDistN;
    }
}
