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

        thisPos.x = parentPos.x;
        thisPos.y = thisPos.y + 2.0f;
        Vector3 judgePos = thisPos;
        judgePos.y = judgePos.y + 1.0f;

        GameObject judgeObj = (GameObject)Resources.Load ("judge");
        Instantiate (judgeObj, judgePos, Quaternion.identity);
        

        print(judgePos);

        switch(trapType){
            case 1:
                GameObject trapObj = (GameObject)Resources.Load ("firewall");
                Instantiate (trapObj, thisPos, Quaternion.identity);
                break;
            default:
            break;
        }
    }
}