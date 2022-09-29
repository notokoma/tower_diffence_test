using UnityEngine;
using UnityEngine.EventSystems;

public class objectClick : MonoBehaviour, IPointerClickHandler
{

    public static int trapType;
    int a;

    // クリックされたときに呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject parent = transform.parent.gameObject;
        Transform parentTransform = parent.transform; 
        Vector3 parentPos = parentTransform.localPosition;    

        Transform myTransform = this.transform;
        Vector3 thisPos = myTransform.localPosition;

        //print(parentPos.x + "+" + thisPos.z);

        for(int i=0;i<11;i++){
            for(int j=0;j<11;j++){
                
        if (StageAllay.DeployStage[j,i] == 0 && i*2 == parentPos.x && j*-2+4 == thisPos.z){

        switch(trapType){
            case 1:
            if(StageAllay.TerrainStage[j,i] == 0){
                thisPos.x = parentPos.x;
                thisPos.y = thisPos.y + 2.0f;
                GameObject trapObj = (GameObject)Resources.Load ("firewall");
                Instantiate (trapObj, thisPos, Quaternion.identity);
                StageAllay.DeployStage[j,i] = 1;
            }
                break;
            case 2:
            if(StageAllay.TerrainStage[j,i] == 1){
                thisPos.x = parentPos.x;
                thisPos.y = thisPos.y + 3.0f;
                GameObject trapObj = (GameObject)Resources.Load ("Canon");
                Instantiate (trapObj, thisPos, Quaternion.identity);
                StageAllay.DeployStage[j,i] = 2;
            }
            break;
            default:
            break;
                    }
                }
            }
        }
        trapType = 0;
        Time.timeScale = 1.0f;
    }
}