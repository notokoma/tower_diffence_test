using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent Enemy_Nav;
    GameObject Destination;
    int maxHp = 100;
    int hp;

    void Start()
    {
        //プレイヤーのNavMeshAgentを取得
        Enemy_Nav = GetComponent<NavMeshAgent>();
        //目的地のオブジェクトを取得
        Destination = GameObject.FindWithTag("goalpoint");

        hp = maxHp;

        this.Enemy_Nav.speed = 2.0f;
        //Debug.Log("Start currentHp : " + hp);
    }

    void Update()
    {
        //目的地を設定
        Enemy_Nav.SetDestination(Destination.transform.position);

		if(hp <= 0){
			Destroy(this.gameObject);
		}
    }
    public void Damaged(int damage)
	{
        hp = hp - damage;
        print(hp);
        //Debug.Log("slider.value : " + slider.value);
	}
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "goalpoint")
		{
            Destroy(this.gameObject);
		}
    }
}