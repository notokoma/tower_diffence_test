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
        //buffの生成
        switch(GameScore.StageNumber)
        {
            case 0:
            //day0
            ButtonBuff1 = 1;
            ButtonBuff2 = 2;
            ButtonBuff3 = 3;
            break;

            case 1:
            //day1,buff1
            switch(RandomNumber.randomSeed1 % 3)
            {
            case 0:
            ButtonBuff1 = 1;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                    if(RandomNumber.randomSeed1 % 2 == 0){
                        ButtonBuff1++;
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
                    ButtonBuff1++;
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
            ButtonBuff1 = 3;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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

            //day1,buff2
            switch(RandomNumber.randomSeed2 % 3)
            {
            case 0:
            ButtonBuff2 = 4;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                    if(RandomNumber.randomSeed2 % 2 == 0){
                        ButtonBuff2++;
                    }
                    if(RandomNumber.randomSeed2 % 2 == 1){
                        ButtonBuff2--;
                    }
                    if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                        ButtonBuff2 = -1;
                        break;
                    }
                }
            }
            break;
            case 1:
            ButtonBuff2 = 5;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 2:
            ButtonBuff2 = 6;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            }

            //day1,buff3
            switch(RandomNumber.randomSeed3 % 3)
            {
            case 0:
            case 1:
            case 2:
            ButtonBuff3 = 29;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                if(RandomNumber.randomSeed3 % 2 == 0){
                    ButtonBuff3++;
                }
                if(RandomNumber.randomSeed3 % 2 == 1){
                    ButtonBuff3--;
                }
                if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                    ButtonBuff3 = -1;
                    break;
                }
                }
            }
            break;
            }
            break;
            
            case 2:
            //day2,buff1
            switch(RandomNumber.randomSeed1 % 6)
            {
            case 0:
            case 1:
            ButtonBuff1 = 1;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 3:
            ButtonBuff1 = 3;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 5:
            ButtonBuff1 = 5;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            //day2,buff2
            switch(RandomNumber.randomSeed2 % 6)
            {
            case 0:
            case 1:
            ButtonBuff2 = 4;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 2:
            case 3:
            ButtonBuff2 = 7;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 4:
            case 5:
            ButtonBuff2 = 9;
            if(ButtonBuff2 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            }
            //day2,buff3
            switch(RandomNumber.randomSeed3 % 6)
            {
            case 0:
            ButtonBuff3 = 26;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                    if(RandomNumber.randomSeed3 % 2 == 0){
                        ButtonBuff3++;
                    }
                    if(RandomNumber.randomSeed3 % 2 == 1){
                        ButtonBuff3--;
                    }
                    if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                        ButtonBuff3 = -1;
                        break;
                    }
                }
            }
            break;
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            ButtonBuff3 = 29;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                if(RandomNumber.randomSeed3 % 2 == 0){
                    ButtonBuff3++;
                }
                if(RandomNumber.randomSeed3 % 2 == 1){
                    ButtonBuff3--;
                }
                if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                    ButtonBuff3 = -1;
                    break;
                }
                }
            }
            break;
            }

            break;

            case 3:
            //day3,buff1
            switch(RandomNumber.randomSeed1 % 9)
            {
            case 0:
            case 1:
            case 2:
            ButtonBuff1 = 2;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 4:
            case 5:
            ButtonBuff1 = 3;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 6:
            case 7:
            case 8:
            ButtonBuff1 = 6;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            //day3,buff2
            switch(RandomNumber.randomSeed2 % 9)
            {
            case 0:
            case 1:
            case 2:
            ButtonBuff2 = 6;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 3:
            case 4:
            case 5:
            ButtonBuff2 = 8;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 6:
            case 7:
            case 8:
            ButtonBuff2 = 10;
            if(ButtonBuff2 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            }
            //day3,buff3
            switch(RandomNumber.randomSeed3 % 9)
            {
            case 0:
            case 1:
            ButtonBuff3 = 26;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                    if(RandomNumber.randomSeed3 % 2 == 0){
                        ButtonBuff3++;
                    }
                    if(RandomNumber.randomSeed3 % 2 == 1){
                        ButtonBuff3--;
                    }
                    if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                        ButtonBuff3 = -1;
                        break;
                    }
                }
            }
            break;
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            ButtonBuff3 = 29;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                if(RandomNumber.randomSeed3 % 2 == 0){
                    ButtonBuff3++;
                }
                if(RandomNumber.randomSeed3 % 2 == 1){
                    ButtonBuff3--;
                }
                if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                    ButtonBuff3 = -1;
                    break;
                }
                }
            }
            break;
            }

            break;

            case 4:
            //day4,buff1
            switch(RandomNumber.randomSeed1 % 12)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            ButtonBuff1 = 1;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 5:
            case 6:
            case 7:
            ButtonBuff1 = 2;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 8:
            case 9:
            case 10:
            case 11:
            ButtonBuff1 = 11;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            //day4,buff2
            switch(RandomNumber.randomSeed2 % 12)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            ButtonBuff2 = 13;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 4:
            case 5:
            case 6:
            case 7:
            ButtonBuff2 = 7;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 8:
            case 9:
            case 10:
            case 11:
            ButtonBuff2 = 8;
            if(ButtonBuff2 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            }
            //day4,buff3
            switch(RandomNumber.randomSeed3 % 12)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            ButtonBuff3 = 26;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                    if(RandomNumber.randomSeed3 % 2 == 0){
                        ButtonBuff3++;
                    }
                    if(RandomNumber.randomSeed3 % 2 == 1){
                        ButtonBuff3--;
                    }
                    if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                        ButtonBuff3 = -1;
                        break;
                    }
                }
            }
            break;
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            ButtonBuff3 = 29;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                if(RandomNumber.randomSeed3 % 2 == 0){
                    ButtonBuff3++;
                }
                if(RandomNumber.randomSeed3 % 2 == 1){
                    ButtonBuff3--;
                }
                if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                    ButtonBuff3 = -1;
                    break;
                }
                }
            }
            break;
            }

            break;
            case 5:
            //day5,buff1
            switch(RandomNumber.randomSeed1 % 15)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            ButtonBuff1 = 5;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 6:
            case 7:
            case 8:
            case 9:
            ButtonBuff1 = 6;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            ButtonBuff1 = 7;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            //day5,buff2
            switch(RandomNumber.randomSeed2 % 15)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            ButtonBuff2 = 12;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            ButtonBuff2 = 15;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            ButtonBuff2 = 18;
            if(ButtonBuff2 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            }
            //day5,buff3
            switch(RandomNumber.randomSeed3 % 15)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            ButtonBuff3 = 26;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                    if(RandomNumber.randomSeed3 % 2 == 0){
                        ButtonBuff3++;
                    }
                    if(RandomNumber.randomSeed3 % 2 == 1){
                        ButtonBuff3--;
                    }
                    if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                        ButtonBuff3 = -1;
                        break;
                    }
                }
            }
            break;
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            ButtonBuff3 = 29;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                if(RandomNumber.randomSeed3 % 2 == 0){
                    ButtonBuff3++;
                }
                if(RandomNumber.randomSeed3 % 2 == 1){
                    ButtonBuff3--;
                }
                if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                    ButtonBuff3 = -1;
                    break;
                }
                }
            }
            break;
            }

            break;

            case 6:
            //day6,buff1
            switch(RandomNumber.randomSeed1 % 18)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            ButtonBuff1 = 1;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            ButtonBuff1 = 2;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            ButtonBuff1 = 3;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            //day6,buff2
            switch(RandomNumber.randomSeed2 % 18)
            {
            case 0:
            case 1:
            case 2:
            ButtonBuff2 = 11;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 3:
            case 4:
            case 5:
            ButtonBuff2 = 12;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 6:
            case 7:
            case 8:
            ButtonBuff2 = 14;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 9:
            case 10:
            case 11:
            ButtonBuff2 = 15;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 12:
            case 13:
            case 14:
            ButtonBuff2 = 17;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 15:
            case 16:
            case 17:
            ButtonBuff2 = 18;
            if(ButtonBuff2 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            }
            //day6,buff3
            switch(RandomNumber.randomSeed3 % 4)
            {
            case 0:
            ButtonBuff3 = 26;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                    if(RandomNumber.randomSeed3 % 2 == 0){
                        ButtonBuff3++;
                    }
                    if(RandomNumber.randomSeed3 % 2 == 1){
                        ButtonBuff3--;
                    }
                    if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                        ButtonBuff3 = -1;
                        break;
                    }
                }
            }
            break;
            case 1:
            case 2:
            case 3:
            ButtonBuff3 = 29;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                if(RandomNumber.randomSeed3 % 2 == 0){
                    ButtonBuff3++;
                }
                if(RandomNumber.randomSeed3 % 2 == 1){
                    ButtonBuff3--;
                }
                if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                    ButtonBuff3 = -1;
                    break;
                }
                }
            }
            break;
            }

            break;
            case 7:
            //day7,buff1
            switch(RandomNumber.randomSeed1 % 6)
            {
            case 0:
            case 3:
            ButtonBuff1 = 21;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 4:
            ButtonBuff1 = 23;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 5:
            ButtonBuff1 = 25;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            //day7,buff2
            switch(RandomNumber.randomSeed2 % 6)
            {
            case 0:
            ButtonBuff2 = 11;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 1:
            ButtonBuff2 = 13;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 2:
            ButtonBuff2 = 14;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 3:
            ButtonBuff2 = 16;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 4:
            ButtonBuff2 = 17;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 5:
            ButtonBuff2 = 19;
            if(ButtonBuff2 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            }
            //day7,buff3
            switch(RandomNumber.randomSeed3 % 6)
            {
            case 0:
            case 1:
            case 2:
            ButtonBuff3 = 29;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                    if(RandomNumber.randomSeed3 % 2 == 0){
                        ButtonBuff3++;
                    }
                    if(RandomNumber.randomSeed3 % 2 == 1){
                        ButtonBuff3--;
                    }
                    if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                        ButtonBuff3 = -1;
                        break;
                    }
                }
            }
            break;
            case 3:
            case 4:
            case 5:
            ButtonBuff3 = 26;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                if(RandomNumber.randomSeed3 % 2 == 0){
                    ButtonBuff3++;
                }
                if(RandomNumber.randomSeed3 % 2 == 1){
                    ButtonBuff3--;
                }
                if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                    ButtonBuff3 = -1;
                    break;
                }
                }
            }
            break;
            }

            break;
            case 8:
            //day8,buff1
            switch(RandomNumber.randomSeed1 % 24)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            ButtonBuff1 = 13;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 5:
            case 6:
            case 7:
            ButtonBuff1 = 16;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 8:
            case 9:
            case 10:
            case 11:
            ButtonBuff1 = 19;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 12:
            case 13:
            case 14:
            case 15:
            ButtonBuff1 = 20;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 16:
            case 17:
            case 18:
            case 19:
            ButtonBuff1 = 22;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 20:
            case 21:
            case 22:
            case 23:
            ButtonBuff1 = 24;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            //day8,buff2
            switch(RandomNumber.randomSeed2 % 24)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            ButtonBuff2 = 21;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            ButtonBuff2 = 23;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
            case 21:
            case 22:
            case 23:
            ButtonBuff2 = 25;
            if(ButtonBuff2 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            }
            //day8,buff3
            switch(RandomNumber.randomSeed3 % 5)
            {
            case 0:
            case 1:
            ButtonBuff3 = 26;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                    if(RandomNumber.randomSeed3 % 2 == 0){
                        ButtonBuff3++;
                    }
                    if(RandomNumber.randomSeed3 % 2 == 1){
                        ButtonBuff3--;
                    }
                    if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                        ButtonBuff3 = -1;
                        break;
                    }
                }
            }
            break;
            case 2:
            case 3:
            case 4:
            ButtonBuff3 = 29;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                if(RandomNumber.randomSeed3 % 2 == 0){
                    ButtonBuff3++;
                }
                if(RandomNumber.randomSeed3 % 2 == 1){
                    ButtonBuff3--;
                }
                if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                    ButtonBuff3 = -1;
                    break;
                }
                }
            }
            break;
            }

            break;

            case 9:
            //day9,buff1
            switch(RandomNumber.randomSeed1 % 21)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            ButtonBuff1 = 20;
            if(ButtonBuff1 != -1){
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            ButtonBuff1 = 22;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
            ButtonBuff1 = 24;
            if(ButtonBuff1 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff1] == true){
                if(RandomNumber.randomSeed1 % 2 == 0){
                    ButtonBuff1++;
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
            //day9,buff2
            switch(RandomNumber.randomSeed2 % 21)
            {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            ButtonBuff2 = 21;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            ButtonBuff2 = 23;
            if(ButtonBuff2 != -1){
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
            ButtonBuff2 = 25;
            if(ButtonBuff2 != -1){
    
                while(TrapBuffs.Buffs[ButtonBuff2] == true){
                if(RandomNumber.randomSeed2 % 2 == 0){
                    ButtonBuff2++;
                }
                if(RandomNumber.randomSeed2 % 2 == 1){
                    ButtonBuff2--;
                }
                if(ButtonBuff2 == 30 || ButtonBuff2 == -1){
                    ButtonBuff2 = -1;
                    break;
                }
                }
            }
            break;
            }
            //day9,buff3
            switch(RandomNumber.randomSeed3 % 6)
            {
            case 0:
            case 1:
            case 2:
            ButtonBuff3 = 26;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                    if(RandomNumber.randomSeed3 % 2 == 0){
                        ButtonBuff3++;
                    }
                    if(RandomNumber.randomSeed3 % 2 == 1){
                        ButtonBuff3--;
                    }
                    if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                        ButtonBuff3 = -1;
                        break;
                    }
                }
            }
            break;
            case 3:
            case 4:
            case 5:
            ButtonBuff3 = 29;
            if(ButtonBuff3 != -1){
                while(TrapBuffs.Buffs[ButtonBuff3] == true){
                if(RandomNumber.randomSeed3 % 2 == 0){
                    ButtonBuff3++;
                }
                if(RandomNumber.randomSeed3 % 2 == 1){
                    ButtonBuff3--;
                }
                if(ButtonBuff3 == 30 || ButtonBuff3 == -1){
                    ButtonBuff3 = -1;
                    break;
                }
                }
            }
            break;
            }

            break;
        }

        // ButtonBuffMas = (GameObject)Resources.Load ("ButtonBuffMaster");
        // v = new Vector3(0,0,0);
        // Instantiate (ButtonBuffMas, v, Quaternion.identity);


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
