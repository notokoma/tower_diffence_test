using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBoomScript : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        transform dist = TrapCanon.closeEnemy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, dist, step);
    }
}
