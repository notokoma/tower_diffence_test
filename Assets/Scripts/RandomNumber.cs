using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    public static int randomSeed1,randomSeed2,randomSeed3;
    // Start is called before the first frame update
    void Start()
    {
        randomSeed1 = Random.Range(1, 20791);
        randomSeed2 = Random.Range(1, 20791);
        randomSeed3 = Random.Range(1, 20791);
        //print(randomSeed);
        DontDestroyOnLoad (this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
