using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageAllay : MonoBehaviour
{
    GameObject TrapObjFirewall;
    GameObject TrapObjCanon;

    public static int[,] DeployStage = new int[11,11]{
        {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        {-1,-1,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,0,0,0,0,0,0,0,0,0,-1},
        {-1,-1,0,0,0,0,0,0,0,0,-1},
        {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
    };

        public static int[,] TerrainStage = new int[11,11]{
        {1,1,1,1,1,1,1,1,1,1,1},
        {1,3,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,1},
        {1,1,1,1,1,1,1,0,0,0,1},
        {1,1,1,1,1,1,1,0,0,0,1},
        {1,1,1,1,1,1,1,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,1},
        {1,2,0,0,0,0,0,0,0,0,1},
        {1,1,1,1,1,1,1,1,1,1,1}
    };

    // Start is called before the first frame update
    void Start()
    {
        TrapObjFirewall = (GameObject)Resources.Load ("firewall");
        TrapObjCanon = (GameObject)Resources.Load ("Canon");

        for(int i=0;i<DeployStage.GetLength(0); i++){
            for(int j=0;j<DeployStage.GetLength(1); j++){
                if(DeployStage[i,j]==1){
                    Instantiate(TrapObjFirewall,new Vector3(j*2,1.1f,i*2),Quaternion.AngleAxis(90,Vector3.forward));
                }else if(DeployStage[i,j]==2){
                    Instantiate(TrapObjCanon,new Vector3(j*2,3,i*2),Quaternion.identity);
                }
            }
        }
    }
}