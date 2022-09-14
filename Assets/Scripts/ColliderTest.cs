using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "enemy")
		{
			int damageFirewall = 50;
			other.gameObject.GetComponent<EnemyController>().Damaged(damageFirewall);
		}
    }
}