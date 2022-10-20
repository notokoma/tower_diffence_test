using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent Player_Nav;
    GameObject Destination;
    int maxHp = 100;
    int hp;
    Slider slider;

    void Start()
    {
        //プレイヤーのNavMeshAgentを取得
        slider = GetComponent<>
        Player_Nav = GetComponent<NavMeshAgent>();
        //目的地のオブジェクトを取得
        Destination = GameObject.FindWithTag("goalpoint");

        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        hp = maxHp;
        //Debug.Log("Start currentHp : " + hp);
    }

    void Update()
    {
        //目的地を設定
        Player_Nav.SetDestination(Destination.transform.position);

		if(hp <= 0){
			Destroy(this.gameObject);
		}
    }
    public void Damaged(int damage)
	{
        hp = hp - damage;
        print(hp);
        slider.value = (float)hp / (float)maxHp;
        //Debug.Log("slider.value : " + slider.value);
	}
}