using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
	float move = 0.05f;
	int hp = 100;
    Vector3 v = new Vector3(-8.5f, 2.1f, 0);
	public bool isDamaged = false;
	
	void Start()
	{
		
	}
	
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, v, move);
 
        if (transform.position.y == 2.1f && transform.position.x == -8.5f)
        {
			v.x = 8.5f;
        }
 
        if (this.transform.position.x == 8.5f && transform.position.y == 2.1f)
        {
			v.y = -8.5f;
        }
		
		if(isDamaged){
			hp = hp - 50;
			isDamaged = false;
		}
		if(hp <= 0){
			Destroy(this.gameObject);
		}
    }
	public void Damaged()
	{
		hp = hp - 50;
	}
}
