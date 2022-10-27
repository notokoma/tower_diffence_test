using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBoomScript : MonoBehaviour
{
    public float speed = 0.3f;
    Vector3 dest;
    // Start is called before the first frame update
    void Start()
    {
        dest = TrapCanon.closeEnemy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed;
        transform.position = Vector3.MoveTowards(transform.position, dest, speed);
    }
    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "enemy")
		{
			int damageCanonBoom = 30;
			other.gameObject.GetComponent<EnemyController>().Damaged(damageCanonBoom);
            
		}
        Destroy(this.gameObject);
    }
}
