using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneticAlgorithm : MonoBehaviour
{
    public static int[] EnemyGeneticPhysics = new int[50];
    public static int[] EnemyGeneticMagic = new int[50];
    public static int[] EnemyGeneticHP = new int[50];
    public static int[] EnemyGeneticSpeed = new int[50];
    public static int[] EnemyPhysicsBuff,EnemyMagicBuff,EnemyHPBuff = new int[50];
    public static float[] EnemySpeedBuff = new float[50];
    int i,j,randomGenetic1,randomGenetic2;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad (this);
        j = 0;
        while(j < 50){
            EnemyGeneticHP[j] = 0;
            EnemyHPBuff[j] = 0;
            EnemyGeneticPhysics[j] = 0;
            EnemyPhysicsBuff[j] = 0;
            EnemyGeneticMagic[j] = 0;
            EnemyMagicBuff[j] = 0;
            EnemyGeneticSpeed[j] = 0;
            EnemySpeedBuff[j] = 0.0f;
            j++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GeneticBuffs(){
        switch(EnemyGeneticHP[GameScore.EnemyNumber]){
            case 0:
            break;

            case 1:
            EnemyHPBuff[GameScore.EnemyNumber] = 20;
            break;

            case 2:
            EnemyHPBuff[GameScore.EnemyNumber] = 50;
            break;

            case 3:
            EnemyHPBuff[GameScore.EnemyNumber] = 90;
            break;

            case 4:
            EnemyHPBuff[GameScore.EnemyNumber] = 150;
            break;

            case 5:
            EnemyHPBuff[GameScore.EnemyNumber] = 225;
            break;

            case 6:
            EnemyHPBuff[GameScore.EnemyNumber] = 320;
            break;

            case 7:
            EnemyHPBuff[GameScore.EnemyNumber] = 400;
            break;

            case 8:
            EnemyHPBuff[GameScore.EnemyNumber] = 500;
            break;

            case 9:
            EnemyHPBuff[GameScore.EnemyNumber] = 650;
            break;
        }
        switch(EnemyGeneticPhysics[GameScore.EnemyNumber]){
            case 0:
            break;

            case 1:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 10;
            break;

            case 2:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 25;
            break;

            case 3:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 45;
            break;

            case 4:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 70;
            break;

            case 5:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 100;
            break;

            case 6:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 115;
            break;

            case 7:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 140;
            break;

            case 8:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 155;
            break;

            case 9:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 190;
            break;

        }
        switch(EnemyGeneticMagic[GameScore.EnemyNumber]){
            case 0:
            break;

            case 1:
            EnemyMagicBuff[GameScore.EnemyNumber] = 5;
            break;

            case 2:
            EnemyMagicBuff[GameScore.EnemyNumber] = 8;
            break;

            case 3:
            EnemyMagicBuff[GameScore.EnemyNumber] = 13;
            break;

            case 4:
            EnemyMagicBuff[GameScore.EnemyNumber] = 20;
            break;

            case 5:
            EnemyMagicBuff[GameScore.EnemyNumber] = 30;
            break;

            case 6:
            EnemyMagicBuff[GameScore.EnemyNumber] = 35;
            break;

            case 7:
            EnemyMagicBuff[GameScore.EnemyNumber] = 45;
            break;

            case 8:
            EnemyMagicBuff[GameScore.EnemyNumber] = 60;
            break;

            case 9:
            EnemyMagicBuff[GameScore.EnemyNumber] = 80;
            break;
        }
        switch(EnemyGeneticSpeed[GameScore.EnemyNumber]){
            case 0:
            case 1:
            break;

            case 2:
            case 3:
            EnemySpeedBuff[GameScore.EnemyNumber] = 0.2f;
            break;

            case 4:
            case 5:
            EnemySpeedBuff[GameScore.EnemyNumber] = 0.5f;
            break;

            case 6:
            case 7:
            EnemySpeedBuff[GameScore.EnemyNumber] = 0.9f;
            break;

            case 8:
            case 9:
            EnemySpeedBuff[GameScore.EnemyNumber] = 1.5f;
            break;
        }
    }
    public void GeneticStatus()
    {
        //print("Genetic!");
        if(GameScore.StageNumber == 0){
            while(i < 5){
                randomGenetic1 = Random.Range(1, 5);
                randomGenetic2 = Random.Range(1, 5);
                while(randomGenetic1 == randomGenetic2)
                {
                    randomGenetic2 = Random.Range(1, 5);
                }

                switch(randomGenetic1){
                    case 1:
                    EnemyGeneticHP[GameScore.EnemyNumber + i] = 1;
                    break;

                    case 2:
                    EnemyGeneticPhysics[GameScore.EnemyNumber + i] = 1;
                    break;

                    case 3:
                    EnemyGeneticMagic[GameScore.EnemyNumber + i] = 1;
                    break;

                    case 4:
                    EnemyGeneticSpeed[GameScore.EnemyNumber + i] = 1;
                    break;
                }
                switch(randomGenetic2){
                    case 1:
                    EnemyGeneticHP[GameScore.EnemyNumber + i] = 1;
                    break;

                    case 2:
                    EnemyGeneticPhysics[GameScore.EnemyNumber + i] = 1;
                    break;

                    case 3:
                    EnemyGeneticMagic[GameScore.EnemyNumber + i] = 1;
                    break;

                    case 4:
                    EnemyGeneticSpeed[GameScore.EnemyNumber + i] = 1;
                    break;
                }
                print(EnemyGeneticHP[GameScore.EnemyNumber + i] + "," + 
                EnemyGeneticPhysics[GameScore.EnemyNumber + i] + "," +
                EnemyGeneticMagic[GameScore.EnemyNumber + i] + "," +
                EnemyGeneticSpeed[GameScore.EnemyNumber + i] );
                i++;
            }
        }
    }
}
