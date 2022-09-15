using UnityEngine;
using UnityEngine.EventSystems;

public class objectClick : MonoBehaviour, IPointerClickHandler
{
    // クリックされたときに呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        int trapTypeN = 0;
        trapTypeN = ButtonTrap.trapType;

        Transform myTransform = this.transform;
        Vector3 Pos = myTransform.localPosition;
        Pos.x = 0.0f;    
        Pos.y = -2.0f;    
        Pos.z = 0.0f;    

        switch(trapTypeN){
            case 1:
                GameObject obj = (GameObject)Resources.Load ("firewall");
                Instantiate (obj, Pos, Quaternion.identity);
                break;
            default:
            break;
        }

        print(trapTypeN  + "+" + ButtonTrap.trapType );
    }
}