using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DeployMarker : MonoBehaviour
{
    GameObject Marker;
    public void OnPointerClick(PointerEventData eventData){
        Marker = GameObject.FindWithTag("DeployMarker");
        Destroy(Marker);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
