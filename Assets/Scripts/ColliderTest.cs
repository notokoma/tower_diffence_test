using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnterが起きたよ", gameObject);
		GameObject obj = GameObject.Find("enemy");
		
		if(other.gameObject.tag == "enemy")
		{
			other.gameObject.GetComponent<CubeMove>().Damaged();	
		}
    }
}