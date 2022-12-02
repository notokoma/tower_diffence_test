using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent Enemy_Nav;
    GameObject Destination;
    public int maxHp = 100;
    int Def = 10;
    int DefMagic = 5;
    public int hp;
    public Slider slider;

    void Start()
    {
        //プレイヤーのNavMeshAgentを取得
        Enemy_Nav = GetComponent<NavMeshAgent>();
        //目的地のオブジェクトを取得
        Destination = GameObject.FindWithTag("goalpoint");

        hp = maxHp;

        this.Enemy_Nav.speed = 2.0f;
        //Debug.Log("Start currentHp : " + hp);

        slider.value = 1;
    }

    void Update()
    {
        //目的地を設定
        Enemy_Nav.SetDestination(Destination.transform.position);

		if(hp <= 0){
            //print(GameScore.CanonDamaged + "," + GameScore.FirewallDamaged);
			Destroy(this.gameObject);
            GameScore.EnemyDestruction++;
		}
    }
    public void Damaged(int damage, int DamageType)
	{
        if(DamageType == 1){
            damage = damage - Def;
        } else if(DamageType == 2){
            damage = damage * 100 / (100-DefMagic);
        }
        
        hp = hp - damage;
        GameScore.DamagedNumber++;
        //print(hp);
        //Debug.Log("slider.value : " + slider.value);
        slider.value = (float)hp / (float)maxHp;

	}
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "goalpoint")
		{
            Destroy(this.gameObject);
            GoalDurability.GoalDurabilityNum = GoalDurability.GoalDurabilityNum - 1;
		}
    }
}