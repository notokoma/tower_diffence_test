using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFirewall : MonoBehaviour
{
	int damageFirewall;
	int damageFirewallPrimal = 50;
	bool FirewallEX;
	int damageBurn;
	float damageBurnPrimal = 10; 
	float damageBurnIntervalMax = 1.4f;
    float damageBurnTime = 3.0f;
	int DamageTypeFirewall = 2;
	int Damagebuffs;

	void Start()
    {
		FirewallEX = false;
        int i=0;
        while(i<30){
            if(TrapBuffs.Buffs[i] == true){
                switch(i){

                    case 4:
                    Damagebuffs = Damagebuffs + 30;
                    break;

                    case 5:
                    Damagebuffs = Damagebuffs + 30;
                    break;    

					case 7:
                    damageBurnIntervalMax = damageBurnIntervalMax * 0.8f;
                    break;

                    case 9:
                    Damagebuffs = Damagebuffs + 30;
                    break;

                    case 10:
                    damageBurnIntervalMax = damageBurnIntervalMax * 0.8f;
                    break;

                    case 11:
					FirewallEX = true;
                    damageBurnPrimal = damageBurnPrimal + 5;
                    break;

                    case 12:
					FirewallEX = true;
                    damageFirewallPrimal = damageFirewallPrimal + 80;
                    break;

                    case 13:
					FirewallEX = true;
                    damageBurnIntervalMax = damageBurnIntervalMax * 0.6f;
                    break;

					case 20:
                    Damagebuffs = Damagebuffs + 100;
                    break;

					case 21:
                    Damagebuffs = Damagebuffs + 40;
                    break;
					
					case 23:
                    damageBurnIntervalMax = damageBurnIntervalMax * 0.8f;
                    break;

                    default:
                    break;
                }
            }
            i++;
        }

		damageFirewall = damageFirewallPrimal + Damagebuffs; 
		damageBurn = Mathf.RoundToInt(damageBurnPrimal + (float)Damagebuffs * 0.15f);

    }


    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "enemy")
		{
            if(FirewallEX == true){
                other.gameObject.GetComponent<EnemyController>().Damaged(damageFirewall,DamageTypeFirewall);
                other.gameObject.GetComponent<EnemyController>().Debuffed(0,damageBurnTime,damageBurnIntervalMax,damageBurn);
            } else {
                other.gameObject.GetComponent<EnemyController>().Damaged(damageFirewall,DamageTypeFirewall);
            }
			
		}
    }
}