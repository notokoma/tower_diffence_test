using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBuffs : MonoBehaviour
{
    int i = 0;
    public static bool[] Buffs = new bool[30];
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        while(i < 30){
            Buffs[i] = false;
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream

=======
        //Buffs[20] = false;
        //Buffs[22] = false;
        //Buffs[24] = false;
>>>>>>> Stashed changes
    }
}
