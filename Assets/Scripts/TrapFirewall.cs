using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFirewall : MonoBehaviour
{
	int damageFirewall = 50;
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "enemy")
		{
			other.gameObject.GetComponent<EnemyController>().Damaged(damageFirewall);
		}
    }
}