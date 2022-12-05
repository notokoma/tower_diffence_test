using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public static int[] MagicDamaged = new int[10];
    public static int[] PhysicsDamaged = new int[10];
    public static int[] DamagedNumber = new int[10];
    public static float[] ClearTime = new float[10];
    public static int Gold,StageNumber;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad (this);
        StageNumber = 0;
        Gold = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
