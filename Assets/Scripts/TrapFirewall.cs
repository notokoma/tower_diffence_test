using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFirewall : MonoBehaviour
{
	int damageFirewall = 50;
	int DamageTypeFirewall = 2;
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "enemy")
		{
			GameScore.FirewallDamaged = GameScore.FirewallDamaged + damageFirewall;
			other.gameObject.GetComponent<EnemyController>().Damaged(damageFirewall,DamageTypeFirewall);
		}
    }
}