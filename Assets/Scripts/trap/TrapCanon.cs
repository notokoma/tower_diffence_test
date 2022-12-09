using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCanon : MonoBehaviour
{
    private GameObject[] targets;
    public static int CanonLevel;
    float closeDist;
    float CanonInterval;
    float CanonIntervalMax = 0.6f;
    float closeDistN;
    float closeDistNPrimal = 5.5f;
    float closeDistBuff;
    GameObject closeEnemy;
    public GameObject nullnull;
    GameObject BoomObj;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        int i=0;
        while(i<30){
            if(TrapBuffs.Buffs[i] == true){
                switch(i){

                    case 6:
                    closeDistBuff = closeDistBuff + 0.75f;
                    break;

                    case 7:
                    CanonIntervalMax = CanonIntervalMax * 0.9f;
                    break;    

                    case 8:
                    closeDistBuff = closeDistBuff + 0.75f;
                    break;

                    case 10:
                    CanonIntervalMax = CanonIntervalMax * 0.9f;
                    break;

                    case 15:
                    closeDistBuff = closeDistBuff + 2f;
                    break;

                    case 16:
                    CanonIntervalMax = CanonIntervalMax * 0.5f;
                    break;

                    case 22:
                    CanonIntervalMax = CanonIntervalMax * 1.8f;
                    break;

                    default:
                    break;
                }
            }
            i++;
        }
        closeEnemy = nullnull;
        closeDistN = closeDistNPrimal + closeDistBuff;
        closeDist = closeDistN;
        BoomObj = (GameObject)Resources.Load ("CanonBoom");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
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

                if(closeEnemy != nullnull && CanonInterval >= CanonIntervalMax){
                Instantiate (BoomObj, thisPos, Quaternion.identity);
                audioSource.Play();
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
