using UnityEngine;
using UnityEngine.EventSystems;

public class objectClick : MonoBehaviour, IPointerClickHandler
{

    public static int trapType;

    // クリックされたときに呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {

        Transform myTransform = this.transform;
        Vector3 Pos = myTransform.localPosition;    
        Pos.x = Pos.x + 2.0f;
        Pos.y = Pos.y + 2.0f;    

        print(this.transform);
        print(Pos);

        switch(trapType){
            case 1:
                GameObject obj = (GameObject)Resources.Load ("firewall");
                Instantiate (obj, Pos, Quaternion.identity);
                break;
            default:
            break;
        }

        print(trapType);
    }
}