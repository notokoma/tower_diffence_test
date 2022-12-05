using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBoomScript : MonoBehaviour
{
    public float speedB = 0.00000001f;
    public static GameObject destinationEnemy;
    public static int DamageTypeCanon = 1;
    Vector3 destinationEnemyT;
    int damageCanonBoom;
    int damageCanonBoomPrimal = 50;
    int Damagebuffs = 0;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        while(i<9){
            if(TrapBuffs.Buffs[i] == true){
                switch(i){
                    case 3:
                    Damagebuffs = Damagebuffs + 20;
                    break;

                    default:
                    break;    
                }
            }
            i++;
        }
        damageCanonBoom = damageCanonBoomPrimal + Damagebuffs;
        if(destinationEnemy != null){
        destinationEnemyT = destinationEnemy.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float step = speedB * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, destinationEnemyT, step);
    }
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "enemy")
		{
			other.gameObject.GetComponent<EnemyController>().Damaged(damageCanonBoom,DamageTypeCanon);
            Destroy(this.gameObject);
		}else if(other.gameObject.tag == "ground"){
            Destroy(this.gameObject);
        }
    }
}
