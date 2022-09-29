using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
public class ButtonScript : MonoBehaviour {
 
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        GameObject StartingPoint = GameObject.Find("enemyspawnpoint");
        Transform StartingPointTransform = StartingPoint.transform;
        Vector3 StartingPointPos = StartingPointTransform.position;
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load ("Enemy");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate (obj, StartingPointPos, Quaternion.identity);
    }
}