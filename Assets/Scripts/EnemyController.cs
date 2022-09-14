using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent Player_Nav;
    GameObject Destination;
    public int hp = 100;

    void Start()
    {
        //プレイヤーのNavMeshAgentを取得
        Player_Nav = GetComponent<NavMeshAgent>();
        //目的地のオブジェクトを取得
        Destination = GameObject.Find("goalpoint");
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
	}
}