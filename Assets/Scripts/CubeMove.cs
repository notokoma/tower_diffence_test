using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
	float move = 0.05f;
	int hp = 100;
    Vector3 v = new Vector3(-8.5f, -11.3f, 2.1f);
	public bool isDamaged = false;
	
	void Start()
	{
		
	}
	
    void Update()
    {
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, v, move);
 
        if (transform.localPosition.z == 2.1f && transform.localPosition.x == -8.5f)
        {
			v.x = 8.5f;
        }
 
        if (this.transform.localPosition.x == 8.5f && transform.localPosition.z == 2.1f)
        {
			v.z = -8.5f;
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
