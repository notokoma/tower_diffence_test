using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBoomScript : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 dest;
    // Start is called before the first frame update
    void Start()
    {
        dest = TrapCanon.closeEnemy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, dest, speed);
    }
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "enemy")
		{
			int damageCanonBoom = 30;
            int DamageTypeCanonBoom = 1;
            GameScore.CanonDamaged = GameScore.CanonDamaged + damageCanonBoom;
			other.gameObject.GetComponent<EnemyController>().Damaged(damageCanonBoom,DamageTypeCanonBoom);
            
		}
        Destroy(this.gameObject);
    }
}
