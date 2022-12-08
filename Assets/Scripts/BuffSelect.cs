using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSelect : MonoBehaviour
{
    GameObject ButtonBuffMas;
    public static int ButtonBuff1;
    public static int ButtonBuff2;
    public static int ButtonBuff3;
    Vector3 v;
    // Start is called before the first frame update
    void Start()
    {
        ButtonBuffMas = (GameObject)Resources.Load ("ButtonBuffMaster");
        v = new Vector3(0,0,0);
        Instantiate (ButtonBuffMas, v, Quaternion.identity);
        switch(GameScore.StageNumber)
        {
            case 0:
            ButtonBuff1 = 0;
            ButtonBuff2 = 1;
            ButtonBuff3 = 2;
            break;

            case 1:
            switch(RandomNumber.randomSeed1 % 3)
            {
            case 0:
            ButtonBuff1 = 2;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                    if(RandomNumber.randomSeed1 % 2 == 0){
                        ButtonBuff1--;
                    }
                    if(RandomNumber.randomSeed1 % 2 == 1){
                        ButtonBuff1--;
                    }
                    if(ButtonBuff1 == 30 || ButtonBuff1 == -1){
                        ButtonBuff1 = -1;
                        break;
                    }
                }
            }
            break;
            case 1:
            ButtonBuff1 = 5;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1--;
                }
                if(RandomNumber.randomSeed1 % 2 == 1){
                    ButtonBuff1--;
                }
                if(ButtonBuff1 == 30 || ButtonBuff1 == -1){
                    ButtonBuff1 = -1;
                    break;
                }
                }
            }
            break;
            case 2:
            ButtonBuff1 = 8;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1--;
                }
                if(RandomNumber.randomSeed1 % 2 == 1){
                    ButtonBuff1--;
                }
                if(ButtonBuff1 == 30 || ButtonBuff1 == -1){
                    ButtonBuff1 = -1;
                    break;
                }
                }
            }
            break;
            }


            break;
            
            case 2:
            switch(RandomNumber.randomSeed1 % 6)
            {
            case 0:
            ButtonBuff1 = 2;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                    if(RandomNumber.randomSeed1 % 2 == 0){
                        ButtonBuff1--;
                    }
                    if(RandomNumber.randomSeed1 % 2 == 1){
                        ButtonBuff1--;
                    }
                    if(ButtonBuff1 == 30 || ButtonBuff1 == -1){
                        ButtonBuff1 = -1;
                        break;
                    }
                }
            }
            break;
            case 1:
            ButtonBuff1 = 2;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1--;
                }
                if(RandomNumber.randomSeed1 % 2 == 1){
                    ButtonBuff1--;
                }
                if(ButtonBuff1 == 30 || ButtonBuff1 == -1){
                    ButtonBuff1 = -1;
                    break;
                }
                }
            }
            break;
            case 2:
            ButtonBuff1 = 5;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1--;
                }
                if(RandomNumber.randomSeed1 % 2 == 1){
                    ButtonBuff1--;
                }
                if(ButtonBuff1 == 30 || ButtonBuff1 == -1){
                    ButtonBuff1 = -1;
                    break;
                }
                }
            }
            break;
            case 3:
            ButtonBuff1 = 5;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1--;
                }
                if(RandomNumber.randomSeed1 % 2 == 1){
                    ButtonBuff1--;
                }
                if(ButtonBuff1 == 30 || ButtonBuff1 == -1){
                    ButtonBuff1 = -1;
                    break;
                }
                }
            }
            break;
            case 4:
            ButtonBuff1 = 8;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1--;
                }
                if(RandomNumber.randomSeed1 % 2 == 1){
                    ButtonBuff1--;
                }
                if(ButtonBuff1 == 30 || ButtonBuff1 == -1){
                    ButtonBuff1 = -1;
                    break;
                }
                }
            }
            break;
            case 5:
            ButtonBuff1 = 8;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1--;
                }
                if(RandomNumber.randomSeed1 % 2 == 1){
                    ButtonBuff1--;
                }
                if(ButtonBuff1 == 30 || ButtonBuff1 == -1){
                    ButtonBuff1 = -1;
                    break;
                }
                }
                }
                break;
            }
            break;
        }
<<<<<<< Updated upstream
=======

        // ButtonBuffMas = (GameObject)Resources.Load ("ButtonBuffMaster");
        // v = new Vector3(0,0,0);
        // Instantiate (ButtonBuffMas, v, Quaternion.identity);


>>>>>>> Stashed changes
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
