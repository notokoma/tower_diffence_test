using UnityEngine;
using UnityEngine.EventSystems;

public class objectClick : MonoBehaviour, IPointerClickHandler
{

    public static int trapType;
    public static int a;
    int DeployProcess = 0;
    int TrapAngle;
    GameObject DeployAllows;
    GameObject TrapObjFirewall;
    GameObject TrapObjCanon;
    GameObject parent;
    Transform parentTransform; 
    Vector3 parentPos;    
    Transform myTransform;
    Vector3 thisPos;

    void Start(){
        DeployAllows = (GameObject)Resources.Load ("DeployMarkerOut");
        TrapObjFirewall = (GameObject)Resources.Load ("firewall");
        TrapObjCanon = (GameObject)Resources.Load ("Canon");
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
        if (StageAllay.DeployStage[j,i] == 0 && DeployProcess == 0){
            thisPos.z = parentPos.z;
            switch(trapType){
                case 1:
                if(StageAllay.TerrainStage[j,i] == 0){
                    thisPos.y = thisPos.y + 2.5f;
                    DeployProcess = 1;
                }
                break;
                case 2:
                if(StageAllay.TerrainStage[j,i] == 1){
                    thisPos.y = thisPos.y + 3.5f;
                    DeployProcess = 1;
                }
                break;
            default:
            break;
            }
            
        switch(trapType){
            case 1:
                thisPos.y = thisPos.y - 1.4f;
                Instantiate (TrapObjFirewall, thisPos, Quaternion.AngleAxis(90,Vector3.forward));
                StageAllay.DeployStage[j,i] = 1;
                break;
            case 2:
                thisPos.y = thisPos.y - 0.5f;
                Instantiate (TrapObjCanon, thisPos, Quaternion.identity);
                StageAllay.DeployStage[j,i] = 2;
                break;
            default:
            break;
        }
            
            //Destroy(DeployAllows);
                    }
                }
            }
        }
        DeployProcess = 0;
        trapType = 0;
        Time.timeScale = 1.0f;
    }
}