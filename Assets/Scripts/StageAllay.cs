using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageAllay : MonoBehaviour
{
    //public GameObject Ground;
    //public GameObject HighGround;
    //public GameObject enemyspawnpoint;
    //public GameObject goalpoint;

    public static int[,] DeployStage = new int[11,11]{
        {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,-1,0,0,0,0,0,0,0,-1,-1},
        {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
    };

        public static int[,] TerrainStage = new int[11,11]{
        {1,1,1,1,1,1,1,1,1,1,1},
        {1,1,1,1,1,1,1,1,1,1,1},
        {1,1,1,1,1,1,1,1,1,1,1},
        {1,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,1,1,1,0,0,0,1},
        {1,0,0,0,1,1,1,0,0,0,1},
        {1,0,0,0,1,1,1,0,0,0,1},
        {1,0,0,0,1,1,1,0,0,0,1},
        {1,3,0,0,1,1,1,0,0,2,1},
        {1,1,1,1,1,1,1,1,1,1,1}
    };

    // Start is called before the first frame update
    void Start()
    {
        /* for(int i=0;i<TerrainStage.GetLength(0); i++){
            for(int j=0;j<TerrainStage.GetLength(1); j++){
                //床の配置
                Instantiate(Ground,new Vector3(i,0,j),Quaternion.identity);
                if(TerrainStage[i,j]==1){ //壁の配置
                    Instantiate(HighGround,new Vector3(i,1,j),Quaternion.identity);
                }else if(TerrainStage[i,j]==2){ //ゴールの配置
                    Instantiate(goalpoint,new Vector3(i,1,j),Quaternion.identity);
                }else if(TerrainStage[i,j]==3){ //敵出現地点の配置
                    Instantiate(enemyspawnpoint,new Vector3(i,1,j),Quaternion.identity);
                }
                }
            }
        */}
    }