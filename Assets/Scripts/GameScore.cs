using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public static int[] MagicDamaged = new int[10];
    public static int[] PhysicsDamaged = new int[10];
    public static int[] DamagedNumber = new int[10];
    public static float[] ClearTime = new float[10];
    public static int Gold,StageNumber,life,EnemyNumber;
    public static float[] EnemyDestination = new float[5];
    public static float[] EnemySurviveTime = new float[5];

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        StageNumber = 0;
        Gold = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(TrapBuffs.Buffs[0] == true){
            Gold = Gold + 100;
            TrapBuffs.Buffs[0] = false;
        }
        if(TrapBuffs.Buffs[26] == true){
            Gold = Gold + 150;
            TrapBuffs.Buffs[26] = false;
        }
        if(TrapBuffs.Buffs[27] == true){
            Gold = Gold + 300;
            GoalDurability.GoalDurabilityNum--;
            TrapBuffs.Buffs[27] = false;
        }
        if(TrapBuffs.Buffs[28] == true){
            GoalDurability.GoalDurabilityNum++;
            TrapBuffs.Buffs[28] = false;
        }
        if(TrapBuffs.Buffs[29] == true){
            Gold = Gold + 100;
            TrapBuffs.Buffs[29] = false;
        }
    }
}
