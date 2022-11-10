using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBoomScript : MonoBehaviour
{
    public float speedB = 0.0000001f;
    public static GameObject destinationEnemy;
    Vector3 destinationEnemyT;
    // Start is called before the first frame update
    void Start()
    {
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
			int damageCanonBoom = 50;
			other.gameObject.GetComponent<EnemyController>().Damaged(damageCanonBoom);
            Destroy(this.gameObject);
		}
    }
}
