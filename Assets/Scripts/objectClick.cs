using UnityEngine;
using UnityEngine.EventSystems;

public class objectClick : MonoBehaviour, IPointerClickHandler
{

    public static int trapType;
    public static int a;
    int TrapAngle;
    GameObject TrapObjFirewall, TrapObjCanon, TrapObjPulsar;
    GameObject parent;
    Transform parentTransform; 
    Vector3 parentPos;    
    Transform myTransform;
    Vector3 thisPos;

    void Start(){
        TrapObjFirewall = (GameObject)Resources.Load ("firewall");
        TrapObjCanon = (GameObject)Resources.Load ("Canon");
        TrapObjPulsar = (GameObject)Resources.Load ("Pulsar");
    }

    // クリックされたときに呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        parent = transform.parent.gameObject;
        parentTransform = parent.transform; 
        parentPos = parentTransform.localPosition;    
        myTransform = this.transform;
        thisPos = myTransform.localPosition;

        for(int i=0;i<11;i++){
            for(int j=0;j<11;j++){
            if(i*2 == thisPos.x && j*2 == parentPos.z){
            //print(StageAllay.TerrainStage[j,i] + "," + thisPos.x + "," + parentPos.z);
        if (StageAllay.DeployStage[j,i] == 0){
            thisPos.z = parentPos.z;
            switch(trapType){
                case 1:
                if(StageAllay.TerrainStage[j,i] == 0){
                    thisPos.y = thisPos.y + 1.1f;
                    Instantiate (TrapObjFirewall, thisPos, Quaternion.AngleAxis(90,Vector3.forward));
                    StageAllay.DeployStage[j,i] = 1;
                }
                break;
                case 2:
                if(StageAllay.TerrainStage[j,i] == 1){
                    thisPos.y = thisPos.y + 3.0f;
                    Instantiate (TrapObjCanon, thisPos, Quaternion.identity);
                    StageAllay.DeployStage[j,i] = 2;
                }
                break;
                case 3:
                if(StageAllay.TerrainStage[j,i] == 1){
                    thisPos.y = thisPos.y + 3.5f;
                    Instantiate (TrapObjPulsar, thisPos, Quaternion.identity);
                    StageAllay.DeployStage[j,i] = 3;
                }
                break;
            default:
            break;
            }          
            //Destroy(DeployAllows);
                    }
                }
            }
        }
        trapType = 0;
        Time.timeScale = 1.0f;
    }
}