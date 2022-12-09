using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneticAlgorithm : MonoBehaviour
{
    public static int[] EnemyGeneticPhysics = new int[50];
    public static int[] EnemyGeneticMagic = new int[50];
    public static int[] EnemyGeneticHP = new int[50];
    public static int[] EnemyGeneticSpeed = new int[50];
    public static int[] EnemyPhysicsBuff = new int[50];
    public static int[] EnemyMagicBuff = new int[50];
    public static int[] EnemyHPBuff = new int[50];
    public static float[] EnemySpeedBuff = new float[50];
    int[] EliteGeneticSurviveTime = new int[4];
    int[] EliteGeneticDestination = new int[4];
    int i,j,randomGenetic1,randomGenetic2,randomMutation,randomGene,MutetionTrance1,MutetionTrance2,MutetionTranceNumber1,MutetionTranceNumber2;
    float SurviveTimeMax,DestinationMin;
    int SurviveTimeMaxNumber,DestinationMinNumber;
    // Start is called before the first frame update
    void Start()
    {
        //print("start");
        DontDestroyOnLoad (this);
        i = 0;
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
        print(EnemyGeneticHP[GameScore.EnemyNumber] + "," + EnemyGeneticPhysics[GameScore.EnemyNumber] + "," + EnemyGeneticPhysics[GameScore.EnemyNumber] + "," + EnemyGeneticSpeed[GameScore.EnemyNumber]);
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
            EnemyHPBuff[GameScore.EnemyNumber] = 80;
            break;

            case 4:
            EnemyHPBuff[GameScore.EnemyNumber] = 120;
            break;

            case 5:
            EnemyHPBuff[GameScore.EnemyNumber] = 175;
            break;

            case 6:
            EnemyHPBuff[GameScore.EnemyNumber] = 200;
            break;

            case 7:
            EnemyHPBuff[GameScore.EnemyNumber] = 240;
            break;

            case 8:
            EnemyHPBuff[GameScore.EnemyNumber] = 300;
            break;

            case 9:
            EnemyHPBuff[GameScore.EnemyNumber] = 380;
            break;
        }
        switch(EnemyGeneticPhysics[GameScore.EnemyNumber]){
            case 0:
            break;

            case 1:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 5;
            break;

            case 2:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 10;
            break;

            case 3:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 15;
            break;

            case 4:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 25;
            break;

            case 5:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 40;
            break;

            case 6:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 45;
            break;

            case 7:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 60;
            break;

            case 8:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 80;
            break;

            case 9:
            EnemyPhysicsBuff[GameScore.EnemyNumber] = 100;
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
            EnemyMagicBuff[GameScore.EnemyNumber] = 42;
            break;

            case 8:
            EnemyMagicBuff[GameScore.EnemyNumber] = 50;
            break;

            case 9:
            EnemyMagicBuff[GameScore.EnemyNumber] = 65;
            break;
        }
        switch(EnemyGeneticSpeed[GameScore.EnemyNumber]){
            case 0:
            break;
            case 1:
            EnemySpeedBuff[GameScore.EnemyNumber] = 0.3f;
            break;

            case 2:
            case 3:
            EnemySpeedBuff[GameScore.EnemyNumber] = 0.6f;
            break;

            case 4:
            case 5:
            EnemySpeedBuff[GameScore.EnemyNumber] = 1.0f;
            break;

            case 6:
            case 7:
            EnemySpeedBuff[GameScore.EnemyNumber] = 1.5f;
            break;

            case 8:
            case 9:
            EnemySpeedBuff[GameScore.EnemyNumber] = 1.8f;
            break;
        }
    }
    public void GeneticStatus()
    {
        //print("Genetic!");
        if(GameScore.StageNumber == 0){
            i = 0;
            while(i < 5){
                randomGenetic1 = UnityEngine.Random.Range(1, 5);
                randomGenetic2 = UnityEngine.Random.Range(1, 5);
                while(randomGenetic1 == randomGenetic2)
                {
                    randomGenetic2 = UnityEngine.Random.Range(1, 5);
                }

                switch(randomGenetic1){
                    case 1:
                    EnemyGeneticHP[GameScore.EnemyNumber + i]++;
                    break;

                    case 2:
                    EnemyGeneticPhysics[GameScore.EnemyNumber + i]++;
                    break;

                    case 3:
                    EnemyGeneticMagic[GameScore.EnemyNumber + i]++;
                    break;

                    case 4:
                    EnemyGeneticSpeed[GameScore.EnemyNumber + i]++;
                    break;
                }
                switch(randomGenetic2){
                    case 1:
                    EnemyGeneticHP[GameScore.EnemyNumber + i]++;
                    break;

                    case 2:
                    EnemyGeneticPhysics[GameScore.EnemyNumber + i]++;
                    break;

                    case 3:
                    EnemyGeneticMagic[GameScore.EnemyNumber + i]++;
                    break;

                    case 4:
                    EnemyGeneticSpeed[GameScore.EnemyNumber + i]++;
                    break;
                }
                // print(EnemyGeneticHP[GameScore.EnemyNumber + i] + "," + 
                // EnemyGeneticPhysics[GameScore.EnemyNumber + i] + "," +
                // EnemyGeneticMagic[GameScore.EnemyNumber + i] + "," +
                // EnemyGeneticSpeed[GameScore.EnemyNumber + i] );
                i++;
            }
        } else {
            i = 0;
            while(i < 5){
                // print(EnemyGeneticHP[0 + i] + "," + 
                // EnemyGeneticPhysics[0 + i] + "," +
                // EnemyGeneticMagic[0 + i] + "," +
                // EnemyGeneticSpeed[0 + i] );
                i++;
            }
            SurviveTimeMax = GameScore.EnemySurviveTime[0];
            SurviveTimeMaxNumber = 0;
            if(GameScore.EnemySurviveTime[1] > SurviveTimeMax){
                SurviveTimeMax = GameScore.EnemySurviveTime[1];
                SurviveTimeMaxNumber = 1;
            }
            if(GameScore.EnemySurviveTime[2] > SurviveTimeMax){
                SurviveTimeMax = GameScore.EnemySurviveTime[2];
                SurviveTimeMaxNumber = 2;
            }
            if(GameScore.EnemySurviveTime[3] > SurviveTimeMax){
                SurviveTimeMax = GameScore.EnemySurviveTime[3];
                SurviveTimeMaxNumber = 3;
            }
            if(GameScore.EnemySurviveTime[4] > SurviveTimeMax){
                SurviveTimeMax = GameScore.EnemySurviveTime[4];
                SurviveTimeMaxNumber = 4;
            }

            DestinationMin = GameScore.EnemyDestination[0];
            DestinationMinNumber = 0;
            if(GameScore.EnemyDestination[1] < DestinationMin) 
            {
                DestinationMin = GameScore.EnemyDestination[1];
                DestinationMinNumber = 1;
            }
            if(GameScore.EnemyDestination[2] < DestinationMin) 
            {
                DestinationMin = GameScore.EnemyDestination[2];
                DestinationMinNumber = 2;
            }
            if(GameScore.EnemyDestination[3] < DestinationMin) 
            {
                DestinationMin = GameScore.EnemyDestination[3];
                DestinationMinNumber = 3;
            }
            if(GameScore.EnemyDestination[4] < DestinationMin) 
            {
                DestinationMin = GameScore.EnemyDestination[4];
                DestinationMinNumber = 4;
            }

            //print(SurviveTimeMax + "," + SurviveTimeMaxNumber + "," + DestinationMin + "," + DestinationMinNumber);
            EliteGeneticSurviveTime[0] = EnemyGeneticHP[SurviveTimeMaxNumber + (GameScore.StageNumber - 1) * 5];
            EliteGeneticSurviveTime[1] = EnemyGeneticPhysics[SurviveTimeMaxNumber + (GameScore.StageNumber - 1) * 5];
            EliteGeneticSurviveTime[2] = EnemyGeneticMagic[SurviveTimeMaxNumber + (GameScore.StageNumber - 1) * 5];
            EliteGeneticSurviveTime[3] = EnemyGeneticSpeed[SurviveTimeMaxNumber + (GameScore.StageNumber - 1) * 5];
            EliteGeneticDestination[0] = EnemyGeneticHP[DestinationMinNumber + (GameScore.StageNumber - 1) * 5];
            EliteGeneticDestination[1] = EnemyGeneticPhysics[DestinationMinNumber + (GameScore.StageNumber - 1) * 5];
            EliteGeneticDestination[2] = EnemyGeneticMagic[DestinationMinNumber + (GameScore.StageNumber - 1) * 5];
            EliteGeneticDestination[3] = EnemyGeneticSpeed[DestinationMinNumber + (GameScore.StageNumber - 1) * 5];

            i = 0;
            while(i<4){
                //print(EliteGeneticSurviveTime[i] + " , " + EliteGeneticDestination[i]);
                i++;
            }

            randomGenetic1 = UnityEngine.Random.Range(1, 5);
            randomGenetic2 = UnityEngine.Random.Range(1, 5);
            randomMutation = UnityEngine.Random.Range(1, 4);

            if(randomMutation == 3){ // 突然変異
                switch(randomGenetic1){
                    case 1:
                    MutetionTrance1 = EliteGeneticSurviveTime[0]--;
                    MutetionTranceNumber1 = 0;
                    break;

                    case 2:
                    MutetionTrance1 = EliteGeneticSurviveTime[1]--;
                    MutetionTranceNumber1 = 1;
                    break;

                    case 3:
                    MutetionTrance1 = EliteGeneticSurviveTime[2]--;
                    MutetionTranceNumber1 = 2;
                    break;

                    case 4:
                    MutetionTrance1 = EliteGeneticSurviveTime[3]--;
                    MutetionTranceNumber1 = 3;
                    break;
                }
                switch(randomGenetic2){
                    case 1:
                    MutetionTrance2 = EliteGeneticDestination[0]--;
                    MutetionTranceNumber2 = 0;
                    break;

                    case 2:
                    MutetionTrance2 = EliteGeneticDestination[1]--;
                    MutetionTranceNumber2 = 1;
                    break;

                    case 3:
                    MutetionTrance2 = EliteGeneticDestination[2]--;
                    MutetionTranceNumber2 = 2;
                    break;

                    case 4:
                    MutetionTrance2 = EliteGeneticDestination[3]--;
                    MutetionTranceNumber2 = 3;
                    break;
                }
                EliteGeneticSurviveTime[MutetionTranceNumber1] = MutetionTrance2;
                EliteGeneticDestination[MutetionTranceNumber2] = MutetionTrance1;

            }
            
            i = 0;
            while(i < 5){
                randomGene = UnityEngine.Random.Range(0, 2);
                if(randomGene == 0){
                    EnemyGeneticHP[GameScore.EnemyNumber + i] = /* EnemyGeneticHP[GameScore.EnemyNumber] + */ EliteGeneticSurviveTime[0];
                } else {
                    EnemyGeneticHP[GameScore.EnemyNumber + i] = /* EnemyGeneticHP[GameScore.EnemyNumber] + */ EliteGeneticDestination[0];
                }
                randomGene = UnityEngine.Random.Range(0, 2);
                if(randomGene == 0){
                    EnemyGeneticPhysics[GameScore.EnemyNumber + i] = /* EnemyGeneticPhysics[GameScore.EnemyNumber] + */ EliteGeneticSurviveTime[1];
                } else {
                    EnemyGeneticPhysics[GameScore.EnemyNumber + i] = /* EnemyGeneticPhysics[GameScore.EnemyNumber] + */ EliteGeneticDestination[1];
                }
                randomGene = UnityEngine.Random.Range(0, 2);
                if(randomGene == 0){
                    EnemyGeneticMagic[GameScore.EnemyNumber + i] = /* EnemyGeneticMagic[GameScore.EnemyNumber] + */ EliteGeneticSurviveTime[2];
                } else {
                    EnemyGeneticMagic[GameScore.EnemyNumber + i] = /* EnemyGeneticMagic[GameScore.EnemyNumber] + */ EliteGeneticDestination[2];
                }
                randomGene = UnityEngine.Random.Range(0, 2);
                if(randomGene == 0){
                    EnemyGeneticSpeed[GameScore.EnemyNumber + i] = /* EnemyGeneticSpeed[GameScore.EnemyNumber] + */ EliteGeneticSurviveTime[3];
                } else {
                    EnemyGeneticSpeed[GameScore.EnemyNumber + i] = /* EnemyGeneticSpeed[GameScore.EnemyNumber] + */ EliteGeneticDestination[3];
                }
                i++;
            }
            
            i = 0;
            while(i < 5){
                randomGenetic1 = UnityEngine.Random.Range(1, 5);
                randomGenetic2 = UnityEngine.Random.Range(1, 5);
                while(randomGenetic1 == randomGenetic2)
                {
                    randomGenetic2 = UnityEngine.Random.Range(1, 5);
                }

                switch(randomGenetic1){
                    case 1:
                    EnemyGeneticHP[GameScore.EnemyNumber + i]+=1;
                    break;

                    case 2:
                    EnemyGeneticPhysics[GameScore.EnemyNumber + i]+=1;
                    break;

                    case 3:
                    EnemyGeneticMagic[GameScore.EnemyNumber + i]+=1;
                    break;

                    case 4:
                    EnemyGeneticSpeed[GameScore.EnemyNumber + i]+=1;
                    break;
                }
                switch(randomGenetic2){
                    case 1:
                    EnemyGeneticHP[GameScore.EnemyNumber + i]+=1;
                    break;

                    case 2:
                    EnemyGeneticPhysics[GameScore.EnemyNumber + i]+=1;
                    break;

                    case 3:
                    EnemyGeneticMagic[GameScore.EnemyNumber + i]+=1;
                    break;

                    case 4:
                    EnemyGeneticSpeed[GameScore.EnemyNumber + i]+=1;
                    break;
                }
                i++;

                //print(EnemyGeneticHP[GameScore.EnemyNumber + i] + " , " + EnemyGeneticPhysics[GameScore.EnemyNumber + i] + " , " + EnemyGeneticMagic[GameScore.EnemyNumber + i] + " , " + EnemyGeneticSpeed[GameScore.EnemyNumber + i]);
            }
        }
        i = 0;
        while(i < 5){
            if(EnemyGeneticHP[GameScore.EnemyNumber] >= 10){
                EnemyGeneticHP[GameScore.EnemyNumber] = 9;
            }
            if(EnemyGeneticPhysics[GameScore.EnemyNumber + i] >= 10){
                EnemyGeneticPhysics[GameScore.EnemyNumber + i] = 9;
            }
            if(EnemyGeneticMagic[GameScore.EnemyNumber + i] >= 10){
                EnemyGeneticMagic[GameScore.EnemyNumber + i] = 9;
            }
            if(EnemyGeneticSpeed[GameScore.EnemyNumber + i] >= 10){
                EnemyGeneticSpeed[GameScore.EnemyNumber + i] = 9;
            }
            i++;
        }
        
    }
}