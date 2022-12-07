using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneticAlgorithm : MonoBehaviour
{
    public static int EnemyGeneticPhysics,EnemyGeneticMagic,EnemyGeneticHP,EnemyGeneticSpeed;
    public static int EnemyPhysicsBuff,EnemyMagicBuff,EnemyHPBuff;
    public static float EnemySpeedBuff;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch(EnemyGeneticHP){
            case 0:
            break;

            case 1:
            EnemyHPBuff = 20;
            break;

            case 2:
            EnemyHPBuff = 50;
            break;

            case 3:
            EnemyHPBuff = 90;
            break;

            case 4:
            EnemyHPBuff = 150;
            break;

            case 5:
            EnemyHPBuff = 225;
            break;

            case 6:
            EnemyHPBuff = 320;
            break;

            case 7:
            EnemyHPBuff = 400;
            break;

            case 8:
            EnemyHPBuff = 500;
            break;

            case 9:
            EnemyHPBuff = 650;
            break;
        }
        switch(EnemyGeneticPhysics){
            case 0:
            break;

            case 1:
            EnemyPhysicsBuff = 10;
            break;

            case 2:
            EnemyPhysicsBuff = 25;
            break;

            case 3:
            EnemyPhysicsBuff = 45;
            break;

            case 4:
            EnemyPhysicsBuff = 70;
            break;

            case 5:
            EnemyPhysicsBuff = 100;
            break;

            case 6:
            EnemyPhysicsBuff = 115;
            break;

            case 7:
            EnemyPhysicsBuff = 140;
            break;

            case 8:
            EnemyPhysicsBuff = 155;
            break;

            case 9:
            EnemyPhysicsBuff = 190;
            break;

        }
        switch(EnemyGeneticMagic){
            case 0:
            break;

            case 1:
            EnemyMagicBuff = 5;
            break;

            case 2:
            EnemyMagicBuff = 8;
            break;

            case 3:
            EnemyMagicBuff = 13;
            break;

            case 4:
            EnemyMagicBuff = 20;
            break;

            case 5:
            EnemyMagicBuff = 30;
            break;

            case 6:
            EnemyMagicBuff = 35;
            break;

            case 7:
            EnemyMagicBuff = 45;
            break;

            case 8:
            EnemyMagicBuff = 60;
            break;

            case 9:
            EnemyMagicBuff = 80;
            break;
        }
        switch(EnemyGeneticSpeed){
            case 0:
            case 1:
            break;

            case 2:
            case 3:
            EnemySpeedBuff = 0.2f;
            break;

            case 4:
            case 5:
            EnemySpeedBuff = 0.5f;
            break;

            case 6:
            case 7:
            EnemySpeedBuff = 0.9f;
            break;

            case 8:
            case 9:
            EnemySpeedBuff = 1.5f;
            break;
        }
    }
    public void GeneticStatus(){
        
    }
}
