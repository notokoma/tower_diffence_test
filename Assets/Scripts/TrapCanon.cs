using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCanon : MonoBehaviour
{
    private GameObject[] targets;
    private GameObject[] goals;
    float closeDist;
    float closeDistG = 100;
    float closeDistN = 5;
    public static GameObject closeEnemy;

    // Start is called before the first frame update
    void Start()
    {
        closeEnemy = null;
        closeDist = closeDistG;
        StartCoroutine("CanonBoom");
    }

    // Update is called once per frame
    void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("enemy");
        goals = GameObject.FindGameObjectsWithTag("goalpoint");
        foreach (GameObject g in goals)
        {
            foreach (GameObject t in targets)
            {
 
            // このオブジェクト（砲弾）と敵までの距離を計測
            float gDist = Vector3.Distance(g.transform.position, t.transform.position);
            float tDist = Vector3.Distance(transform.position, t.transform.position);
 
            // もしも「初期値」よりも「計測した敵までの距離」の方が近いならば、
            if(closeDist > gDist && closeDistN > tDist)
            {
                // 「closeDist」を「tDist（その敵までの距離）」に置き換える。
                // これを繰り返すことで、一番近い敵を見つけ出すことができる。
                closeDist = gDist;
 
                // 一番近い敵の情報をcloseEnemyという変数に格納する（★）
                closeEnemy = t;
                //print(targets);
            }
            if(closeDistN < tDist){
                closeEnemy = null;
            }
        }
    }
        if(targets == null){
            closeEnemy = null;
        }
        closeDist = closeDistG;
    }
    IEnumerator CanonBoom()
    {
        for(int i=0;i<1;i--){
            Transform myTransform = this.transform;
            Vector3 thisPos = myTransform.position;
            thisPos.y = thisPos.y + 1.0f;
            //print("a");
            yield return new WaitForSeconds(0.5f);
            if(closeEnemy != null){
            GameObject BoomObj = (GameObject)Resources.Load ("CanonBoom");
            Instantiate (BoomObj, thisPos, Quaternion.identity);
            }
        }
    }
}
