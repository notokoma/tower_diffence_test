using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBoomScript : MonoBehaviour
{
    public float speedB = 0.00000001f;
    public static GameObject destinationEnemy;
    public static int DamageTypeCanon = 1;
    Vector3 destinationEnemyT;
    int CanonBoomLevel;
    int damageCanonBoom;
    int damageCanonBoomPrimal = 50;
    int Damagebuffs = 0;
    float CanonBoomRadius = 0.15f;
    int i;
    bool CanonBoomEX;
    int layerEnemy;
    Collider[] Booms;
    // Start is called before the first frame update
    void Start()
    {
        layerEnemy = LayerMask.NameToLayer("Enemy");
        CanonBoomEX = false;
        while(i<30){
            if(TrapBuffs.Buffs[i] == true){
                switch(i){
                    case 4:
                    Damagebuffs = Damagebuffs + 20;
                    break;

                    case 5:
                    Damagebuffs = Damagebuffs + 20;
                    break;

                    case 6:
                    CanonBoomRadius = CanonBoomRadius + 0.25f;
                    break;

                    case 8:
                    CanonBoomRadius = CanonBoomRadius + 0.25f;
                    break;

                    case 9:
                    Damagebuffs = Damagebuffs + 20;
                    break;    

                    case 14:
                    CanonBoomEX = true;
                    Damagebuffs = Damagebuffs + 50;
                    break;

                    case 15:
                    CanonBoomEX = true;
                    CanonBoomRadius = CanonBoomRadius + 0.75f;
                    break;

                    case 16:
                    CanonBoomEX = true;
                    break;

                    case 20:
                    Damagebuffs = Damagebuffs - 50;
                    break;

                    case 21:
                    Damagebuffs = Damagebuffs + 40;
                    break;

                    case 22:
                    Damagebuffs = Damagebuffs + 80;
                    break;

                    case 25:
                    CanonBoomRadius = CanonBoomRadius + 0.25f;
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

        Booms = Physics.OverlapSphere(this.transform.position, CanonBoomRadius, 1 << layerEnemy);
    }
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "enemy")
		{
            if(CanonBoomEX == true){
                foreach (Collider Boom in Booms)
		        {
                    if(Boom.gameObject.tag == "enemy"){
                        Boom.gameObject.GetComponent<EnemyController>().Damaged(damageCanonBoom - 40,DamageTypeCanon);
                    }
                }
            }
			other.gameObject.GetComponent<EnemyController>().Damaged(damageCanonBoom,DamageTypeCanon);
            Destroy(this.gameObject);
		}else if(other.gameObject.tag == "ground"){
            Destroy(this.gameObject);
        }
    }
}
