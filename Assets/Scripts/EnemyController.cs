using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent Enemy_Nav;
    GameObject Destination;
    public int maxHp;
    int Def;
    int maxDef = 10;
    int DefMagic;
    int maxDefMagic = 0;
    float speed;
    float speedMax = 2.0f;
    float dist = 0f;
    
    bool freeze = false;
    float freezeEffectTime;
    float freezeEffectTimeMax;
    float freezeEffectSize;

    bool burn = false;
    int burnDamage;
    float burnEffectTime;
    float burnEffectTimeMax;
    float burnInterval; 
    float burnIntervalMax;

    public int hp;
    public Slider slider;
    public float remainingDistance;

    void Start()
    {
        GameScore.EnemyNumber++;
        //プレイヤーのNavMeshAgentを取得
        Enemy_Nav = GetComponent<NavMeshAgent>();
        //目的地のオブジェクトを取得
        Destination = GameObject.FindWithTag("goalpoint");

        speed = speedMax;
        this.Enemy_Nav.speed = speed;
        
        Def = maxDef;
        DefMagic = maxDefMagic;

        maxHp = 100;
        hp = maxHp;

        //Debug.Log("Start currentHp : " + hp);

        slider.value = 1;
    }

    void Update()
    {
        //目的地を設定
        Enemy_Nav.SetDestination(Destination.transform.position);
        if(burn == true){
            burnInterval = burnInterval + Time.deltaTime;
            burnEffectTime = burnEffectTime + Time.deltaTime;
            
            if(burnInterval >= burnIntervalMax){
                Damaged(burnDamage + 15,1);
                Damaged(burnDamage,2);
                burnInterval = 0;
            }
        }
        if(burnEffectTime >= burnEffectTimeMax){
            burn = false;
            burnEffectTime = 0;
        }

        if(freeze == true){
            freezeEffectTime = freezeEffectTime + Time.deltaTime;
            this.Enemy_Nav.speed = speed - freezeEffectSize;
        }
        if(freezeEffectTime >= freezeEffectTimeMax){
            this.Enemy_Nav.speed = speed;
            freeze = false;
            freezeEffectTime = 0;
        }

		if(hp <= 0){
            //print(GameScore.CanonDamaged + "," + GameScore.FirewallDamaged);
            GameScore.EnemyDestination[GameScore.EnemyNumber] = dist;
            GameTimeline.EnemyDestruction++;
			Destroy(this.gameObject);
		}

        NavMeshPath path = Enemy_Nav.path; //経路パス（曲がり角座標のVector3配列）を取得
        Vector3 corner = transform.position; //自分の現在位置
        //曲がり角間の距離を累積していく
        for (int i = 0; i < path.corners.Length; i++){
            Vector3 corner2 = path.corners[i];
            dist += Vector3.Distance(corner, corner2);
            corner = corner2;
        }
        dist = 0;
    }
    public void Damaged(int damage, int DamageType)
	{
        if(DamageType == 1){
            damage = damage - Def;
            print(damage);
            if(damage >= 0){
                GameScore.PhysicsDamaged[GameScore.StageNumber] = GameScore.PhysicsDamaged[GameScore.StageNumber] + damage;
            }
        } else if(DamageType == 2){
            damage = damage * (100-DefMagic) / 100;
            print(damage);
            GameScore.MagicDamaged[GameScore.StageNumber] = GameScore.MagicDamaged[GameScore.StageNumber] + damage;
        }
        if(damage >= 0){
            hp = hp - damage;    
        }
        GameScore.DamagedNumber[GameScore.StageNumber]++;
        //print(hp);
        slider.value = (float)hp / (float)maxHp;

	}
    public void Debuffed(int DebuffType,float DebuffTimeMax,float DebuffEffectSizeMax,int DebuffDamage){
        if(DebuffType == 0){
            burn = true;
            burnEffectTimeMax = DebuffTimeMax;
            burnDamage = DebuffDamage;
            burnIntervalMax = DebuffEffectSizeMax;
        }else if(DebuffType == 1){
            freeze = true;
            freezeEffectTimeMax = DebuffTimeMax;
            freezeEffectSize = DebuffEffectSizeMax;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "goalpoint")
		{
            Destroy(this.gameObject);
            GoalDurability.GoalDurabilityNum--;
            GameTimeline.EnemyDestruction++;
		}
    }
}